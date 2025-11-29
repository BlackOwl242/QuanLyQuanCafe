using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using MimeKit;
using System.Drawing;
using QuanLyQuanCaPhe.DAO;
using QuanLyQuanCaPhe.DTO;

namespace QuanLyQuanCaPhe.BLL
{
    public class EventBLL
    {
        private GmailService _gmailService;
        private UserCredential _credential;
        private bool _isAuthenticated = false;

        public bool IsAuthenticated => _isAuthenticated;

        public async Task<bool> InitializeOAuth2Async()
        {
            try
            {
                // Đường dẫn tới file credentials.json (tải từ Google Cloud Console)
                string credentialsPath = "credentials.json";

                if (!File.Exists(credentialsPath))
                {
                    MessageBox.Show("Không tìm thấy file credentials.json. Vui lòng tải từ Google Cloud Console.",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                using (var stream = new FileStream(credentialsPath, FileMode.Open, FileAccess.Read))
                {
                    string credPath = "token.json";
                    _credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets,
                        new[] { GmailService.Scope.GmailSend },
                        "user",
                        CancellationToken.None,
                        new FileDataStore(credPath, true));
                }

                // Tạo Gmail service
                _gmailService = new GmailService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = _credential,
                    ApplicationName = "QuanLyQuanCaPhe Email Service"
                });

                _isAuthenticated = true;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi khởi tạo OAuth2: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _isAuthenticated = false;
                return false;
            }
        }

        public async Task<bool> SendEmailAsync(string toEmail, string subject, string content, Image attachment = null)
        {
            try
            {
                if (_gmailService == null || !_isAuthenticated)
                {
                    MessageBox.Show("Vui lòng authenticate với Google trước.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(toEmail))
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ email người nhận.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                var message = new MimeMessage();
                message.To.Add(new MailboxAddress("", toEmail));
                message.Subject = subject ?? "Thông báo từ QuanLyQuanCaPhe";

                // Tạo nội dung email
                var builder = new BodyBuilder();
                builder.TextBody = content ?? "";

                // Thêm attachment nếu có
                if (attachment != null)
                {
                    using (var stream = new MemoryStream())
                    {
                        attachment.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                        stream.Position = 0;
                        builder.Attachments.Add("attachment.png", stream.ToArray(), ContentType.Parse("image/png"));
                    }
                }

                message.Body = builder.ToMessageBody();

                using (var stream = new MemoryStream())
                {
                    await message.WriteToAsync(stream);
                    var gmailMessage = new Google.Apis.Gmail.v1.Data.Message
                    {
                        Raw = Convert.ToBase64String(stream.ToArray())
                            .Replace('+', '-')
                            .Replace('/', '_')
                            .Replace("=", "")
                    };

                    await _gmailService.Users.Messages.Send(gmailMessage, "me").ExecuteAsync();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi gửi email: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<bool> SendEmailToMultipleRecipientsAsync(List<string> emailList, string subject, string content, Image attachment = null)
        {
            try
            {
                if (emailList == null || emailList.Count == 0)
                {
                    MessageBox.Show("Danh sách email trống.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                int successCount = 0;
                int totalCount = emailList.Count;

                foreach (string email in emailList)
                {
                    if (!string.IsNullOrWhiteSpace(email))
                    {
                        bool result = await SendEmailAsync(email, subject, content, attachment);
                        if (result)
                        {
                            successCount++;
                        }

                        // Delay nhỏ giữa các email để tránh rate limit
                        await Task.Delay(500);
                    }
                }

                MessageBox.Show($"Đã gửi thành công {successCount}/{totalCount} email.",
                    "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return successCount > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi gửi email hàng loạt: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Client management methods
        public List<Client> GetListClient()
        {
            return ClientDAO.Instance.GetListClient();
        }

        public DataTable GetClientTable()
        {
            return ClientDAO.Instance.GetClientTable();
        }

        public List<Client> SearchClients(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return GetListClient();
            }
            return ClientDAO.Instance.SearchClients(keyword);
        }

        public DataTable SearchClientsAsDataTable(string keyword)
        {
            List<Client> clients = SearchClients(keyword);
            DataTable dataTable = new DataTable();

            // Tạo columns
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("ClientName", typeof(string));
            dataTable.Columns.Add("ClientEmail", typeof(string));
            dataTable.Columns.Add("ClientNumber", typeof(string));
            dataTable.Columns.Add("BonusPoint", typeof(int));
            dataTable.Columns.Add("CreatedDay", typeof(DateTime));

            // Thêm dữ liệu
            foreach (Client client in clients)
            {
                dataTable.Rows.Add(
                    client.ID,
                    client.Name,
                    client.Email,
                    client.PhoneNumber,
                    client.BonusPoint,
                    client.CreatedDay
                );
            }

            return dataTable;
        }

        public Client GetClientByPhoneNumber(string phoneNumber)
        {
            var clients = GetListClient();
            return clients.Find(c => c.PhoneNumber == phoneNumber);
        }

        public Client GetClientById(int id)
        {
            var clients = GetListClient();
            return clients.Find(c => c.ID == id);
        }
    }
}
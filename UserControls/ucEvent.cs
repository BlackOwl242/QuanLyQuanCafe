using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCaPhe.BLL;
using QuanLyQuanCaPhe.DTO;

namespace QuanLyQuanCaPhe.UserControls
{
    public partial class ucEvent : UserControl
    {
        private EventBLL eventBLL;
        private List<string> clientEmails;
        private OpenFileDialog openFileDialog;

        public ucEvent()
        {
            InitializeComponent();
            InitializeEventHandlers();
            InitializeData();
        }

        #region Methods
        private void InitializeEventHandlers()
        {
            // Gán sự kiện cho các button
            btnSend.Click += BtnSend_Click;
            btnSendToAll.Click += BtnSendToAll_Click;
            btnSearch.Click += BtnSearch_Click;
            btnUpload.Click += BtnUpload_Click;
            txtSearch.KeyDown += TxtSearch_KeyDown;

            // Khởi tạo EventBLL và authenticate
            InitializeEmailService();
        }

        private async void InitializeEmailService()
        {
            try
            {
                eventBLL = new EventBLL();
                bool success = await eventBLL.InitializeOAuth2Async();

                if (success)
                {
                    // Có thể thêm indicator để hiển thị trạng thái authentication
                    MessageBox.Show("OAuth2 authentication thành công!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi khởi tạo dịch vụ email: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeData()
        {
            // Khởi tạo danh sách email
            clientEmails = new List<string>();

            // Cấu hình DataGridView
            SetupDataGridView();

            // Khởi tạo OpenFileDialog
            openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                Title = "Chọn ảnh để đính kèm"
            };

            // Load dữ liệu từ database
            LoadClientData();
        }

        private void SetupDataGridView()
        {
            // Cấu hình columns cho DataGridView - chỉ hiển thị tên và email
            dgvClient.Columns.Clear();
            dgvClient.Columns.Add("ID", "ID");
            dgvClient.Columns.Add("ClientName", "Tên khách hàng");
            dgvClient.Columns.Add("ClientEmail", "Email");

            // Thiết lập width cho các columns
            dgvClient.Columns["ID"].Width = 50;
            dgvClient.Columns["ID"].Visible = false; // Ẩn cột ID
            dgvClient.Columns["ClientName"].Width = 180;
            dgvClient.Columns["ClientEmail"].Width = 200;

            // Cho phép chọn nhiều hàng
            dgvClient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClient.MultiSelect = true;
            dgvClient.AllowUserToAddRows = false;
            dgvClient.ReadOnly = true;

            // Thiết lập AutoSizeMode cho columns
            dgvClient.Columns["ClientName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvClient.Columns["ClientEmail"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        #endregion

        #region Data Loading Methods
        private void LoadClientData()
        {
            try
            {
                if (eventBLL == null)
                {
                    eventBLL = new EventBLL();
                }

                List<Client> clients = eventBLL.GetListClient();
                LoadClientsToDataGridView(clients);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load dữ liệu khách hàng: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadClientsToDataGridView(List<Client> clients)
        {
            dgvClient.Rows.Clear();

            foreach (Client client in clients)
            {
                // Chỉ thêm ID (ẩn), tên và email
                dgvClient.Rows.Add(
                    client.ID,
                    client.Name,
                    client.Email
                );
            }
        }
        #endregion

        #region Event Handlers
        // Button "Gửi" - Gửi cho những khách hàng được chọn
        private async void BtnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (eventBLL == null || !eventBLL.IsAuthenticated)
                {
                    MessageBox.Show("Dịch vụ email chưa được khởi tạo. Vui lòng thử lại.",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lấy danh sách email được chọn
                List<string> selectedEmails = GetSelectedEmails();

                if (selectedEmails.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một khách hàng để gửi email.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string subject = txtSubject.Text.Trim();
                string content = rtbContent.Text.Trim();

                if (string.IsNullOrEmpty(subject))
                {
                    MessageBox.Show("Vui lòng nhập chủ đề email.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xác nhận gửi cho khách hàng được chọn
                var result = MessageBox.Show($"Bạn có chắc chắn muốn gửi email cho {selectedEmails.Count} khách hàng đã chọn?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                {
                    return;
                }

                // Hiển thị progress
                btnSend.Enabled = false;
                btnSend.Text = "Đang gửi...";
                btnSendToAll.Enabled = false;

                // Gửi email
                Image attachment = pbUpload.Image;
                bool success = await eventBLL.SendEmailToMultipleRecipientsAsync(selectedEmails, subject, content, attachment);

                if (success)
                {
                    // Clear form sau khi gửi thành công
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi gửi email: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSend.Enabled = true;
                btnSend.Text = "Gửi";
                btnSendToAll.Enabled = true;
            }
        }

        // Button "Gửi tất cả" - Gửi cho tất cả khách hàng
        private async void BtnSendToAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (eventBLL == null || !eventBLL.IsAuthenticated)
                {
                    MessageBox.Show("Dịch vụ email chưa được khởi tạo. Vui lòng thử lại.",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string subject = txtSubject.Text.Trim();
                string content = rtbContent.Text.Trim();

                if (string.IsNullOrEmpty(subject))
                {
                    MessageBox.Show("Vui lòng nhập chủ đề email.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy tất cả email từ DataGridView
                List<string> allEmails = GetAllClientEmails();

                if (allEmails.Count == 0)
                {
                    MessageBox.Show("Không có khách hàng nào có email để gửi.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xác nhận gửi cho tất cả
                var result = MessageBox.Show($"Bạn có chắc chắn muốn gửi email cho TẤT CẢ {allEmails.Count} khách hàng?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                {
                    return;
                }

                // Hiển thị progress
                btnSendToAll.Enabled = false;
                btnSendToAll.Text = "Đang gửi...";
                btnSend.Enabled = false;

                // Gửi email
                Image attachment = pbUpload.Image;
                bool success = await eventBLL.SendEmailToMultipleRecipientsAsync(allEmails, subject, content, attachment);

                if (success)
                {
                    // Clear form sau khi gửi thành công
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi gửi email cho tất cả: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSendToAll.Enabled = true;
                btnSend.Enabled = true;
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchClients();
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchClients();
            }
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Image image = Image.FromFile(openFileDialog.FileName);
                    pbUpload.Image = image;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải ảnh: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Helper Methods
        // Method để lấy email của khách hàng được chọn
        private List<string> GetSelectedEmails()
        {
            List<string> emails = new List<string>();

            foreach (DataGridViewRow row in dgvClient.SelectedRows)
            {
                if (row.Cells["ClientEmail"].Value != null)
                {
                    string email = row.Cells["ClientEmail"].Value.ToString();
                    if (!string.IsNullOrWhiteSpace(email))
                    {
                        emails.Add(email);
                    }
                }
            }

            return emails;
        }

        // Method để lấy tất cả email khách hàng
        private List<string> GetAllClientEmails()
        {
            List<string> emails = new List<string>();

            foreach (DataGridViewRow row in dgvClient.Rows)
            {
                if (row.Cells["ClientEmail"].Value != null)
                {
                    string email = row.Cells["ClientEmail"].Value.ToString();
                    if (!string.IsNullOrWhiteSpace(email))
                    {
                        emails.Add(email);
                    }
                }
            }

            return emails;
        }

        private void SearchClients()
        {
            try
            {
                if (eventBLL == null)
                {
                    eventBLL = new EventBLL();
                }

                string searchTerm = txtSearch.Text.Trim();

                List<Client> clients;
                if (string.IsNullOrEmpty(searchTerm))
                {
                    // Hiển thị tất cả dữ liệu
                    clients = eventBLL.GetListClient();
                }
                else
                {
                    // Tìm kiếm theo từ khóa
                    clients = eventBLL.SearchClients(searchTerm);
                }

                LoadClientsToDataGridView(clients);

                // Hiển thị thông báo kết quả tìm kiếm
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    MessageBox.Show($"Tìm thấy {clients.Count} khách hàng phù hợp.",
                        "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtSubject.Clear();
            rtbContent.Clear();
            pbUpload.Image = null;
            dgvClient.ClearSelection();
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using QuanLyQuanCaPhe.DAO;
using QuanLyQuanCaPhe.BLL;

namespace QuanLyQuanCaPhe.UserControls
{
    public partial class ucAccountManagement: UserControl
    {
        // Import hàm CreateRoundRectRgn từ Gdi32.dll để tạo hình tròn cho nút
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public ucAccountManagement()
        {
            InitializeComponent();
            LoadAccountList();
            dgvAccount.AllowUserToAddRows = false;
        }

        #region Method
        private AccountBLL accountBLL = new AccountBLL();
        string employeeName = SessionManager.CurrentAccount.DisplayName;

        // Biến để xác định chế độ thêm mới
        private bool isAddNewMode = false;

        void LoadAccountList()
        {
            string query = "SELECT UserName AS [Tên tài khoản], DisplayName AS [Tên hiển thị], CASE Type WHEN 1 THEN 'Admin' ELSE 'Nhân viên' END AS [Loại tài khoản] FROM dbo.Account";
            dgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void ClearBinding()
        {
            // Ngắt liên kết dữ liệu
            txtUserName.DataBindings.Clear();
            txtDisplayName.DataBindings.Clear();
            cbType.DataBindings.Clear();
        }

        void SetBinding()
        {
            ClearBinding();

            txtUserName.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "Tên tài khoản", true, DataSourceUpdateMode.Never));
            txtDisplayName.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "Tên hiển thị", true, DataSourceUpdateMode.Never));
            cbType.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "Loại tài khoản", true, DataSourceUpdateMode.Never));

            // Ở chế độ xem/sửa, không cho phép thay đổi Tên tài khoản (khóa chính)
            txtUserName.ReadOnly = true;
            isAddNewMode = false; // Tắt cờ "Thêm mới"
        }

        void ResetPassword(string userName)
        {
            if (accountBLL.ResetPassword(userName))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Event
        private void ucAccountManagement_Load(object sender, EventArgs e)
        {
            btnAdd.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, btnAdd.Width, btnAdd.Height, 15, 15));
            btnEdit.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, btnEdit.Width, btnEdit.Height, 15, 15));
            btnDelete.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, btnDelete.Width, btnDelete.Height, 15, 15));
            btnView.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, btnView.Width, btnView.Height, 15, 15));
            btnResetPassword.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, btnResetPassword.Width, btnResetPassword.Height, 15, 15));

            // --- Gán các sự kiện ---
            dgvAccount.CellClick += DgvAccount_CellClick;
            txtUserName.Enter += TxtUserName_Enter; // Sự kiện quan trọng để vào chế độ "Thêm mới"

            // --- Thiết lập trạng thái ban đầu ---
            SetBinding();
        }

        private void TxtUserName_Enter(object sender, EventArgs e)
        {
            // Chỉ chuyển sang chế độ thêm mới nếu chưa ở chế độ đó
            if (!isAddNewMode)
            {
                isAddNewMode = true; // Bật cờ "Thêm mới"

                ClearBinding(); // Ngắt liên kết dữ liệu

                // Xóa trắng các ô và đặt giá trị mặc định
                txtUserName.Text = "";
                txtDisplayName.Text = "";
                cbType.SelectedIndex = 1; // Mặc định là "Nhân viên"

                txtUserName.ReadOnly = false; // Cho phép nhập tên tài khoản
            }
        }

        private void DgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isAddNewMode)
            {
                isAddNewMode = false;
                btnAdd.Text = "Thêm";
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnResetPassword.Enabled = true;
                btnView.Enabled = true;
                dgvAccount.Enabled = true;
            }
            SetBinding();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!isAddNewMode)
            {
                // Vào chế độ thêm mới
                isAddNewMode = true;
                ClearBinding();

                txtUserName.Text = "";
                txtDisplayName.Text = "";
                cbType.SelectedIndex = 1; // Mặc định là "Nhân viên"
                txtUserName.ReadOnly = false;

                btnAdd.Text = "Lưu";
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnResetPassword.Enabled = false;
                btnView.Enabled = false;
                dgvAccount.Enabled = false;
                return;
            }
            else
            {
                // Đang ở chế độ thêm mới, thực hiện lưu
                string userName = txtUserName.Text.Trim();
                string displayName = txtDisplayName.Text.Trim();

                if (string.IsNullOrWhiteSpace(userName))
                {
                    MessageBox.Show("Tên tài khoản không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(displayName))
                {
                    MessageBox.Show("Tên hiển thị không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (accountBLL.GetAccountByUserName(userName) != null)
                {
                    MessageBox.Show("Tên tài khoản '" + userName + "' đã tồn tại. Vui lòng chọn một tên khác.", "Lỗi Trùng Lặp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int type = (cbType.SelectedItem.ToString() == "Admin") ? 1 : 0;

                if (accountBLL.InsertAccount(userName, displayName, type))
                {
                    MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAccountList();
                    SetBinding();
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Thoát chế độ thêm mới
                isAddNewMode = false;
                btnAdd.Text = "Thêm";
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnResetPassword.Enabled = true;
                btnView.Enabled = true;
                dgvAccount.Enabled = true;
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (SessionManager.CurrentAccount == null)
            {
                MessageBox.Show("Không xác định được tài khoản đăng nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                // Kiểm tra xem có tài khoản nào được chọn không
                string userName = txtUserName.Text;
                string displayName = txtDisplayName.Text;

                // Kiểm tra đầu vào
                if (string.IsNullOrWhiteSpace(userName))
                {
                    MessageBox.Show("Vui lòng chọn một tài khoản để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(displayName))
                {
                    MessageBox.Show("Tên hiển thị không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int type = (cbType.SelectedItem.ToString() == "Admin") ? 1 : 0;

                if (accountBLL.UpdateAccount(userName, displayName, type))
                {
                    MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAccountList();
                    SetBinding(); // Quay lại chế độ xem/sửa
                }
                else
                {
                    MessageBox.Show("Cập nhật tài khoản thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SessionManager.CurrentAccount == null)
            {
                MessageBox.Show("Không xác định được tài khoản đăng nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string userName = txtUserName.Text;

                string currentUserName = SessionManager.CurrentAccount?.UserName;

                if (userName == currentUserName)
                {
                    MessageBox.Show("Bạn không thể xóa tài khoản đang đăng nhập!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (accountBLL.DeleteAccount(userName))
                    {
                        MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAccountList();
                        SetBinding(); // Quay lại chế độ xem/sửa
                    }
                    else
                    {
                        MessageBox.Show("Xóa tài khoản thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LoadAccountList();
            SetBinding();
            isAddNewMode = false;
            btnAdd.Text = "Thêm";
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnResetPassword.Enabled = true;
            btnView.Enabled = true;
            dgvAccount.Enabled = true;
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            if (SessionManager.CurrentAccount == null)
            {
                MessageBox.Show("Không xác định được tài khoản đăng nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để đặt lại mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn đặt lại mật khẩu cho tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ResetPassword(userName);
            }
        }
        #endregion
    }
}

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
    public partial class ucClient : UserControl
    {
        private ClientBLL clientBLL = new ClientBLL();
        readonly BindingSource clientList = new BindingSource();
        private bool isAddNewMode = false;

        public ucClient()
        {
            InitializeComponent();
            this.Load += ucClient_Load;
            dgvClient.AllowUserToAddRows = false;
        }

        #region Method
        void SetupDataGridView()
        {
            dgvClient.AutoGenerateColumns = false;
            dgvClient.DataSource = clientList;
            dgvClient.Columns.Clear();
            dgvClient.Columns.Add(new DataGridViewTextBoxColumn { Name = "ID", HeaderText = "Mã KH", DataPropertyName = "ID", Width = 30 });
            dgvClient.Columns.Add(new DataGridViewTextBoxColumn { Name = "ClientName", HeaderText = "Tên Khách Hàng", DataPropertyName = "ClientName", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvClient.Columns.Add(new DataGridViewTextBoxColumn { Name = "ClientEmail", HeaderText = "Email", DataPropertyName = "ClientEmail", Width = 170});
            dgvClient.Columns.Add(new DataGridViewTextBoxColumn { Name = "ClientNumber", HeaderText = "Số Điện Thoại", DataPropertyName = "ClientNumber", Width = 100 });
            dgvClient.Columns.Add(new DataGridViewTextBoxColumn { Name = "BonusPoint", HeaderText = "Điểm Thưởng", DataPropertyName = "BonusPoint", Width = 80 });
            dgvClient.Columns.Add(new DataGridViewTextBoxColumn { Name = "CreatedDay", HeaderText = "Ngày Tạo", DataPropertyName = "CreatedDay", Width = 80 });
        }

        void ClearBinding()
        {
            txtID.DataBindings.Clear();
            txtClientName.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtPhoneNum.DataBindings.Clear();
            txtBonusPoint.DataBindings.Clear();
        }

        void SetBinding()
        {
            ClearBinding();
            txtID.DataBindings.Add(new Binding("Text", clientList, "ID", true, DataSourceUpdateMode.Never));
            txtClientName.DataBindings.Add(new Binding("Text", clientList, "ClientName", true, DataSourceUpdateMode.Never));
            txtEmail.DataBindings.Add(new Binding("Text", clientList, "ClientEmail", true, DataSourceUpdateMode.Never));
            txtPhoneNum.DataBindings.Add(new Binding("Text", clientList, "ClientNumber", true, DataSourceUpdateMode.Never));
            txtBonusPoint.DataBindings.Add(new Binding("Text", clientList, "BonusPoint", true, DataSourceUpdateMode.Never)); 
            isAddNewMode = false;
        }

        void LoadClient()
        {
            clientList.DataSource = clientBLL.GetClientTable();
        }

        void ClearInputs()
        {
            txtID.Text = "";
            txtClientName.Text = "";
            txtEmail.Text = "";
            txtPhoneNum.Text = "";
            txtBonusPoint.Text = "";
        }
        #endregion

        #region Event
        private void ucClient_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadClient();
            SetBinding();
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!isAddNewMode)
            {
                // Chuyển sang chế độ thêm mới
                isAddNewMode = true;
                ClearInputs();
                txtID.ReadOnly = true;
                txtClientName.ReadOnly = false;
                txtEmail.ReadOnly = false;
                txtPhoneNum.ReadOnly = false;
                txtBonusPoint.Enabled = false;
                btnEdit.Enabled = false;
                btnAdd.Text = "Lưu";
                return;
            }

            // Đang ở chế độ thêm mới, thực hiện lưu dữ liệu
            try
            {
                string name = txtClientName.Text.Trim();
                string email = txtEmail.Text.Trim();
                string phoneNumber = txtPhoneNum.Text.Trim();
                int bonusPoint = 0;

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Tên khách hàng không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(phoneNumber))
                {
                    MessageBox.Show("Số điện thoại không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(phoneNumber, out _))
                {
                    MessageBox.Show("Số điện thoại không được bao gồm chữ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!(phoneNumber.StartsWith("0") || phoneNumber.StartsWith("+")))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (int.TryParse(name, out _))
                {
                    MessageBox.Show("Tên khách hàng không được là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var addr = new System.Net.Mail.MailAddress(email);
                if (addr.Address != email)
                {
                    MessageBox.Show("Email không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (clientBLL.InsertClient(name, email, phoneNumber, bonusPoint))
                {
                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadClient();
                    SetBinding();
                    isAddNewMode = false;
                    btnAdd.Text = "Thêm";
                    btnEdit.Enabled = true;
                    if (insertClient != null)
                        insertClient(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtID.Text, out int id))
                {
                    MessageBox.Show("Vui lòng chọn một khách hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Bạn có thật sự muốn xóa khách hàng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (clientBLL.DeleteClient(id))
                    {
                        MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadClient();
                        if (deleteClient != null)
                            deleteClient(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi xóa khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtID.Text, out int id))
                {
                    MessageBox.Show("Vui lòng chọn một khách hàng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string name = txtClientName.Text.Trim();
                string email = txtEmail.Text.Trim();
                string phoneNumber = txtPhoneNum.Text.Trim();
                int bonusPoint = (string.IsNullOrWhiteSpace(txtBonusPoint.Text)) ? 0 : int.Parse(txtBonusPoint.Text.Trim());

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Tên khách hàng không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(phoneNumber))
                {
                    MessageBox.Show("Số điện thoại không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(phoneNumber, out _))
                {
                    MessageBox.Show("Số điện thoại không được bao gồm chữ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!(phoneNumber.StartsWith("0") || phoneNumber.StartsWith("+")))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (int.TryParse(name, out _))
                {
                    MessageBox.Show("Tên khách hàng không được là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtBonusPoint.Text, out _))
                {
                    MessageBox.Show("Điểm thưởng không được là chữ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (bonusPoint < 0)
                {
                    MessageBox.Show("Điểm thưởng không được âm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var addr = new System.Net.Mail.MailAddress(email);
                if (addr.Address != email)
                {
                    MessageBox.Show("Email không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (clientBLL.UpdateClient(id, name, email, phoneNumber, bonusPoint))
                {
                    MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadClient();
                    if (updateClient != null)
                        updateClient(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Có lỗi khi cập nhật khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nếu đang ở chế độ thêm mới, hủy chế độ thêm mới và quay lại chế độ xem/sửa
            if (isAddNewMode)
            {
                isAddNewMode = false;
                SetBinding();
                btnAdd.Text = "Thêm";
                btnEdit.Enabled = true;
            }

            // Nếu click vào dòng hợp lệ thì cập nhật lại trạng thái các control
            if (e.RowIndex >= 0 && e.RowIndex < dgvClient.Rows.Count)
            {
                txtID.ReadOnly = true;
                txtClientName.ReadOnly = false;
                txtEmail.ReadOnly = false;
                txtPhoneNum.ReadOnly = false;
                txtBonusPoint.Enabled = true;
                btnEdit.Enabled = true;
                btnAdd.Enabled = true;
            }
        }

        // Events
        private event EventHandler insertClient;
        public event EventHandler InsertClient
        {
            add { insertClient += value; }
            remove { insertClient -= value; }
        }

        private event EventHandler deleteClient;
        public event EventHandler DeleteClient
        {
            add { deleteClient += value; }
            remove { deleteClient -= value; }
        }

        private event EventHandler updateClient;
        public event EventHandler UpdateClient
        {
            add { updateClient += value; }
            remove { updateClient -= value; }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            DataTable searchResult = clientBLL.GetClientTable().AsEnumerable()
                .Where(row => row.Field<string>("ClientName").IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                              row.Field<string>("ClientEmail").IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                              row.Field<string>("ClientNumber").IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                .CopyToDataTable();
            clientList.DataSource = searchResult;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LoadClient();
        }
    }
}

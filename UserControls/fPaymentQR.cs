using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCaPhe.UserControls
{
    public partial class fPaymentQR: Form
    {
        public bool PaymentConfirmed { get; private set; } = false;
        public fPaymentQR(string tableName, double totalAmount, Image qrImage)
        {
            InitializeComponent();

            lblTable.Text = $"Bàn: {tableName}";
            lblTotal.Text = $"Tổng tiền: {totalAmount:N0} VNĐ";
            pictureBoxQR.Image = qrImage;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            PaymentConfirmed = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

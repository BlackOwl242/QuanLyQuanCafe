using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCaPhe.DAO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Runtime.InteropServices;
using QuanLyQuanCaPhe.BLL;

namespace QuanLyQuanCaPhe.UserControls
{
    public partial class ucRevenue: UserControl
    {
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
        public ucRevenue()
        {
            InitializeComponent();
            LoadDateTimePickerBill();
            LoadListBillByDate(dtpCheckIn.Value, dtpCheckOut.Value);
            LoadSummaryPanelsByDataGridView((DataTable)dgvRevenue.DataSource);
            dgvRevenue.AllowUserToAddRows = false;
        }

        #region Method
        private RevenueBLL revenueBLL = new RevenueBLL();

        // Hàm lấy danh sách hóa đơn theo ngày và hiển thị lên DataGridView
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            var billTable = revenueBLL.GetBillsByDate(checkIn, checkOut);
            dgvRevenue.DataSource = billTable;
            LoadRevenueChart(billTable);
        }

        // Hàm tính toán và hiển thị tổng tiền và số lượng hóa đơn và hiển thị lên các label
        private void LoadSummaryPanelsByDataGridView(DataTable billTable)
        {
            var revenue = revenueBLL.GetRevenueByDate(billTable);
            double totalRevenue = revenue.Sum(x => x.Value);
            double totalMoney = billTable.AsEnumerable()
                .Where(row => row.Field<DateTime?>("Ngày ra") != null)
                .Sum(row => row.Field<double>("Tổng tiền"));
            lblTotalMoney.Text = totalMoney.ToString("N0") + " VNĐ";
            int totalInvoice = billTable.AsEnumerable()
                .Where(row => row.Field<DateTime?>("Ngày ra") != null)
                .Count();
            lblTotalInvoice.Text = totalInvoice.ToString();
        }

        // Hàm hiển thị biểu đồ doanh thu
        void LoadRevenueChart(DataTable billTable)
        {
            chartRevenue.Series.Clear();
            chartRevenue.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea("RevenueArea");
            chartRevenue.ChartAreas.Add(chartArea);

            Series series = new Series("Doanh thu");
            series.ChartType = SeriesChartType.Column;

            var revenueByDate = revenueBLL.GetRevenueByDate(billTable);

            foreach (var item in revenueByDate.OrderBy(x => x.Key))
            {
                series.Points.AddXY(item.Key.ToString("dd/MM/yyyy"), item.Value);
            }

            chartRevenue.Series.Add(series);
        }
        #endregion

        #region Event
        private void btnView_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpCheckIn.Value, dtpCheckOut.Value);
            LoadSummaryPanelsByDataGridView((DataTable)dgvRevenue.DataSource);
        }

        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpCheckIn.Value = new DateTime(today.Year, today.Month, 1);
            dtpCheckOut.Value = dtpCheckIn.Value.AddMonths(1).AddDays(-1); 
        }

        private void ucRevenue_Load(object sender, EventArgs e)
        {
            btnView.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, btnView.Width, btnView.Height, 15, 15));
            pnlBill.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, pnlBill.Width, pnlBill.Height, 30, 30));
            pnlTotalMoney.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, pnlTotalMoney.Width, pnlTotalMoney.Height, 30, 30));

        }
        #endregion
    }
}

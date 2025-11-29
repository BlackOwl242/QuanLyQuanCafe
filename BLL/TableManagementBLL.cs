using System.Collections.Generic;
using QuanLyQuanCaPhe.DTO;
using QuanLyQuanCaPhe.DAO;
using Newtonsoft.Json;
using RestSharp;
using System.IO;
using System;
using System.Drawing;

namespace QuanLyQuanCaPhe.BLL
{
    public class TableManagementBLL
    {
        public List<Category> GetCategories()
        {
            return CategoryDAO.Instance.GetListCategory();
        }

        public List<FoodAndDrinks> GetFoodsByCategory(int categoryId)
        {
            return FoodAndDrinksDAO.Instance.GetFoodByCategoryID(categoryId);
        }

        public List<Table> GetTables()
        {
            return TableDAO.Instance.LoadTableList();
        }

        public List<Menu> GetMenuByTable(int tableId)
        {
            return MenuDAO.Instance.GetListMenuByTable(tableId);
        }

        public int GetUncheckBillIdByTable(int tableId)
        {
            return BillDAO.Instance.GetUncheckBillIDByTableID(tableId);
        }

        public void AddFoodToBill(int billId, int foodId, int count)
        {
            BillInfoDAO.Instance.InsertBillInfo(billId, foodId, count);
        }

        public void CreateBill(int tableId)
        {
            BillDAO.Instance.InsertBill(tableId);
        }

        public int GetMaxBillId()
        {
            return BillDAO.Instance.GetMaxIDBill();
        }

        public void CheckOut(int billId, int discount, double totalPrice)
        {
            BillDAO.Instance.CheckOut(billId, discount, totalPrice);
        }

        public void SwitchTable(int sourceBillId, int targetTableId)
        {
            BillDAO.Instance.SwitchTable(sourceBillId, targetTableId);
        }

        public void MergeTable(int sourceBillId, int targetBillId)
        {
            BillDAO.Instance.MergeTable(sourceBillId, targetBillId);
        }

        public void UpdateTableStatus(int tableId, string status)
        {
            TableDAO.Instance.UpdateTableStatus(tableId, status);
        }

        public (Image qrImage, ApiResponse apiResponse) GenerateQrImage(Table table, double totalPrice)
        {
            var apiRequest = new ApiRequest
            {
                acqId = 970432,
                accountNo = 263696255,
                accountName = "LE QUOC HUY",
                amount = (int)totalPrice,
                addInfo = $"{table.Name} {DateTime.Now:yyyyMMddHHmmss}",
                format = "text",
                template = "qr_only"
            };
            var jsonRequest = JsonConvert.SerializeObject(apiRequest);
            var client = new RestClient("https://api.vietqr.io/v2/generate");
            var request = new RestRequest();
            request.Method = Method.Post;
            request.AddHeader("Accept", "application/json");
            request.AddParameter("application/json", jsonRequest, ParameterType.RequestBody);
            var response = client.Execute(request);
            var content = response.Content;
            var dataResult = JsonConvert.DeserializeObject<ApiResponse>(content);

            Image image = null;
            if (dataResult != null && dataResult.data != null && !string.IsNullOrEmpty(dataResult.data.qrDataURL))
            {
                string base64 = dataResult.data.qrDataURL.Replace("data:image/png;base64,", "");
                try
                {
                    image = Base64ToImage(base64);
                }
                catch (Exception ex)
                {
                    // Log hoặc thông báo lỗi chuyển đổi base64
                    System.Windows.Forms.MessageBox.Show("Lỗi chuyển đổi QR base64: " + ex.Message);
                }
            }
            else
            {
                // Log hoặc thông báo lỗi lấy dữ liệu QR từ API
                System.Windows.Forms.MessageBox.Show("Không lấy được dữ liệu QR từ API.");
            }

            return (image, dataResult);
        }

        private Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                return Image.FromStream(ms, true);
            }
        }
    }
}

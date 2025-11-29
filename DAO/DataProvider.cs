using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanCaPhe.UserControls;
using System.Text.RegularExpressions;

namespace QuanLyQuanCaPhe.DAO
{
    class DataProvider
    {
        private static DataProvider instance;

        // Design pattern Singleton để đảm bảo chỉ có một thể hiện của DataProvider.
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set { instance = value; }
        }

        private DataProvider() { }

        // Chuỗi kết nối đến cơ sở dữ liệu.
        private string connString = Properties.Settings.Default.ConnectionString;

        // Thực thi một câu lệnh SQL và trả về một DataTable chứa kết quả truy vấn.
        public DataTable ExecuteQuery(string query, object[] parameter = null) 
        {
            DataTable data = new DataTable();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                // Tạo SqlCommand với câu lệnh SQL và kết nối
                SqlCommand sqlCommand = new SqlCommand(query, conn);

                if (parameter != null)
                {
                    var matches = Regex.Matches(query, @"@\w+"); // Tìm tất cả các tham số trong câu lệnh SQL
                    var paramNames = matches.Cast<Match>().Select(m => m.Value).Distinct().ToList(); // Lấy danh sách tên tham số
                    // Thêm các tham số vào SqlCommand
                    for (int i = 0; i < paramNames.Count && i < parameter.Length; i++)
                    {
                        sqlCommand.Parameters.AddWithValue(paramNames[i], parameter[i]); // Thêm tham số vào SqlCommand
                    }
                }
                // Tạo SqlDataAdapter để thực thi câu lệnh SQL và điền dữ liệu vào DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
         
                adapter.Fill(data);
                // Đóng kết nối
                conn.Close();
            }
            return data;
        }

        // Thực hiện một câu lệnh SQL không trả về dữ liệu (INSERT, UPDATE, DELETE) và trả về số lượng dòng bị ảnh hưởng.
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                SqlCommand sqlCommand = new SqlCommand(query, conn);

                if (parameter != null)
                {
                    var matches = Regex.Matches(query, @"@\w+"); // Tìm tất cả các tham số trong câu lệnh SQL
                    var paramNames = matches.Cast<Match>().Select(m => m.Value).Distinct().ToList();

                    for (int i = 0; i < paramNames.Count && i < parameter.Length; i++)
                    {
                        sqlCommand.Parameters.AddWithValue(paramNames[i], parameter[i]);
                    }
                }

                data = sqlCommand.ExecuteNonQuery();
                conn.Close();
            }
            return data;
        }

        // Thực hiện một câu lệnh SQL trả về một giá trị duy nhất (ví dụ: COUNT, MAX) và trả về giá trị đó.
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                SqlCommand sqlCommand = new SqlCommand(query, conn);

                if (parameter != null)
                {
                    var matches = Regex.Matches(query, @"@\w+");
                    var paramNames = matches.Cast<Match>().Select(m => m.Value).Distinct().ToList();

                    for (int i = 0; i < paramNames.Count && i < parameter.Length; i++)
                    {
                        sqlCommand.Parameters.AddWithValue(paramNames[i], parameter[i]);
                    }
                }

                data = sqlCommand.ExecuteScalar();
                conn.Close();
            }
            return data;
        }
    }
}

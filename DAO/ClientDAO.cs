using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanCaPhe.DTO;

namespace QuanLyQuanCaPhe.DAO
{
    public class ClientDAO
    {
        private static ClientDAO instance;

        public static ClientDAO Instance
        {
            get { if (instance == null) instance = new ClientDAO(); return ClientDAO.instance; }
            private set { ClientDAO.instance = value; }
        }

        private ClientDAO() { }

        public List<Client> GetListClient()
        {
            List<Client> list = new List<Client>();
            string query = "SELECT * FROM dbo.Client";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Client client = new Client(item);
                list.Add(client);
            }
            return list;
        }

        public DataTable GetClientTable()
        {
            string query = @"
            SELECT 
                id AS ID,
                ClientName AS ClientName,
                ClientEmail AS ClientEmail,
                ClientNumber AS ClientNumber,
                BonusPoint AS BonusPoint,
                CreatedDay AS CreatedDay
            FROM dbo.Client";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool InsertClient(string name, string email, string phoneNumber, int bonusPoint = 0)
        {
            string query = "INSERT dbo.Client (ClientName, ClientEmail, ClientNumber, BonusPoint) VALUES ( @name , @email , @phoneNumber , @bonusPoint )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, email, phoneNumber, bonusPoint });
            return result > 0;
        }

        public bool UpdateClient(int id, string name, string email, string phoneNumber, int bonusPoint)
        {
            string query = "UPDATE dbo.Client SET ClientName = @name , ClientEmail = @email , ClientNumber = @phoneNumber , BonusPoint = @bonusPoint WHERE id = @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, email, phoneNumber, bonusPoint, id });
            return result > 0;
        }

        public bool DeleteClient(int id)
        {
            string query = "DELETE dbo.Client WHERE id = @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result > 0;
        }

        public bool UpdateBonusPoint(int id, int bonusPoint)
        {
            string query = "UPDATE dbo.Client SET BonusPoint = @bonusPoint WHERE id = @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { bonusPoint, id });
            return result > 0;
        }

        //hàm tìm kiếm khách hàng theo tên hoặc số điện thoại
        public List<Client> SearchClients(string keyword)
        {
            List<Client> list = new List<Client>();
            string query = "SELECT * FROM dbo.Client WHERE ClientName LIKE @keyword OR ClientNumber LIKE @keyword";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { "%" + keyword + "%" });
            foreach (DataRow item in data.Rows)
            {
                Client client = new Client(item);
                list.Add(client);
            }
            return list;
        }
    }
}

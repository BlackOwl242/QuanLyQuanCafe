using QuanLyQuanCaPhe.DAO;
using QuanLyQuanCaPhe.DTO;
using System.Collections.Generic;
using System.Data;

namespace QuanLyQuanCaPhe.BLL
{
    public class ClientBLL
    {
        public List<Client> GetListClient()
        {
            return ClientDAO.Instance.GetListClient();
        }

        public DataTable GetClientTable()
        {
            return ClientDAO.Instance.GetClientTable();
        }

        public bool InsertClient(string name, string email, string phoneNumber, int bonusPoint = 0)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phoneNumber))
            {
                return false;
            }
            if (bonusPoint < 0)
            {
                bonusPoint = 0;
            }
            return ClientDAO.Instance.InsertClient(name, email, phoneNumber, bonusPoint);
        }

        public bool UpdateClient(int id, string name, string email, string phoneNumber, int bonusPoint)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phoneNumber))
            {
                return false;
            }
            if (bonusPoint < 0)
            {
                bonusPoint = 0;
            }
            return ClientDAO.Instance.UpdateClient(id, name, email, phoneNumber, bonusPoint);
        }

        public bool DeleteClient(int id)
        {
            return ClientDAO.Instance.DeleteClient(id);
        }

        public bool UpdateBonusPoint(int id, int bonusPoint)
        {
            if (bonusPoint < 0)
            {
                bonusPoint = 0;
            }
            return ClientDAO.Instance.UpdateBonusPoint(id, bonusPoint);
        }

        public bool AddBonusPoint(int id, int additionalPoints)
        {
            var client = GetListClient().Find(c => c.ID == id);
            if (client != null)
            {
                int newBonusPoint = client.BonusPoint + additionalPoints;
                // Đảm bảo điểm thưởng không bao giờ xuống dưới 0
                if (newBonusPoint < 0)
                {
                    newBonusPoint = 0;
                }
                return UpdateBonusPoint(id, newBonusPoint);
            }
            return false;
        }

        public bool GetClientByPhoneNumber(string phoneNumber, out Client client)
        {
            client = null;
            var clients = GetListClient();
            foreach (var c in clients)
            {
                if (c.PhoneNumber == phoneNumber)
                {
                    client = c;
                    return true;
                }
            }
            return false;
        }

        public int CalculateBonusPointsByAmount(double totalAmount)
        {
            if (totalAmount <= 50000)
            {
                return 1; // <= 50,000 VND = 1 điểm
            }
            else if (totalAmount <= 100000)
            {
                return 2; // <= 100,000 VND = 2 điểm
            }
            else if (totalAmount < 300000)
            {
                return 5; // < 300,000 VND = 5 điểm
            }
            else if (totalAmount < 500000)
            {
                return 10; // < 500,000 VND = 10 điểm
            }
            else
            {
                return 20; // >= 500,000 VND = 20 điểm
            }
        }
    }
}

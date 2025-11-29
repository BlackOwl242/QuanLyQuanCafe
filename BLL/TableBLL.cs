using QuanLyQuanCaPhe.DAO;
using QuanLyQuanCaPhe.DTO;
using System.Collections.Generic;

namespace QuanLyQuanCaPhe.BLL
{
    public class TableBLL
    {
        public List<Table> LoadTableList()
        {
            return TableDAO.Instance.LoadTableList();
        }

        public void UpdateTableStatus(int tableId, string status)
        {
            TableDAO.Instance.UpdateTableStatus(tableId, status);
        }

        public bool InsertTable(string name, string status)
        {
            return TableDAO.Instance.InsertTable(name, status);
        }

        public bool UpdateTable(int id, string name, string status)
        {
            return TableDAO.Instance.UpdateTable(id, name, status);
        }

        public bool DeleteTable(int id)
        {
            return TableDAO.Instance.DeleteTable(id);
        }
    }
}

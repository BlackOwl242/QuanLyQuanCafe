using QuanLyQuanCaPhe.DAO;
using QuanLyQuanCaPhe.DTO;
using System.Collections.Generic;

namespace QuanLyQuanCaPhe.BLL
{
    public class CategoryBLL
    {
        public List<Category> GetListCategory()
        {
            return CategoryDAO.Instance.GetListCategory();
        }

        public bool InsertCategory(string name)
        {
            return CategoryDAO.Instance.InsertCategory(name);
        }

        public bool UpdateCategory(int id, string name)
        {
            return CategoryDAO.Instance.UpdateCategory(id, name);
        }

        public bool DeleteCategory(int id)
        {
            return CategoryDAO.Instance.DeleteCategory(id);
        }
    }
}

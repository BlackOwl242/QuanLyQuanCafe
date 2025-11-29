using QuanLyQuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return instance; }
            private set { instance = value; }
        }

        private CategoryDAO() { }
        
        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetCategory");
            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }
            return list;
        }
        public bool InsertCategory(string name)
        {
            string query = "INSERT dbo.Category ( name ) VALUES ( @name )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name });
            return result > 0;
        }
        public bool UpdateCategory(int id, string name)
        {
            string query = "UPDATE dbo.Category SET name = @name WHERE id = @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, id });
            return result > 0;
        }

        public bool DeleteCategory(int id)
        {
            string query = "DELETE dbo.Category WHERE id = @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result > 0;
        }
    }
}

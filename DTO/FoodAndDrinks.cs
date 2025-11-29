using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.DTO
{
    public class FoodAndDrinks
    {
        public string ImagePath { get; set; }
        public FoodAndDrinks(int id, string name, int categoryID, float price, string imagePath = null)
        {
            this.ID = id;
            this.Name = name;
            this.CategoryID = categoryID;
            this.Price = price;
            this.ImagePath = imagePath;
        }

        public FoodAndDrinks(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.CategoryID = (int)row["idcategory"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            if (row.Table.Columns.Contains("ImagePath") && row["ImagePath"] != DBNull.Value)
            {
                this.ImagePath = row["ImagePath"].ToString();
            }
            else
            {
                this.ImagePath = null;
            }
        }

        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        private int categoryID;
        public int CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}

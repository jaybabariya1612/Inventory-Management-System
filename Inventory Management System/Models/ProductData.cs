using School_Management_System.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Models
{
    internal class ProductData
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public string CategoryName { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string SupplierName { get; set; }
        public string ImagePath { get; set; }

        public List<ProductData> ProductListData()
        {
            List<ProductData> listdata = new List<ProductData>();
            using (SqlConnection conn = DatabaseService.GetConnection())
            {
                conn.Open();
                string selectdata = "SELECT ProductID, Name, CategoryName, Quantity, Price, Description, SupplierName, ImagePath  FROM imss_products";
                using (SqlCommand cmd = new SqlCommand(selectdata, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ProductData Pdata = new ProductData();
                        Pdata.ProductID = Convert.ToInt32(reader["ProductID"]);
                        Pdata.ProductName = Convert.ToString(reader["Name"]);
                        Pdata.CategoryName = Convert.ToString(reader["CategoryName"]);
                        Pdata.Quantity = Convert.ToInt32(reader["Quantity"]);
                        Pdata.Price = Convert.ToDecimal(reader["Price"]);
                        Pdata.Description = Convert.ToString(reader["Description"]);
                        Pdata.SupplierName = Convert.ToString(reader["SupplierName"]);
                        Pdata.ImagePath = Convert.ToString(reader["ImagePath"]);
                        listdata.Add(Pdata);

                    }
                }
            }
            return listdata;
        }
    }
}

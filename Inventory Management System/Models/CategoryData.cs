using School_Management_System.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Models
{
    internal class CategoryData
    {
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public string QRCode { get; set; }


        public List<CategoryData> CategoryListData()
        {
            List<CategoryData> listdata = new List<CategoryData>();
            using (SqlConnection conn = DatabaseService.GetConnection())
            {
                conn.Open();
                string selectdata = "SELECT CategoryID,CategoryName,QRCode FROM Category";
                using (SqlCommand cmd = new SqlCommand(selectdata, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        CategoryData Cdata = new CategoryData();
                        Cdata.CategoryID = Convert.ToInt32(reader["CategoryID"]);
                        Cdata.CategoryName = Convert.ToString(reader["CategoryName"]);
                        Cdata.QRCode = Convert.ToString(reader["QRCode"]);
                        listdata.Add(Cdata);

                    }
                }
            }
            return listdata;
        }

    }
}

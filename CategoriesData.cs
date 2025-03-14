using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;

namespace InventoryManagement
{
    internal class CategoriesData
    {
        public int ID { set; get; }
        public string Category { set; get; }

        public string Date {  set; get; }

        public List<CategoriesData> AllCategoriesData()
        {
            List<CategoriesData> listData = new List<CategoriesData>();

            using Microsoft.Data.SqlClient.SqlConnection connect 
                = new Microsoft.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Samantha\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
            {
                connect.Open();

                string selectData = "SELECT * FROM category";

                using (Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand(selectData, connect)) 
                {
                    Microsoft.Data.SqlClient.SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read()) 
                    {
                        CategoriesData cData = new CategoriesData();
                        cData.ID = (int)reader["id"];
                        cData.Category = reader["category"].ToString();
                        cData.Date = reader["date"].ToString();

                        listData.Add(cData);
                    }
                }
            }

            return listData;
        }
    }
}

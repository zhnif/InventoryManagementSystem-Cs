using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    internal class ProductsData
    {
        public int ID { set; get; } // 
        public string ProdID { set; get; }// 1 
        public string ProdName { set; get; }// 2
        public string Category { set; get; } // 3
        public string Price { set; get; }// 4
        public string Stock { set; get; }// 5
        public string ImagePath { set; get; }// 6
        public string Status { set; get; }// 7 
        public string Date { set; get; }// 8
        public List<ProductsData> AllProductsData()
        {
            List<ProductsData> listData = new List<ProductsData>();

            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hp\Documents\inventoryDB.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connect.Open();
                string selectData = "SELECT * FROM products";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ProductsData apData = new ProductsData();
                        apData.ID = (int)reader["id"];
                        apData.ProdID = reader["prod_id"].ToString();
                        apData.ProdName = reader["prod_name"].ToString();
                        apData.Category = reader["category"].ToString();
                        apData.Price = reader["price"].ToString();
                        apData.Stock = reader["stock"].ToString();
                        apData.ImagePath = reader["image_path"].ToString();
                        apData.Status = reader["status"].ToString();
                        apData.Date = reader["date_insert"].ToString();

                        listData.Add(apData);
                    }
                }
            }
            return listData;
        }

        public List<ProductsData> allAvailableProducts()
        {
            List<ProductsData> listData = new List<ProductsData>();

            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hp\Documents\inventoryDB.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connect.Open();
                string selectData = "SELECT * FROM products WHERE status = @status";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@status", "Available");
                    
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ProductsData apData = new ProductsData();
                        apData.ID = (int)reader["id"];
                        apData.ProdID = reader["prod_id"].ToString();
                        apData.ProdName = reader["prod_name"].ToString();
                        apData.Category = reader["category"].ToString();
                        apData.Price = reader["price"].ToString();
                        apData.Stock = reader["stock"].ToString();
                        apData.Status = reader["status"].ToString();
                        apData.ImagePath = reader["image_path"].ToString();
                        apData.Date = reader["date_insert"].ToString();

                        listData.Add(apData);
                    }
                }
            }
            return listData;
        }
    }
}

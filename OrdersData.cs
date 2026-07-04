using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;

namespace InventoryManagementSystem
{
    internal class OrdersData
    {
        SqlConnection
            connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hp\Documents\inventoryDB.mdf;Integrated Security=True;Connect Timeout=30");

        public string CID;
        public string PID;
        public string PName;
        public string Category;
        public string OrigPrice;
        public string QTY;
        public string TotalPrice;
        public string Date;

        public List<OrdersData> allOrdersData()
        {
            List<OrdersData> listData = new List<OrdersData>();
            
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                }
                catch(Exception ex)
                {

                }
                finally
                {
                    connect.Close();
                }
            }
        }
    }
}

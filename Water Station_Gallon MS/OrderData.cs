using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Water_Station_Gallon_MS
{
    internal class OrderData
    {
        SqlConnection connect =
            new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\danpi\OneDrive\Documents\newinventory.mdf;Integrated Security=True;Connect Timeout=30");

       public int ID { get; set; }
        public string CID { set; get; }
        public string PID { set; get; }
        
        public string Category { set; get; }
        public string OrigPrice { set; get; }
        public string QTY { set; get; }
        public string TotalPrice { set; get; }
        

        public List<OrderData> allOrderData()
        {
            List<OrderData> listData = new List<OrderData>();

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    int custID = 0;
                    string selectCustData = "SELECT MAX(customer_id) FROM orders";

                    using (SqlCommand cmd = new SqlCommand(selectCustData, connect))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            int temp = Convert.ToInt32(result);

                            if (temp == 0)
                            {
                                custID = 0;
                            }
                            else
                            {
                                custID = temp;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error ID");
                        }
                    }

                    string selectData = "SELECT * FROM orders WHERE customer_id = @cID";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cID", custID);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            OrderData oData = new OrderData();

                            oData.ID = (int)reader["id"];
                            oData.CID = reader["customer_id"].ToString();
                            oData.PID = reader["prod_id"].ToString();
                            
                            oData.Category = reader["category"].ToString();
                            oData.OrigPrice = reader["orig_price"].ToString();
                            oData.QTY = reader["qty"].ToString();
                            oData.TotalPrice = reader["total_price"].ToString();
                            


                            listData.Add(oData);
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Connection Failed" + ex);
                }
                finally
                {
                    connect.Close();
                }
            }

            return listData;

        }

    }
}

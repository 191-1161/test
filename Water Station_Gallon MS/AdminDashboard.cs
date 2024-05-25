using LiveCharts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Water_Station_Gallon_MS
{
    public partial class AdminDashboard : UserControl
    {
        SqlConnection connect =
            new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\danpi\OneDrive\Documents\newinventory.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminDashboard()
        {
            InitializeComponent();
            displayTodayCustomers();
            displayAllUsers();
            displayAllCustomers();
            displayTodaysIncome();
            displayTotalIncome();
        }

        Func<ChartPoint, string> label = chartpoint => string.Format("{0} ({1:P)", chartpoint.Y, chartpoint.Participation);

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayAllUsers();
            displayAllCustomers();
            displayTodaysIncome();
            displayTotalIncome();
        }

       
        public void displayTodayCustomers()
        {
            CustomersData cData = new CustomersData();

            List<CustomersData> listData = cData.allTodayCustomers();

            DataGridView1.DataSource = listData;
        }

        public bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void displayAllUsers()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = " SELECT COUNT(id) FROM usersss WHERE status = @status";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Active");

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_AU.Text = count.ToString();
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }

        }
        public void displayAllCustomers()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = " SELECT COUNT(id) FROM customers";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {


                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_AC.Text = count.ToString();
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }

        }
        public void displayTodaysIncome()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = " SELECT SUM(total_price) FROM customers WHERE order_date = @date";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {

                        DateTime today = DateTime.Today;
                        string getToday = today.ToString("yyyy-MM-dd");

                        cmd.Parameters.AddWithValue("@date", today);


                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            object value = reader[0];

                            if (value != DBNull.Value)
                            {
                                int count = Convert.ToInt32(reader[0]);
                                dashboard_TI.Text = "₱" + count.ToString("0.00");
                            }
                            reader.Close();

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }
        public void displayTotalIncome()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = " SELECT SUM(total_price) FROM customers";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {


                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {



                            int count = Convert.ToInt32(reader[0]);
                            dashboard_totalincome.Text = "₱" + count.ToString("0.00");

                        }
                        reader.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      
    }

}




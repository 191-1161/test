using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Water_Station_Gallon_MS
{
    public partial class AddminAddProducts : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\danpi\OneDrive\Documents\newinventory.mdf;Integrated Security=True;Connect Timeout=30");
        public AddminAddProducts()
        {
            InitializeComponent();

            displayCategories();

            displayAllProducts();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayCategories();

            displayAllProducts();
        }

        public void displayAllProducts()
        {
            AddProductsData apData = new AddProductsData();
            List<AddProductsData> listData = apData.AllProductsData();

            dataGridView1.DataSource = listData;
        }
        public bool emptyfields()
        {
            if (AddProducts_prodID.Text == "" || AddProducts_prodName.Text == "" || AddProducts_category.SelectedIndex == -1
                || AddProducts_price.Text == "" || AddProducts_stock.Text == "" || AddProducts_status.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void displayCategories()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM categories";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                AddProducts_category.Items.Add(reader["category"].ToString());
                            }
                        }

                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void addProducts_addBtn_Click(object sender, EventArgs e)
        {
            if (emptyfields())
            {
                MessageBox.Show("Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();
                        string selectData = " SELECT * FROM productss WHERE prod_id = @prodID";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@prodID", AddProducts_prodID.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show("Product ID:" + AddProducts_prodID.Text.ToString() + "is existing already"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO productss" +
                                    "(prod_id, prod_name, category, price, stock,status, date_insert)" +
                                    "VALUES(@prodID, @prodName, @cat, @price, @stock, @status, @date)";

                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@prodID", AddProducts_prodID.Text.Trim());
                                    insertD.Parameters.AddWithValue("@prodName", AddProducts_prodName.Text.Trim());
                                    insertD.Parameters.AddWithValue("@cat", AddProducts_category.SelectedItem);
                                    insertD.Parameters.AddWithValue("@price", AddProducts_price.Text.Trim());
                                    insertD.Parameters.AddWithValue("@stock", AddProducts_stock.Text.Trim());
                                    insertD.Parameters.AddWithValue("@status", AddProducts_status.SelectedItem);

                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@date", today);

                                    insertD.ExecuteNonQuery();
                                    clearfields();
                                    displayAllProducts();

                                    MessageBox.Show("Added Succesfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed connection" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }

        }

        public bool checkConnection()
        {
            if (connect.State != ConnectionState.Open)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void clearfields()
        {
            AddProducts_prodID.Text = "";
            AddProducts_prodName.Text = "";
            AddProducts_category.SelectedIndex = -1;
            AddProducts_price.Text = "";
            AddProducts_stock.Text = "";
            AddProducts_status.SelectedIndex = -1;

        }
        private void addProducts_clearBtn_Click(object sender, EventArgs e)
        {
            clearfields();
        }

        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;

                AddProducts_prodID.Text = row.Cells[1].Value.ToString();
                AddProducts_prodName.Text = row.Cells[2].Value.ToString();
                AddProducts_category.Text = row.Cells[3].Value.ToString();
                AddProducts_price.Text = row.Cells[4].Value.ToString();
                AddProducts_stock.Text = row.Cells[5].Value.ToString();
                AddProducts_status.Text = row.Cells[6].Value.ToString();
            }
        }

        private void addProducts_updateBtn_Click(object sender, EventArgs e)
        {
            if (emptyfields())
            {
                MessageBox.Show("Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Update Product ID:"
                    + AddProducts_prodID.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string updateData = "UPDATE productss SET prod_ID = @prodID, prod_name = @prodName" +
                                ",category = @cat, price = @price, stock = @stock, status= @status WHERE id = @id";

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@prodID", AddProducts_prodID.Text.Trim());
                                updateD.Parameters.AddWithValue("@prodName", AddProducts_prodName.Text.Trim());
                                updateD.Parameters.AddWithValue("@cat", AddProducts_category.SelectedItem);
                                updateD.Parameters.AddWithValue("@price", AddProducts_price.Text.Trim());
                                updateD.Parameters.AddWithValue("@stock", AddProducts_stock.Text.Trim());
                                updateD.Parameters.AddWithValue("@status", AddProducts_status.SelectedItem);
                                updateD.Parameters.AddWithValue("@id", getID);


                                updateD.ExecuteNonQuery();
                                clearfields();
                                displayAllProducts();

                                MessageBox.Show("Updated Succesfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed connection" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }

            }
        }

        private void addProducts_removeBtn_Click(object sender, EventArgs e)
        {
            if (emptyfields())
            {
                MessageBox.Show("Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Delete Product ID:"
                    + AddProducts_prodID.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string deleteData = "DELETE FROM productss WHERE id =@id";

                            using (SqlCommand deleteD = new SqlCommand(deleteData, connect))
                            {

                                deleteD.Parameters.AddWithValue("@id", getID);


                                deleteD.ExecuteNonQuery();
                                clearfields();
                                displayAllProducts();

                                MessageBox.Show("Deleted Succesfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed connection" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }

            }
        }
    }

}

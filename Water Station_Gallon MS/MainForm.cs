using System;
using System.Windows.Forms;

namespace Water_Station_Gallon_MS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            
        }
            
       

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation Message"
             , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Confirmation Message"
              , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void adminAddUsers1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = true;
            adminAddUsers1.Visible = false;
            adminAddCategories1.Visible = false;
            addminAddProducts1.Visible = false;
            cashierCustomers1.Visible = false;

            AdminDashboard adForm = adminDashboard1 as AdminDashboard;
            if (adForm != null)
            {
                adForm.refreshData();
            }
        }

        private void addUser_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddUsers1.Visible = true;
            adminAddCategories1.Visible = false;
            addminAddProducts1.Visible = false;
            cashierCustomers1.Visible = false;

            AdminAddUsers aauForm = adminAddUsers1 as AdminAddUsers;
            if (aauForm != null)
            {
                aauForm.refreshData();
            }
        }

        private void addCategories_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddUsers1.Visible = false;
            adminAddCategories1.Visible = true;
            addminAddProducts1.Visible = false;
            cashierCustomers1.Visible = false;

            AdminAddCategories aacForm = adminAddCategories1 as AdminAddCategories;
            if (aacForm != null)
            {
                aacForm.refreshData();
            }
        }

        private void addProducts_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddUsers1.Visible = false;
            adminAddCategories1.Visible = false;
            addminAddProducts1.Visible = true;
            cashierCustomers1.Visible = false;

            AddminAddProducts aapForm = addminAddProducts1 as AddminAddProducts;
            if (aapForm != null)
            {
                aapForm.refreshData();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customers_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddUsers1.Visible = false;
            adminAddCategories1.Visible = false;
            addminAddProducts1.Visible = false;
            cashierCustomers1.Visible = true;

            CashierCustomers ccForm = cashierCustomers1 as CashierCustomers;

            if (ccForm != null)
            {
                ccForm.refreshData();
            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace Water_Station_Gallon_MS
{
    public partial class CashierMainForm : Form
    {
        public CashierMainForm()
        {
            InitializeComponent();

            
        }


        private void label4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?",
              "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void logout_Btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?",
                "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = true;
            addminAddProducts1.Visible = false;
            cashierCustomers1.Visible = false;
            cashierOrder1.Visible = false;


            AdminDashboard adForm = adminDashboard1 as AdminDashboard;

            if (adForm != null)
            {
                adForm.refreshData();
            }
        }

        private void addProduct_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            addminAddProducts1.Visible = true;
            cashierCustomers1.Visible = false;
            cashierOrder1.Visible = false;


            AddminAddProducts aapForm = addminAddProducts1 as AddminAddProducts;

            if (aapForm != null)
            {
                aapForm.refreshData();
            }
        }

        private void customer_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            addminAddProducts1.Visible = false;
            cashierCustomers1.Visible = true;
            cashierOrder1.Visible = false;

            CashierCustomers ccForm = cashierCustomers1 as CashierCustomers;

            if (ccForm != null)
            {
                ccForm.refreshData();
            }
        }

        private void order_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            addminAddProducts1.Visible = false;
            cashierCustomers1.Visible = false;
            cashierOrder1.Visible = true;

            CashierOrder coForm = cashierOrder1 as CashierOrder;

            if (coForm != null)
            {
                coForm.refreshData();
            }
        }
    }
}

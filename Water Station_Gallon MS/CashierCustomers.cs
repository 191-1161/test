using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Water_Station_Gallon_MS
{
    public partial class CashierCustomers : UserControl
    {
        public CashierCustomers()
        {
            InitializeComponent();

            displayCustomers();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayCustomers();
        }
        public void displayCustomers()
        {
            CustomersData cData = new CustomersData();

            List<CustomersData> listData =  cData.allCustomers();

            DataGridView1.DataSource = listData;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

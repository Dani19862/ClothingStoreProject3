using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class CustomersAndOrdersScreen : Form
    {
        public CustomersAndOrdersScreen()
        {
            InitializeComponent();
        }

        // Go to customers screen
        private void CusromersClickButton_Click(object sender, EventArgs e)
        {

            var frm = new CustomersListScreen();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();

        }

        // Go to orders Screen
        private void OrdersClickButtton_Click(object sender, EventArgs e)
        {
            var frm = new OrdersListScreen();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        // Go to Product Screen
        private void Products_btn_Click(object sender, EventArgs e)
        {
            
            var frm = new ProductsScreen();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
    }
}

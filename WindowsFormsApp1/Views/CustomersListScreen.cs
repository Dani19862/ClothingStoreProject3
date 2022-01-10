using Services;
using System;
using System.Windows.Forms;
using WindowsFormsApp1.DataAccssesLayer;

namespace WindowsFormsApp1.Views
{
    public partial class CustomersListScreen : Form
    {
        readonly Customers customer = new Customers();
        readonly Users user = new Users();
        readonly ClothingStoreDB db = new ClothingStoreDB();
        readonly CustomerRepositorySingelton cr;

        public CustomersListScreen()
        {
            InitializeComponent();
            cr = CustomerRepositorySingelton.GetSingelton();
        }

        private void EditCustomer_Button_Click_Click(object sender, EventArgs e)
        {
            var frm = new EditCustomersScreen();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.customersTableAdapter.FillBy(this.clothingStoreDBDataSet2.Customers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // To Show all Customers Records
        private void Show_All_Customer_Button_Click(object sender, EventArgs e)
        {
            customersDataGridView.DataSource = cr.GetAllCustomersAsync();
        }
      
        // To Clear all TextsBox
        public void Clear()
        {
            customerIDTextBox.Text = firstNameTextBox.Text = lastNameTextBox.Text
                = cityTextBox.Text = phoneNumberTextBox.Text = no_HouseTextBox.Text = addressTextBox.Text = postalCodeTextBox.Text = orderIDTextBox.Text = "";

        }
        private void Clera_Button_Click_Click(object sender, EventArgs e)
        {
            Clear();

        }

        // Delete Button 

        private void DeleteCustomer_Button_Click(object sender, EventArgs e)
        {
            var frm = new DeleteCustomerScreen();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
            Clear();
        }

       
        private void Exit_btn_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Logout?", "", MessageBoxButtons.YesNo);



            if (dialogResult == DialogResult.Yes)
            {
                var frm = new LoginScreen();
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                frm.FormClosing += delegate { this.Show(); };
                frm.Show();
                this.Hide();

            }
            
        }

        private void Products_btn_Click(object sender, EventArgs e)
        {
            var frm = new ProductsScreen();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        
        private void Orders_btn_Click(object sender, EventArgs e)
        {
            var frm = new OrdersListScreen();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
    }
}

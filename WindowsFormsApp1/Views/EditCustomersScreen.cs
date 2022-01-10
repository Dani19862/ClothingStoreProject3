using Services;
using System;
using System.Windows.Forms;
using WindowsFormsApp1.DataAccssesLayer;

namespace WindowsFormsApp1.Views
{
    public partial class EditCustomersScreen : Form
    {
        readonly CustomerRepositorySingelton cr;
        readonly ClothingStoreDB db = new ClothingStoreDB();
        public EditCustomersScreen()
        {
            InitializeComponent();
            cr = CustomerRepositorySingelton.GetSingelton();
        }

        private void CustomersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cusrtomersAndOrders);

        }

        private void EditCustomersScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cusrtomersAndOrders.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.cusrtomersAndOrders.Customers);

        }

        //Edit button
        private async void Edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                await cr.EditCustomerAsync(Convert.ToInt32(customerIDTextBox.Text),
                firstNameTextBox.Text,
                lastNameTextBox.Text,
                addressTextBox.Text,
                cityTextBox.Text,
                Convert.ToInt32(no_HouseTextBox.Text),
                Convert.ToInt32(postalCodeTextBox.Text),
                phoneNumberTextBox.Text, Convert.ToInt32(orderIDTextBox.Text));
                MessageBox.Show("Edit record Successfully");

            }
            catch (Exception)
            {
                MessageBox.Show("Record canot be Edit\n" +
                    "Try again");
            }
            
            
        }
        // pass to login screen
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

        // pass to customers screen
        private void Customers_btn_Click(object sender, EventArgs e)
        {
            var frm = new CustomersListScreen();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
    }
}

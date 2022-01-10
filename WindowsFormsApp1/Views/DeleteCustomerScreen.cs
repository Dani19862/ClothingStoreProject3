using Model;
using Models;
using Services;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class DeleteCustomerScreen : Form
    {
        readonly User user = new User();
        readonly CustomerRepositorySingelton cr;
        readonly CustomersListScreen cls = new CustomersListScreen();
        
        public DeleteCustomerScreen()
        {
            InitializeComponent();
            cr = CustomerRepositorySingelton.GetSingelton();
        }

        private void CustomersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clothingStoreDBDataSet2);

        }

        private void DeleteCusromerScreen_Load(object sender, EventArgs e)
        {
            this.customersTableAdapter2.Fill(this.customerAndOrers.Customers);

        }

        // delete record only if user director
        private void Delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Delete This Record?", "Record Deleted", MessageBoxButtons.YesNo);

            if (UserDetails.UserType == User.EnumUserType.Director)
            {
                if (dialogResult == DialogResult.Yes && user.UserType == User.EnumUserType.Director)
                {
                    customersDataGridView.DataSource = cr.DeleteCustomerAsync(Convert.ToInt32(customerIDTextBox.Text), firstNameTextBox.Text, lastNameTextBox.Text,
                        addressTextBox.Text, cityTextBox.Text, Convert.ToInt32(no_HouseTextBox.Text), Convert.ToInt32(postalCodeTextBox.Text), phoneNumberTextBox.Text);
                    MessageBox.Show("Deleted Sucessfully");
                    customersDataGridView.DataSource = cr.GetAllCustomersAsync();

                }
                else
                {
                    MessageBox.Show("You Canot Delete Records \n" +
                        "Only Director Can Delete Records");

                }
            }

            cls.Clear();


        }

        // Go to customers screen
        private void Back_btn_Click(object sender, EventArgs e)
        {
            var frm = new CustomersListScreen();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        // logout button - Pass to login screen
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

        // pass to orders screen
        private void Orders_btn_Click(object sender, EventArgs e)
        {
            var frm = new OrdersListScreen();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
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

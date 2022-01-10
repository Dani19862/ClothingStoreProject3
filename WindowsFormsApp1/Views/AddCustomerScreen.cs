using Services;
using System;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Views
{
    public partial class AddCustomerScreen : Form
    {
        readonly CustomerRepositorySingelton cr;
        readonly Customer customer = new Customer();
        private int id;
        public AddCustomerScreen(int id)
        {
            InitializeComponent();
            this.id = id;
            cr = CustomerRepositorySingelton.GetSingelton();
            this.customersDataGridView.DataSource = cr.GetAllCustomersAsync();
        }

        private void CustomersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cusrtomersAndOrders);

        }

        private void AddCustomerScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cusrtomersAndOrders.Customers' table. You can move, or remove it, as needed.

        }

        private async void Add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                
                customersDataGridView.DataSource = await cr.InsertNewCustomerAsync(id, firstNameTextBox.Text, lastNameTextBox.Text,
                                                               addressTextBox.Text, cityTextBox.Text, Convert.ToInt32(no_HouseTextBox.Text),
                                                               Convert.ToInt32(postalCodeTextBox.Text), (phoneNumberTextBox.Text));
                MessageBox.Show("New Cusromer Added");
                DialogResult dialogResult = MessageBox.Show("Are You Want To Add More Cusromer?", "Back To Customers Screen", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    var frm = new CustomersListScreen();
                    frm.Location = this.Location;
                    frm.StartPosition = FormStartPosition.Manual;
                    frm.FormClosing += delegate { this.Show(); };
                    frm.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The Fields canot be empty");
            }
           
        }

        // 
        private void Customers_btn_Click(object sender, EventArgs e)
        {
            var frm = new CustomersListScreen();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
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
    }
}

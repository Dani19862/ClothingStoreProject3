using Newtonsoft.Json;
using Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Views
{
    public partial class AddOrderScreen : Form
    {
        readonly OrderRepositorySingelton or;


        public AddOrderScreen()
        {
            InitializeComponent();
            or = OrderRepositorySingelton.GetSingelton();
        }

        private void OrdersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clothingStoreDBDataSetNewOrders);
        }

        private void AddOrderScreen_Load(object sender, EventArgs e)
        {
            this.ordersTableAdapter1.Fill(this.clothingStoreDBDataSet12Orders.Orders);
        }

        private async void Add_button_Click(object sender, EventArgs e)
        {
            
            Enum.TryParse(categoryTextBox.Text.Trim().ToString(), out Order.ProductCategory category);
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            var dictoanry = JsonConvert.DeserializeObject<Dictionary<int, int>>(ProdDict_TextBox.Text);

            try
            {
                await or.InsertNewOrderAsync(
                Convert.ToInt32(TotalQuantity_TextBox.Text),
                Convert.ToDateTime(orderDate_txt.Text),
                Convert.ToDateTime(sending_Order_Date_txt.Text),
                Convert.ToInt32(employeeIDTextBox.Text),
                category,
                Convert.ToDouble(totalPriceTextBox.Text),dictoanry);
                MessageBox.Show("New Order Added Succsecfuly");
            }
            catch (Exception)
            {
                MessageBox.Show("This product is out of Inventory \n" +
                    "Try another product");
            } 

            // Pass to Add new Customer
                      
            int lastOrderId = or.GetMaxIdFromOrders();
            var frm = new AddCustomerScreen(lastOrderId);
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();

        }

        // Go to OrderScreen
        private void Back_button_Click(object sender, EventArgs e)
        {
            var frm = new OrdersListScreen();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        // Logout button - pass to login screen
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
    }
}

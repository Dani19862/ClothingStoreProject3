using Newtonsoft.Json;
using Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1.DataAccssesLayer;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Views
{
    public partial class EditOrderScreen : Form
    {
        readonly ClothingStoreDB db = new ClothingStoreDB();
        readonly OrderRepositorySingelton or;
        public EditOrderScreen()
        {
            InitializeComponent();
            or = OrderRepositorySingelton.GetSingelton();
        }

        private void OrdersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clothingStoreDBDataSet12OrdersEdit);

        }

        private void EditOrderScreen_Load(object sender, EventArgs e)
        {
            this.ordersTableAdapter1.Fill(this.clothingStoreDBDataSet12Orders.Orders);
        }

        //Edit button 
        private async void Edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<int, int> dictionary = new Dictionary<int, int>();
                Enum.TryParse(categoryTextBox.Text, out Order.ProductCategory category);
                var dictoanry = JsonConvert.DeserializeObject<Dictionary<int, int>>(ProdDict_TextBox.Text);

                await or.EditOrderAsync(Convert.ToInt32(orderIDTextBox.Text),
                    Convert.ToInt32(quantity_ProductsTextBox.Text),
                    Convert.ToDateTime(orderDate_txt.Text),
                    Convert.ToDateTime(sending_Order_Date_txt.Text),
                    Convert.ToInt32(employeeIDTextBox.Text),
                    category,
                    Convert.ToDouble(totalPriceTextBox.Text),
                    Convert.ToInt32(customerIDTextBox.Text), dictoanry);
                MessageBox.Show("Record Edited");
            }
            catch (Exception)
            {
                MessageBox.Show("Product Quantity must by like {'1':2}");
            }
           


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

        // pass to login screen
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

using Model;
using Models;
using Newtonsoft.Json;
using Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Views
{
    public partial class DeleteOrderScreen : Form
    {
        readonly OrderRepositorySingelton or;
      

        public DeleteOrderScreen()
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

        private void DeleteOrderScreen_Load(object sender, EventArgs e)
        {
            this.ordersTableAdapter1.Fill(this.clothingStoreDBDataSet12Orders.Orders);
        }

        // delete record only if user director
        private async void Delete_btn_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Delete This Record?", "Record Deleted", MessageBoxButtons.YesNo);
            if (UserDetails.UserType == User.EnumUserType.Director)  
            {
                if (dialogResult == DialogResult.Yes)
                {
                    Dictionary<int, int> dictionary = new Dictionary<int, int>();
                    Enum.TryParse(categoryTextBox.Text, out Order.ProductCategory category);
                    var dictoanry = JsonConvert.DeserializeObject<Dictionary<int, int>>(ProdDict_TextBox.Text);

                    var a= await or.DeleteOrderAsync(Convert.ToInt32(orderIDTextBox.Text),
                        Convert.ToInt32(quantity_ProductsTextBox.Text),
                        Convert.ToDateTime(orderDate_txt.Text),
                        Convert.ToDateTime(SendingOrderDate_txt.Text),
                        Convert.ToInt32(employeeIDTextBox.Text),
                        category,
                        Convert.ToDouble(totalPriceTextBox.Text),
                        Convert.ToInt32(customerIDTextBox.Text), dictoanry);
                    MessageBox.Show("Record Deleted");
                }
            }
            else
            {
                MessageBox.Show("You Canot Delete Records \n" +
                    "Only Director Can Delete Records");
            }
            

        }
        
        
        // Logout button - pass to login screen
    
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

        // pass to orders screen
        private void Back_btn_Click_1(object sender, EventArgs e)
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

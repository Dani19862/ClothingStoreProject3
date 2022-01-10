using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.DataAccssesLayer;
using Services;
using WindowsFormsApp1.Model;
using System.Collections.Generic;
using System.Reflection;
using Model;

namespace WindowsFormsApp1.Views
{
    public partial class OrdersListScreen : Form
    {
        readonly ClothingStoreDB db = new ClothingStoreDB();
        readonly OrderRepositorySingelton or;
        readonly ProductRepositorySingelton pr;



        private void OrdersListScreen_Load(object sender, EventArgs e)
        {
          
           
            DateTime dateTime = DateTime.Now;
            this.label_Time.Text = dateTime.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }

       
        public OrdersListScreen()
        {
            InitializeComponent();
            or = OrderRepositorySingelton.GetSingelton();
            pr = ProductRepositorySingelton.GetSingelton();

        }


        //  Edit Button
        private void EditOrder_Button_Click_Click_1(object sender, EventArgs e)
        {
            var frm = new EditOrderScreen();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        // To Show All Orders Records
        private async void Show_All_Orders_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await or.GetAllOrdersAsync();
        }

        // Search Button by sorting    
        readonly List<string> list = new List<string>();
        private void Search_Button_Click(object sender, EventArgs e)
        {

            try
            {
                string selection = cbFields.SelectedItem.ToString().ToLower();

                switch (selection)
                {
                    case "quantity":
                       
                        dataGridView1.DataSource = OrderRepositorySingelton.SortByQuantity(Convert.ToInt32(txtBox_Search.Text));
                        return;
                    case "order id":
                        dataGridView1.DataSource = OrderRepositorySingelton.SortByOrderIDAsync(Convert.ToInt32(txtBox_Search.Text));
                        return;
                    case "employee id":
                        dataGridView1.DataSource = OrderRepositorySingelton.SortByEmployeeID(Convert.ToInt32(txtBox_Search.Text));
                        return;
                    case "customer id":
                        dataGridView1.DataSource = OrderRepositorySingelton.SortByCustomerID(Convert.ToInt32(txtBox_Search.Text));
                        return;

                    case "category":
                        if (txtBox_Search.Text == "children")
                        {
                            Enum.TryParse(txtBox_Search.Text, out Order.ProductCategory category);
                            dataGridView1.DataSource = OrderRepositorySingelton.SortByCategory(category);
                        }
                        else if (txtBox_Search.Text == "men")
                        {
                            Enum.TryParse(txtBox_Search.Text, out Order.ProductCategory category);
                            dataGridView1.DataSource = OrderRepositorySingelton.SortByCategory(category);
                        }
                        else if (txtBox_Search.Text == "women")
                        {
                            Enum.TryParse(txtBox_Search.Text, out Order.ProductCategory category);
                            dataGridView1.DataSource = OrderRepositorySingelton.SortByCategory(category);
                        }
                        else
                        {
                            MessageBox.Show("category must be: men or women or children");
                        }
                        return;


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        // To Add New Order To Order Table
        private void AddOrder_Button_Click_Click(object sender, EventArgs e)
        {
            var frm = new AddOrderScreen();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();

        }


        // To Delete Record
        private void DeleteOrder_Button_Click_Click(object sender, EventArgs e)
        {
            DeleteOrder_Button_Click.Enabled = true;
            var frm = new DeleteOrderScreen();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();

        }


        private void OrdersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clothingStoreDBDataSet7);

        }

        private void OrdersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clothingStoreDBDataSet7);

        }

        // Display orders from date to date
        private async void SearchDate_btn_Click(object sender, EventArgs e)
        {
            txtBox_Search.Text = "";
            dataGridView1.DataSource =await  or.GetAllOrdersAsync();
            dataGridView1.DataSource = OrderRepositorySingelton.OrderByDate(Convert.ToDateTime(fromDate_txtBox.Text), Convert.ToDateTime(toDate_txtBox.Text));
        }


        // Free Order Search 
        private async  void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            List<OrderCustomer> loc = new List<OrderCustomer>();
            if (string.IsNullOrEmpty(textBoxSearch.Text) == false)
            {
                var list_c =await  or.GetAllOrdersAsync();

                foreach (var oc in list_c)
                {
                    //bool startWith = false;
                    bool contains = false;
                    foreach (PropertyInfo prop in oc.GetType().GetProperties())
                    {

                        if (prop.GetValue(oc, null).ToString().Contains(textBoxSearch.Text))
                        {
                            contains = true;

                        }
                    }
                    if (contains)
                    {
                        loc.Add(oc);
                    }

                }
                dataGridView1.DataSource = loc;
            }
            else if (textBoxSearch.Text == "")
            {
                foreach (var item in list)
                {
                    this.ordersTableAdapter2.Fill(this.clothingStoreDBDataSetNew.Orders);
                }
            }
        }
        // Get Most Sales Orderd By User
        private async void MostSales_btn(object sender, EventArgs e)
        {
            txtBox_Search.Text = "";
            dataGridView1.DataSource = await or.GetAllOrdersAsync();
            dataGridView1.DataSource = or.GetUserWithMaxSells();


        }
        // pass to login screen
        private void Exit_btn_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want Logout?", "", MessageBoxButtons.YesNo);


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
        // Get The ProductList by orderId when dubble click on a row in Order table
        private void CellDoubleClickEvent(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex > -1 && dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    string orderId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                    OrderDetails od = new OrderDetails(int.Parse(orderId));
                    od.ShowDialog(this);
                }
            }
            catch
            {

                MessageBox.Show("Invalid Opration");
            }


        }

        // Free search 
        private void Serch_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.DataSource != null)
                {
                    dataGridView1.DataSource = OrderRepositorySingelton.FromTotalPrice(Convert.ToDouble(FromPrice_txt.Text), Convert.ToDouble(ToPrice_txt.Text));
                }
                else MessageBox.Show("No orders found");

            }
            catch
            {
                MessageBox.Show("Load Orders List First");
            }

        }

        // pass to product screen
        private void Products_btn_Click(object sender, EventArgs e)
        {
            var frm = new ProductsScreen();
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




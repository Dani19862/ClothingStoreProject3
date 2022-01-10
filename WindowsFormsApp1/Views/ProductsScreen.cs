using Model;
using Models;
using Services;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class ProductsScreen : Form
    {
        readonly ProductRepositorySingelton pr;
        readonly User user = new User();
        public ProductsScreen()
        {
            InitializeComponent();
            pr = ProductRepositorySingelton.GetSingelton();

        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clothingStoreDBDataSet12ProductsN);

        }

        private void ProductsScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clothingStoreDBDataSet12ProductsN.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.clothingStoreDBDataSet12ProductsN.Products);

        }

        void Clear()
        {
            product_TypeTextBox.Text = colorTextBox.Text = quanitity_In_InventoryTextBox.Text = unit_PriceTextBox.Text = sizeTextBox.Text = colorTextBox.Text = "";
        }

        //To add new Product
        private void Add_button_Click(object sender, EventArgs e)
        {
            var frm = new AddProductScreen();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        // to edit Product
        private void Edit_Button_Click(object sender, EventArgs e)
        {
            try
            {

                Enum.TryParse(sizeTextBox.Text, out Product.ProductSize productSize);
                var a = pr.EditProduct(Convert.ToInt32(productIDTextBox.Text), product_TypeTextBox.Text, colorTextBox.Text, productSize,
                                      Convert.ToInt32(quanitity_In_InventoryTextBox.Text), Convert.ToDouble(unit_PriceTextBox.Text));
                


                MessageBox.Show("The Record Changed Succefully");
                var frm = new ProductsScreen();
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                frm.FormClosing += delegate { this.Show(); };
                frm.Show();
                this.Hide();
            }
            catch (Exception )
            {

                MessageBox.Show("the fields canot be empty");
            }

        }

        // To delete Product
        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (user.UserType == User.EnumUserType.Director)
            {
                DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Delete This Record?", "Record Deleted", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    Enum.TryParse(sizeTextBox.Text, out Product.ProductSize productSize);
                    productsDataGridView.DataSource = pr.DeleteProdcutAsync(Convert.ToInt32(productIDTextBox.Text), product_TypeTextBox.Text, colorTextBox.Text, productSize,
                        Convert.ToInt32(quanitity_In_InventoryTextBox.Text), Convert.ToDouble(unit_PriceTextBox.Text));
                    MessageBox.Show("Record Deleted");
                    var frm = new ProductsScreen();
                    frm.Location = this.Location;
                    frm.StartPosition = FormStartPosition.Manual;
                    frm.FormClosing += delegate { this.Show(); };
                    frm.Show();
                    this.Hide();

                    //Clear();

                }
            }
            else
            {
                MessageBox.Show("You Canot Delete Records \n" +
                    "Only Director Can Delete Records");

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

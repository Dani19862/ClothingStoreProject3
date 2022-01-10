using Model;
using Services;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class AddProductScreen : Form
    {
        ProductRepositorySingelton pr;
        public AddProductScreen()
        {
            InitializeComponent();
            pr = ProductRepositorySingelton.GetSingelton();
        }

        private void ProductsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.products);

        }

        private void AddProductScreen_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter1.Fill(this.clothingStoreDBDataSet122Products.Products);
           
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    Enum.TryParse(sizeTextBox.Text, out Product.ProductSize productSize);
                    productsDataGridView.DataSource = pr.InsertNewProductAsync(productTypeTextBox.Text, colorTextBox.Text, productSize,
                        Convert.ToInt32(quanitityInInventoryTextBox.Text), Convert.ToDouble(unitPriceTextBox.Text));
                    MessageBox.Show("New Record Added Succefully");
                    
                    var frm = new ProductsScreen();
                    frm.Location = this.Location;
                    frm.StartPosition = FormStartPosition.Manual;
                    frm.FormClosing += delegate { this.Show(); };
                    frm.Show();
                    this.Hide();

                }
                catch (Exception)
                {

                    MessageBox.Show("Fields canot be empty");
                }


            }
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
        // go to product screen
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

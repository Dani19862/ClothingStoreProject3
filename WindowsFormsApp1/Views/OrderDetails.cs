using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class OrderDetails : Form
    {
        readonly private int orderId;
        readonly ProductRepositorySingelton pr;

        //display the products details by orderid
        public OrderDetails(int orderId)
        {
            InitializeComponent();
            pr = ProductRepositorySingelton.GetSingelton();
            this.orderId = orderId;
           
            dataGridView1.DataSource = pr.GetProductById(orderId);
        }
        // pass to orders screen
        private void Exit_btn_Click(object sender, EventArgs e)
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

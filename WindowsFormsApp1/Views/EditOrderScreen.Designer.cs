
namespace WindowsFormsApp1.Views
{
    partial class EditOrderScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label orderIDLabel;
            System.Windows.Forms.Label employeeIDLabel;
            System.Windows.Forms.Label order_DateLabel;
            System.Windows.Forms.Label sending_Order_DateLabel;
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label quantity_ProductsLabel;
            System.Windows.Forms.Label totalPriceLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label productsQuantityLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditOrderScreen));
            this.clothingStoreDBDataSet12OrdersEdit = new WindowsFormsApp1.ClothingStoreDBDataSet12OrdersEdit();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new WindowsFormsApp1.ClothingStoreDBDataSet12OrdersEditTableAdapters.OrdersTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.ClothingStoreDBDataSet12OrdersEditTableAdapters.TableAdapterManager();
            this.ordersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Orders_btn = new System.Windows.Forms.Button();
            this.Edit_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.clothingStoreDBDataSet12Orders = new WindowsFormsApp1.ClothingStoreDBDataSet12Orders();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter1 = new WindowsFormsApp1.ClothingStoreDBDataSet12OrdersTableAdapters.OrdersTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApp1.ClothingStoreDBDataSet12OrdersTableAdapters.TableAdapterManager();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.employeeIDTextBox = new System.Windows.Forms.TextBox();
            this.orderDate_txt = new System.Windows.Forms.DateTimePicker();
            this.sending_Order_Date_txt = new System.Windows.Forms.DateTimePicker();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.quantity_ProductsTextBox = new System.Windows.Forms.TextBox();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.ProdDict_TextBox = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            orderIDLabel = new System.Windows.Forms.Label();
            employeeIDLabel = new System.Windows.Forms.Label();
            order_DateLabel = new System.Windows.Forms.Label();
            sending_Order_DateLabel = new System.Windows.Forms.Label();
            customerIDLabel = new System.Windows.Forms.Label();
            quantity_ProductsLabel = new System.Windows.Forms.Label();
            totalPriceLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            productsQuantityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreDBDataSet12OrdersEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingNavigator)).BeginInit();
            this.ordersBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreDBDataSet12Orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // clothingStoreDBDataSet12OrdersEdit
            // 
            this.clothingStoreDBDataSet12OrdersEdit.DataSetName = "ClothingStoreDBDataSet12OrdersEdit";
            this.clothingStoreDBDataSet12OrdersEdit.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.clothingStoreDBDataSet12OrdersEdit;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.ClothingStoreDBDataSet12OrdersEditTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ordersBindingNavigator
            // 
            this.ordersBindingNavigator.AddNewItem = null;
            this.ordersBindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ordersBindingNavigator.BindingSource = this.ordersBindingSource;
            this.ordersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ordersBindingNavigator.DeleteItem = null;
            this.ordersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.ordersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ordersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ordersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ordersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ordersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ordersBindingNavigator.Name = "ordersBindingNavigator";
            this.ordersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ordersBindingNavigator.Size = new System.Drawing.Size(927, 25);
            this.ordersBindingNavigator.TabIndex = 0;
            this.ordersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.ForeColor = System.Drawing.Color.White;
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Orders_btn
            // 
            this.Orders_btn.FlatAppearance.BorderSize = 0;
            this.Orders_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Orders_btn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Orders_btn.ForeColor = System.Drawing.Color.White;
            this.Orders_btn.Location = new System.Drawing.Point(3, 112);
            this.Orders_btn.Name = "Orders_btn";
            this.Orders_btn.Size = new System.Drawing.Size(121, 41);
            this.Orders_btn.TabIndex = 22;
            this.Orders_btn.Text = "Orders";
            this.Orders_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Orders_btn.UseVisualStyleBackColor = true;
            this.Orders_btn.Click += new System.EventHandler(this.Orders_btn_Click);
            // 
            // Edit_btn
            // 
            this.Edit_btn.FlatAppearance.BorderSize = 0;
            this.Edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_btn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Edit_btn.ForeColor = System.Drawing.Color.White;
            this.Edit_btn.Location = new System.Drawing.Point(408, 547);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.Size = new System.Drawing.Size(164, 61);
            this.Edit_btn.TabIndex = 23;
            this.Edit_btn.Text = "Edit";
            this.Edit_btn.UseVisualStyleBackColor = true;
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Orders_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 603);
            this.panel1.TabIndex = 24;
            // 
            // Logout_btn
            // 
            this.Logout_btn.FlatAppearance.BorderSize = 0;
            this.Logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Logout_btn.ForeColor = System.Drawing.Color.White;
            this.Logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Logout_btn.Location = new System.Drawing.Point(796, 0);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(131, 45);
            this.Logout_btn.TabIndex = 89;
            this.Logout_btn.Text = "LogOut";
            this.Logout_btn.UseVisualStyleBackColor = true;
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // clothingStoreDBDataSet12Orders
            // 
            this.clothingStoreDBDataSet12Orders.DataSetName = "ClothingStoreDBDataSet12Orders";
            this.clothingStoreDBDataSet12Orders.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "Orders";
            this.ordersBindingSource1.DataSource = this.clothingStoreDBDataSet12Orders;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.OrdersTableAdapter = this.ordersTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApp1.ClothingStoreDBDataSet12OrdersTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AutoGenerateColumns = false;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.ordersDataGridView.DataSource = this.ordersBindingSource1;
            this.ordersDataGridView.Location = new System.Drawing.Point(146, 214);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.Size = new System.Drawing.Size(746, 339);
            this.ordersDataGridView.TabIndex = 90;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OrderID";
            this.dataGridViewTextBoxColumn1.HeaderText = "OrderID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EmployeeID";
            this.dataGridViewTextBoxColumn2.HeaderText = "EmployeeID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Order Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Order Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Sending Order Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Sending Order Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn5.HeaderText = "CustomerID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Quantity Products";
            this.dataGridViewTextBoxColumn6.HeaderText = "Quantity Products";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TotalPrice";
            this.dataGridViewTextBoxColumn7.HeaderText = "TotalPrice";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn8.HeaderText = "Category";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ProductsQuantity";
            this.dataGridViewTextBoxColumn9.HeaderText = "ProductsQuantity";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            orderIDLabel.ForeColor = System.Drawing.Color.White;
            orderIDLabel.Location = new System.Drawing.Point(241, 46);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new System.Drawing.Size(65, 17);
            orderIDLabel.TabIndex = 90;
            orderIDLabel.Text = "Order ID:";
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource1, "OrderID", true));
            this.orderIDTextBox.Location = new System.Drawing.Point(312, 43);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.Size = new System.Drawing.Size(158, 20);
            this.orderIDTextBox.TabIndex = 91;
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            employeeIDLabel.ForeColor = System.Drawing.Color.White;
            employeeIDLabel.Location = new System.Drawing.Point(214, 72);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(92, 17);
            employeeIDLabel.TabIndex = 92;
            employeeIDLabel.Text = "Employee ID:";
            // 
            // employeeIDTextBox
            // 
            this.employeeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource1, "EmployeeID", true));
            this.employeeIDTextBox.Location = new System.Drawing.Point(312, 69);
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.Size = new System.Drawing.Size(158, 20);
            this.employeeIDTextBox.TabIndex = 93;
            // 
            // order_DateLabel
            // 
            order_DateLabel.AutoSize = true;
            order_DateLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            order_DateLabel.ForeColor = System.Drawing.Color.White;
            order_DateLabel.Location = new System.Drawing.Point(222, 98);
            order_DateLabel.Name = "order_DateLabel";
            order_DateLabel.Size = new System.Drawing.Size(84, 17);
            order_DateLabel.TabIndex = 94;
            order_DateLabel.Text = "Order Date:";
            // 
            // orderDate_txt
            // 
            this.orderDate_txt.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource1, "Order Date", true));
            this.orderDate_txt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.orderDate_txt.Location = new System.Drawing.Point(312, 95);
            this.orderDate_txt.Name = "orderDate_txt";
            this.orderDate_txt.Size = new System.Drawing.Size(158, 20);
            this.orderDate_txt.TabIndex = 95;
            // 
            // sending_Order_DateLabel
            // 
            sending_Order_DateLabel.AutoSize = true;
            sending_Order_DateLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            sending_Order_DateLabel.ForeColor = System.Drawing.Color.White;
            sending_Order_DateLabel.Location = new System.Drawing.Point(167, 124);
            sending_Order_DateLabel.Name = "sending_Order_DateLabel";
            sending_Order_DateLabel.Size = new System.Drawing.Size(139, 17);
            sending_Order_DateLabel.TabIndex = 96;
            sending_Order_DateLabel.Text = "Sending Order Date:";
            // 
            // sending_Order_Date_txt
            // 
            this.sending_Order_Date_txt.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource1, "Sending Order Date", true));
            this.sending_Order_Date_txt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.sending_Order_Date_txt.Location = new System.Drawing.Point(312, 121);
            this.sending_Order_Date_txt.Name = "sending_Order_Date_txt";
            this.sending_Order_Date_txt.Size = new System.Drawing.Size(158, 20);
            this.sending_Order_Date_txt.TabIndex = 97;
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            customerIDLabel.ForeColor = System.Drawing.Color.White;
            customerIDLabel.Location = new System.Drawing.Point(214, 148);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(92, 17);
            customerIDLabel.TabIndex = 98;
            customerIDLabel.Text = "Customer ID:";
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource1, "CustomerID", true));
            this.customerIDTextBox.Location = new System.Drawing.Point(312, 147);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(158, 20);
            this.customerIDTextBox.TabIndex = 99;
            // 
            // quantity_ProductsLabel
            // 
            quantity_ProductsLabel.AutoSize = true;
            quantity_ProductsLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            quantity_ProductsLabel.ForeColor = System.Drawing.Color.White;
            quantity_ProductsLabel.Location = new System.Drawing.Point(530, 54);
            quantity_ProductsLabel.Name = "quantity_ProductsLabel";
            quantity_ProductsLabel.Size = new System.Drawing.Size(106, 17);
            quantity_ProductsLabel.TabIndex = 100;
            quantity_ProductsLabel.Text = "Total Quantity: ";
            // 
            // quantity_ProductsTextBox
            // 
            this.quantity_ProductsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource1, "Quantity Products", true));
            this.quantity_ProductsTextBox.Location = new System.Drawing.Point(642, 53);
            this.quantity_ProductsTextBox.Name = "quantity_ProductsTextBox";
            this.quantity_ProductsTextBox.Size = new System.Drawing.Size(170, 20);
            this.quantity_ProductsTextBox.TabIndex = 101;
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            totalPriceLabel.ForeColor = System.Drawing.Color.White;
            totalPriceLabel.Location = new System.Drawing.Point(558, 80);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new System.Drawing.Size(78, 17);
            totalPriceLabel.TabIndex = 102;
            totalPriceLabel.Text = "Total Price:";
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource1, "TotalPrice", true));
            this.totalPriceTextBox.Location = new System.Drawing.Point(642, 79);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.Size = new System.Drawing.Size(170, 20);
            this.totalPriceTextBox.TabIndex = 103;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            categoryLabel.ForeColor = System.Drawing.Color.White;
            categoryLabel.Location = new System.Drawing.Point(563, 106);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(73, 17);
            categoryLabel.TabIndex = 104;
            categoryLabel.Text = "Category:";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource1, "Category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(642, 105);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(170, 20);
            this.categoryTextBox.TabIndex = 105;
            // 
            // productsQuantityLabel
            // 
            productsQuantityLabel.AutoSize = true;
            productsQuantityLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            productsQuantityLabel.ForeColor = System.Drawing.Color.White;
            productsQuantityLabel.Location = new System.Drawing.Point(485, 132);
            productsQuantityLabel.Name = "productsQuantityLabel";
            productsQuantityLabel.Size = new System.Drawing.Size(151, 17);
            productsQuantityLabel.TabIndex = 106;
            productsQuantityLabel.Text = "Product ID:   Quantity:";
            // 
            // ProdDict_TextBox
            // 
            this.ProdDict_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource1, "ProductsQuantity", true));
            this.ProdDict_TextBox.Location = new System.Drawing.Point(642, 131);
            this.ProdDict_TextBox.Name = "ProdDict_TextBox";
            this.ProdDict_TextBox.Size = new System.Drawing.Size(170, 20);
            this.ProdDict_TextBox.TabIndex = 107;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pictureBox6.Image = global::WindowsFormsApp1.Properties.Resources.logout2;
            this.pictureBox6.Location = new System.Drawing.Point(889, 9);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(23, 24);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 90;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.ordersIcon;
            this.pictureBox2.Location = new System.Drawing.Point(79, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 86;
            this.pictureBox2.TabStop = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // EditOrderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(927, 628);
            this.Controls.Add(orderIDLabel);
            this.Controls.Add(this.orderIDTextBox);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(this.employeeIDTextBox);
            this.Controls.Add(order_DateLabel);
            this.Controls.Add(this.orderDate_txt);
            this.Controls.Add(sending_Order_DateLabel);
            this.Controls.Add(this.sending_Order_Date_txt);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(quantity_ProductsLabel);
            this.Controls.Add(this.quantity_ProductsTextBox);
            this.Controls.Add(totalPriceLabel);
            this.Controls.Add(this.totalPriceTextBox);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(productsQuantityLabel);
            this.Controls.Add(this.ProdDict_TextBox);
            this.Controls.Add(this.ordersDataGridView);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.Logout_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Edit_btn);
            this.Controls.Add(this.ordersBindingNavigator);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditOrderScreen";
            this.Text = "EditOrderScreen";
            this.Load += new System.EventHandler(this.EditOrderScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreDBDataSet12OrdersEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingNavigator)).EndInit();
            this.ordersBindingNavigator.ResumeLayout(false);
            this.ordersBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreDBDataSet12Orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClothingStoreDBDataSet12OrdersEdit clothingStoreDBDataSet12OrdersEdit;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private ClothingStoreDBDataSet12OrdersEditTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private ClothingStoreDBDataSet12OrdersEditTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ordersBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button Orders_btn;
        private System.Windows.Forms.Button Edit_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button Logout_btn;
        private ClothingStoreDBDataSet12Orders clothingStoreDBDataSet12Orders;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private ClothingStoreDBDataSet12OrdersTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private ClothingStoreDBDataSet12OrdersTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox orderIDTextBox;
        private System.Windows.Forms.TextBox employeeIDTextBox;
        private System.Windows.Forms.DateTimePicker orderDate_txt;
        private System.Windows.Forms.DateTimePicker sending_Order_Date_txt;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox quantity_ProductsTextBox;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox ProdDict_TextBox;
    }
}
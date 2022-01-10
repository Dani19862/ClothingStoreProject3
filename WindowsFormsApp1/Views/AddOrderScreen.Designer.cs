
namespace WindowsFormsApp1.Views
{
    partial class AddOrderScreen
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
            System.Windows.Forms.Label employeeIDLabel;
            System.Windows.Forms.Label order_DateLabel;
            System.Windows.Forms.Label sending_Order_DateLabel;
            System.Windows.Forms.Label quantity_ProductsLabel;
            System.Windows.Forms.Label totalPriceLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label productsQuantityLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrderScreen));
            this.Add_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.clothingStoreDBDataSetNewOrders = new WindowsFormsApp1.ClothingStoreDBDataSetNewOrders();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new WindowsFormsApp1.ClothingStoreDBDataSetNewOrdersTableAdapters.OrdersTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.ClothingStoreDBDataSetNewOrdersTableAdapters.TableAdapterManager();
            this.ordersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
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
            this.employeeIDTextBox = new System.Windows.Forms.TextBox();
            this.orderDate_txt = new System.Windows.Forms.DateTimePicker();
            this.sending_Order_Date_txt = new System.Windows.Forms.DateTimePicker();
            this.TotalQuantity_TextBox = new System.Windows.Forms.TextBox();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.ProdDict_TextBox = new System.Windows.Forms.TextBox();
            employeeIDLabel = new System.Windows.Forms.Label();
            order_DateLabel = new System.Windows.Forms.Label();
            sending_Order_DateLabel = new System.Windows.Forms.Label();
            quantity_ProductsLabel = new System.Windows.Forms.Label();
            totalPriceLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            productsQuantityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreDBDataSetNewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingNavigator)).BeginInit();
            this.ordersBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreDBDataSet12Orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            employeeIDLabel.ForeColor = System.Drawing.Color.White;
            employeeIDLabel.Location = new System.Drawing.Point(185, 77);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(92, 17);
            employeeIDLabel.TabIndex = 90;
            employeeIDLabel.Text = "Employee ID:";
            // 
            // order_DateLabel
            // 
            order_DateLabel.AutoSize = true;
            order_DateLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            order_DateLabel.ForeColor = System.Drawing.Color.White;
            order_DateLabel.Location = new System.Drawing.Point(193, 104);
            order_DateLabel.Name = "order_DateLabel";
            order_DateLabel.Size = new System.Drawing.Size(84, 17);
            order_DateLabel.TabIndex = 92;
            order_DateLabel.Text = "Order Date:";
            // 
            // sending_Order_DateLabel
            // 
            sending_Order_DateLabel.AutoSize = true;
            sending_Order_DateLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            sending_Order_DateLabel.ForeColor = System.Drawing.Color.White;
            sending_Order_DateLabel.Location = new System.Drawing.Point(138, 130);
            sending_Order_DateLabel.Name = "sending_Order_DateLabel";
            sending_Order_DateLabel.Size = new System.Drawing.Size(139, 17);
            sending_Order_DateLabel.TabIndex = 94;
            sending_Order_DateLabel.Text = "Sending Order Date:";
            // 
            // quantity_ProductsLabel
            // 
            quantity_ProductsLabel.AutoSize = true;
            quantity_ProductsLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            quantity_ProductsLabel.ForeColor = System.Drawing.Color.White;
            quantity_ProductsLabel.Location = new System.Drawing.Point(492, 74);
            quantity_ProductsLabel.Name = "quantity_ProductsLabel";
            quantity_ProductsLabel.Size = new System.Drawing.Size(102, 17);
            quantity_ProductsLabel.TabIndex = 98;
            quantity_ProductsLabel.Text = "Total Quantity:";
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            totalPriceLabel.ForeColor = System.Drawing.Color.White;
            totalPriceLabel.Location = new System.Drawing.Point(516, 100);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new System.Drawing.Size(78, 17);
            totalPriceLabel.TabIndex = 100;
            totalPriceLabel.Text = "Total Price:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            categoryLabel.ForeColor = System.Drawing.Color.White;
            categoryLabel.Location = new System.Drawing.Point(521, 126);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(73, 17);
            categoryLabel.TabIndex = 102;
            categoryLabel.Text = "Category:";
            // 
            // productsQuantityLabel
            // 
            productsQuantityLabel.AutoSize = true;
            productsQuantityLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            productsQuantityLabel.ForeColor = System.Drawing.Color.White;
            productsQuantityLabel.Location = new System.Drawing.Point(443, 150);
            productsQuantityLabel.Name = "productsQuantityLabel";
            productsQuantityLabel.Size = new System.Drawing.Size(151, 17);
            productsQuantityLabel.TabIndex = 104;
            productsQuantityLabel.Text = "Product ID:   Quantity:";
            // 
            // Add_button
            // 
            this.Add_button.FlatAppearance.BorderSize = 0;
            this.Add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Add_button.ForeColor = System.Drawing.Color.White;
            this.Add_button.Location = new System.Drawing.Point(417, 486);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(143, 61);
            this.Add_button.TabIndex = 0;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.FlatAppearance.BorderSize = 0;
            this.Back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Back_button.ForeColor = System.Drawing.Color.White;
            this.Back_button.Location = new System.Drawing.Point(4, 127);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(108, 31);
            this.Back_button.TabIndex = 1;
            this.Back_button.Text = "Orders";
            this.Back_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // clothingStoreDBDataSetNewOrders
            // 
            this.clothingStoreDBDataSetNewOrders.DataSetName = "ClothingStoreDBDataSetNewOrders";
            this.clothingStoreDBDataSetNewOrders.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.clothingStoreDBDataSetNewOrders;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.ClothingStoreDBDataSetNewOrdersTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.ordersBindingNavigator.Size = new System.Drawing.Size(868, 25);
            this.ordersBindingNavigator.TabIndex = 2;
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
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Back_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 551);
            this.panel1.TabIndex = 24;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.ordersIcon;
            this.pictureBox2.Location = new System.Drawing.Point(71, 127);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 80;
            this.pictureBox2.TabStop = false;
            // 
            // Exit_btn
            // 
            this.Exit_btn.FlatAppearance.BorderSize = 0;
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Exit_btn.ForeColor = System.Drawing.Color.White;
            this.Exit_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Exit_btn.Location = new System.Drawing.Point(709, 0);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(131, 45);
            this.Exit_btn.TabIndex = 85;
            this.Exit_btn.Text = "LogOut";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pictureBox6.Image = global::WindowsFormsApp1.Properties.Resources.logout2;
            this.pictureBox6.Location = new System.Drawing.Point(802, 9);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(23, 24);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 86;
            this.pictureBox6.TabStop = false;
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
            this.ordersDataGridView.Location = new System.Drawing.Point(126, 234);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.Size = new System.Drawing.Size(722, 246);
            this.ordersDataGridView.TabIndex = 88;
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
            // employeeIDTextBox
            // 
            this.employeeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource1, "EmployeeID", true));
            this.employeeIDTextBox.Location = new System.Drawing.Point(283, 74);
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.Size = new System.Drawing.Size(146, 20);
            this.employeeIDTextBox.TabIndex = 91;
            // 
            // orderDate_txt
            // 
            this.orderDate_txt.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource1, "Order Date", true));
            this.orderDate_txt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.orderDate_txt.Location = new System.Drawing.Point(283, 100);
            this.orderDate_txt.Name = "orderDate_txt";
            this.orderDate_txt.Size = new System.Drawing.Size(146, 20);
            this.orderDate_txt.TabIndex = 93;
            // 
            // sending_Order_Date_txt
            // 
            this.sending_Order_Date_txt.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource1, "Sending Order Date", true));
            this.sending_Order_Date_txt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.sending_Order_Date_txt.Location = new System.Drawing.Point(283, 126);
            this.sending_Order_Date_txt.Name = "sending_Order_Date_txt";
            this.sending_Order_Date_txt.Size = new System.Drawing.Size(146, 20);
            this.sending_Order_Date_txt.TabIndex = 95;
            // 
            // TotalQuantity_TextBox
            // 
            this.TotalQuantity_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource1, "Quantity Products", true));
            this.TotalQuantity_TextBox.Location = new System.Drawing.Point(600, 71);
            this.TotalQuantity_TextBox.Name = "TotalQuantity_TextBox";
            this.TotalQuantity_TextBox.Size = new System.Drawing.Size(162, 20);
            this.TotalQuantity_TextBox.TabIndex = 99;
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource1, "TotalPrice", true));
            this.totalPriceTextBox.Location = new System.Drawing.Point(600, 97);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.Size = new System.Drawing.Size(162, 20);
            this.totalPriceTextBox.TabIndex = 101;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource1, "Category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(600, 123);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(162, 20);
            this.categoryTextBox.TabIndex = 103;
            // 
            // ProdDict_TextBox
            // 
            this.ProdDict_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource1, "ProductsQuantity", true));
            this.ProdDict_TextBox.Location = new System.Drawing.Point(600, 149);
            this.ProdDict_TextBox.Name = "ProdDict_TextBox";
            this.ProdDict_TextBox.Size = new System.Drawing.Size(162, 20);
            this.ProdDict_TextBox.TabIndex = 105;
            // 
            // AddOrderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(868, 576);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(this.employeeIDTextBox);
            this.Controls.Add(order_DateLabel);
            this.Controls.Add(this.orderDate_txt);
            this.Controls.Add(sending_Order_DateLabel);
            this.Controls.Add(this.sending_Order_Date_txt);
            this.Controls.Add(quantity_ProductsLabel);
            this.Controls.Add(this.TotalQuantity_TextBox);
            this.Controls.Add(totalPriceLabel);
            this.Controls.Add(this.totalPriceTextBox);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(productsQuantityLabel);
            this.Controls.Add(this.ProdDict_TextBox);
            this.Controls.Add(this.ordersDataGridView);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ordersBindingNavigator);
            this.Controls.Add(this.Add_button);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddOrderScreen";
            this.Text = "AddOrderScreen";
            this.Load += new System.EventHandler(this.AddOrderScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreDBDataSetNewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingNavigator)).EndInit();
            this.ordersBindingNavigator.ResumeLayout(false);
            this.ordersBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreDBDataSet12Orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Back_button;
        private ClothingStoreDBDataSetNewOrders clothingStoreDBDataSetNewOrders;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private ClothingStoreDBDataSetNewOrdersTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private ClothingStoreDBDataSetNewOrdersTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button Exit_btn;
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
        private System.Windows.Forms.TextBox employeeIDTextBox;
        private System.Windows.Forms.DateTimePicker orderDate_txt;
        private System.Windows.Forms.DateTimePicker sending_Order_Date_txt;
        private System.Windows.Forms.TextBox TotalQuantity_TextBox;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox ProdDict_TextBox;
    }
}
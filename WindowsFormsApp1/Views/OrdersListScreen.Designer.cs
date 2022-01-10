
namespace WindowsFormsApp1.Views
{
    partial class OrdersListScreen
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
            System.Windows.Forms.Label orderDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersListScreen));
            this.label7 = new System.Windows.Forms.Label();
            this.EditOrder_Button_Click = new System.Windows.Forms.Button();
            this.AddOrder_Button_Click = new System.Windows.Forms.Button();
            this.Show_All_Orders = new System.Windows.Forms.Button();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clothingStoreDBDataSet7 = new WindowsFormsApp1.ClothingStoreDBDataSet7();
            this.ordersTableAdapter = new WindowsFormsApp1.ClothingStoreDBDataSet7TableAdapters.OrdersTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.ClothingStoreDBDataSet7TableAdapters.TableAdapterManager();
            this.fromDate_txtBox = new System.Windows.Forms.DateTimePicker();
            this.toDate_txtBox = new System.Windows.Forms.DateTimePicker();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtBox_Search = new System.Windows.Forms.TextBox();
            this.clothingStoreDBDataSet7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerAndOrers = new WindowsFormsApp1.CustomerAndOrers();
            this.customerAndOrersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new WindowsFormsApp1.CustomerAndOrersTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApp1.CustomerAndOrersTableAdapters.TableAdapterManager();
            this.ordersTableAdapter1 = new WindowsFormsApp1.CustomerAndOrersTableAdapters.OrdersTableAdapter();
            this.ordersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.cbFields = new System.Windows.Forms.ComboBox();
            this.Sortlabel = new System.Windows.Forms.Label();
            this.clothingStoreDBDataSetNew = new WindowsFormsApp1.ClothingStoreDBDataSetNew();
            this.ordersBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter2 = new WindowsFormsApp1.ClothingStoreDBDataSetNewTableAdapters.OrdersTableAdapter();
            this.tableAdapterManager2 = new WindowsFormsApp1.ClothingStoreDBDataSetNewTableAdapters.TableAdapterManager();
            this.DeleteOrder_Button_Click = new System.Windows.Forms.Button();
            this.searchDate_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.ordersCustomersNew = new WindowsFormsApp1.OrdersCustomersNew();
            this.customersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter1 = new WindowsFormsApp1.OrdersCustomersNewTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager3 = new WindowsFormsApp1.OrdersCustomersNewTableAdapters.TableAdapterManager();
            this.label_Time = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Customers_btn = new System.Windows.Forms.Button();
            this.Products_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SearchSales_btn = new System.Windows.Forms.Button();
            this.cusrtomersAndOrders = new WindowsFormsApp1.CusrtomersAndOrders();
            this.ordersBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter3 = new WindowsFormsApp1.CusrtomersAndOrdersTableAdapters.OrdersTableAdapter();
            this.tableAdapterManager4 = new WindowsFormsApp1.CusrtomersAndOrdersTableAdapters.TableAdapterManager();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FromPrice_txt = new System.Windows.Forms.TextBox();
            this.ToPrice_txt = new System.Windows.Forms.TextBox();
            this.Serch_btn = new System.Windows.Forms.Button();
            this.Search_Button = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ordersBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            orderDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreDBDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreDBDataSet7BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerAndOrers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerAndOrersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreDBDataSetNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersCustomersNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cusrtomersAndOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource6)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            orderDateLabel.ForeColor = System.Drawing.Color.White;
            orderDateLabel.Location = new System.Drawing.Point(191, 112);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(129, 17);
            orderDateLabel.TabIndex = 44;
            orderDateLabel.Text = "Orders From Date: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label7.Location = new System.Drawing.Point(305, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 47);
            this.label7.TabIndex = 15;
            this.label7.Text = "Oredrs List";
            // 
            // EditOrder_Button_Click
            // 
            this.EditOrder_Button_Click.FlatAppearance.BorderSize = 0;
            this.EditOrder_Button_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditOrder_Button_Click.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.EditOrder_Button_Click.ForeColor = System.Drawing.Color.White;
            this.EditOrder_Button_Click.Location = new System.Drawing.Point(297, 3);
            this.EditOrder_Button_Click.Name = "EditOrder_Button_Click";
            this.EditOrder_Button_Click.Size = new System.Drawing.Size(202, 87);
            this.EditOrder_Button_Click.TabIndex = 1;
            this.EditOrder_Button_Click.Text = "Edit Order";
            this.EditOrder_Button_Click.UseVisualStyleBackColor = true;
            this.EditOrder_Button_Click.Click += new System.EventHandler(this.EditOrder_Button_Click_Click_1);
            // 
            // AddOrder_Button_Click
            // 
            this.AddOrder_Button_Click.FlatAppearance.BorderSize = 0;
            this.AddOrder_Button_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddOrder_Button_Click.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.AddOrder_Button_Click.ForeColor = System.Drawing.Color.White;
            this.AddOrder_Button_Click.Location = new System.Drawing.Point(505, 7);
            this.AddOrder_Button_Click.Name = "AddOrder_Button_Click";
            this.AddOrder_Button_Click.Size = new System.Drawing.Size(224, 79);
            this.AddOrder_Button_Click.TabIndex = 2;
            this.AddOrder_Button_Click.Text = "Add New Order";
            this.AddOrder_Button_Click.UseVisualStyleBackColor = true;
            this.AddOrder_Button_Click.Click += new System.EventHandler(this.AddOrder_Button_Click_Click);
            // 
            // Show_All_Orders
            // 
            this.Show_All_Orders.FlatAppearance.BorderSize = 0;
            this.Show_All_Orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Show_All_Orders.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_All_Orders.ForeColor = System.Drawing.Color.White;
            this.Show_All_Orders.Location = new System.Drawing.Point(3, 65);
            this.Show_All_Orders.Name = "Show_All_Orders";
            this.Show_All_Orders.Size = new System.Drawing.Size(95, 80);
            this.Show_All_Orders.TabIndex = 17;
            this.Show_All_Orders.Text = "Show All Orders List";
            this.Show_All_Orders.UseVisualStyleBackColor = true;
            this.Show_All_Orders.Click += new System.EventHandler(this.Show_All_Orders_Click);
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.clothingStoreDBDataSet7;
            // 
            // clothingStoreDBDataSet7
            // 
            this.clothingStoreDBDataSet7.DataSetName = "ClothingStoreDBDataSet7";
            this.clothingStoreDBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.ClothingStoreDBDataSet7TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fromDate_txtBox
            // 
            this.fromDate_txtBox.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "OrderDate", true));
            this.fromDate_txtBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDate_txtBox.Location = new System.Drawing.Point(320, 110);
            this.fromDate_txtBox.Name = "fromDate_txtBox";
            this.fromDate_txtBox.Size = new System.Drawing.Size(98, 20);
            this.fromDate_txtBox.TabIndex = 45;
            // 
            // toDate_txtBox
            // 
            this.toDate_txtBox.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "SendeingOrderDate", true));
            this.toDate_txtBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDate_txtBox.Location = new System.Drawing.Point(487, 110);
            this.toDate_txtBox.Name = "toDate_txtBox";
            this.toDate_txtBox.Size = new System.Drawing.Size(102, 20);
            this.toDate_txtBox.TabIndex = 47;
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "Orders";
            this.ordersBindingSource1.DataSource = this.clothingStoreDBDataSet7;
            // 
            // txtBox_Search
            // 
            this.txtBox_Search.Location = new System.Drawing.Point(487, 83);
            this.txtBox_Search.Name = "txtBox_Search";
            this.txtBox_Search.Size = new System.Drawing.Size(102, 20);
            this.txtBox_Search.TabIndex = 59;
            // 
            // clothingStoreDBDataSet7BindingSource
            // 
            this.clothingStoreDBDataSet7BindingSource.DataSource = this.clothingStoreDBDataSet7;
            this.clothingStoreDBDataSet7BindingSource.Position = 0;
            // 
            // customerAndOrers
            // 
            this.customerAndOrers.DataSetName = "CustomerAndOrers";
            this.customerAndOrers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerAndOrersBindingSource
            // 
            this.customerAndOrersBindingSource.DataSource = this.customerAndOrers;
            this.customerAndOrersBindingSource.Position = 0;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.customerAndOrers;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager1.OrdersTableAdapter = this.ordersTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApp1.CustomerAndOrersTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersBindingSource3
            // 
            this.ordersBindingSource3.DataMember = "Orders";
            this.ordersBindingSource3.DataSource = this.customerAndOrers;
            // 
            // cbFields
            // 
            this.cbFields.FormattingEnabled = true;
            this.cbFields.Items.AddRange(new object[] {
            "--Select--",
            "Order Id",
            "Employee Id",
            "Customer Id",
            "Quantity",
            "Category"});
            this.cbFields.Location = new System.Drawing.Point(319, 82);
            this.cbFields.Name = "cbFields";
            this.cbFields.Size = new System.Drawing.Size(162, 21);
            this.cbFields.TabIndex = 60;
            // 
            // Sortlabel
            // 
            this.Sortlabel.AutoSize = true;
            this.Sortlabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sortlabel.ForeColor = System.Drawing.Color.White;
            this.Sortlabel.Location = new System.Drawing.Point(214, 82);
            this.Sortlabel.Name = "Sortlabel";
            this.Sortlabel.Size = new System.Drawing.Size(99, 17);
            this.Sortlabel.TabIndex = 61;
            this.Sortlabel.Text = "Sory Orders By:";
            // 
            // clothingStoreDBDataSetNew
            // 
            this.clothingStoreDBDataSetNew.DataSetName = "ClothingStoreDBDataSetNew";
            this.clothingStoreDBDataSetNew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource4
            // 
            this.ordersBindingSource4.DataMember = "Orders";
            this.ordersBindingSource4.DataSource = this.clothingStoreDBDataSetNew;
            // 
            // ordersTableAdapter2
            // 
            this.ordersTableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.OrdersTableAdapter = this.ordersTableAdapter2;
            this.tableAdapterManager2.UpdateOrder = WindowsFormsApp1.ClothingStoreDBDataSetNewTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager2.UsersTableAdapter = null;
            // 
            // DeleteOrder_Button_Click
            // 
            this.DeleteOrder_Button_Click.FlatAppearance.BorderSize = 0;
            this.DeleteOrder_Button_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteOrder_Button_Click.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.DeleteOrder_Button_Click.ForeColor = System.Drawing.Color.White;
            this.DeleteOrder_Button_Click.Location = new System.Drawing.Point(84, 3);
            this.DeleteOrder_Button_Click.Name = "DeleteOrder_Button_Click";
            this.DeleteOrder_Button_Click.Size = new System.Drawing.Size(192, 78);
            this.DeleteOrder_Button_Click.TabIndex = 3;
            this.DeleteOrder_Button_Click.Text = "Delete Order";
            this.DeleteOrder_Button_Click.UseVisualStyleBackColor = true;
            this.DeleteOrder_Button_Click.Click += new System.EventHandler(this.DeleteOrder_Button_Click_Click);
            // 
            // searchDate_btn
            // 
            this.searchDate_btn.FlatAppearance.BorderSize = 0;
            this.searchDate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchDate_btn.Font = new System.Drawing.Font("Aharoni", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchDate_btn.ForeColor = System.Drawing.Color.White;
            this.searchDate_btn.Location = new System.Drawing.Point(595, 109);
            this.searchDate_btn.Name = "searchDate_btn";
            this.searchDate_btn.Size = new System.Drawing.Size(95, 22);
            this.searchDate_btn.TabIndex = 62;
            this.searchDate_btn.Text = "Search";
            this.searchDate_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchDate_btn.UseVisualStyleBackColor = true;
            this.searchDate_btn.Click += new System.EventHandler(this.SearchDate_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(424, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "To Date:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(318, 165);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(339, 20);
            this.textBoxSearch.TabIndex = 65;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // ordersCustomersNew
            // 
            this.ordersCustomersNew.DataSetName = "OrdersCustomersNew";
            this.ordersCustomersNew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource1
            // 
            this.customersBindingSource1.DataMember = "Customers";
            this.customersBindingSource1.DataSource = this.ordersCustomersNew;
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager3
            // 
            this.tableAdapterManager3.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager3.CustomersTableAdapter = this.customersTableAdapter1;
            this.tableAdapterManager3.OrdersTableAdapter = null;
            this.tableAdapterManager3.UpdateOrder = WindowsFormsApp1.OrdersCustomersNewTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Location = new System.Drawing.Point(259, 9);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(30, 13);
            this.label_Time.TabIndex = 68;
            this.label_Time.Text = "Time";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Customers_btn);
            this.panel1.Controls.Add(this.Products_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 632);
            this.panel1.TabIndex = 69;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.customer2;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(101, 230);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 77;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.products1;
            this.pictureBox1.Location = new System.Drawing.Point(101, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // Customers_btn
            // 
            this.Customers_btn.FlatAppearance.BorderSize = 0;
            this.Customers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Customers_btn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Customers_btn.ForeColor = System.Drawing.Color.White;
            this.Customers_btn.Location = new System.Drawing.Point(3, 230);
            this.Customers_btn.Name = "Customers_btn";
            this.Customers_btn.Size = new System.Drawing.Size(141, 42);
            this.Customers_btn.TabIndex = 74;
            this.Customers_btn.Text = "Customers";
            this.Customers_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Customers_btn.UseVisualStyleBackColor = true;
            this.Customers_btn.Click += new System.EventHandler(this.Customers_btn_Click);
            // 
            // Products_btn
            // 
            this.Products_btn.FlatAppearance.BorderSize = 0;
            this.Products_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Products_btn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Products_btn.ForeColor = System.Drawing.Color.White;
            this.Products_btn.Location = new System.Drawing.Point(3, 182);
            this.Products_btn.Name = "Products_btn";
            this.Products_btn.Size = new System.Drawing.Size(141, 42);
            this.Products_btn.TabIndex = 75;
            this.Products_btn.Text = "Products";
            this.Products_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Products_btn.UseVisualStyleBackColor = true;
            this.Products_btn.Click += new System.EventHandler(this.Products_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Exit_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(152, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(931, 45);
            this.panel2.TabIndex = 70;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pictureBox6.Image = global::WindowsFormsApp1.Properties.Resources.logout2;
            this.pictureBox6.Location = new System.Drawing.Point(898, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(21, 19);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 67;
            this.pictureBox6.TabStop = false;
            // 
            // Exit_btn
            // 
            this.Exit_btn.FlatAppearance.BorderSize = 0;
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Exit_btn.ForeColor = System.Drawing.Color.White;
            this.Exit_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Exit_btn.Location = new System.Drawing.Point(805, 0);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(131, 45);
            this.Exit_btn.TabIndex = 66;
            this.Exit_btn.Text = "LogOut";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel3.Controls.Add(this.SearchSales_btn);
            this.panel3.Controls.Add(this.Show_All_Orders);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(981, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(102, 587);
            this.panel3.TabIndex = 71;
            // 
            // SearchSales_btn
            // 
            this.SearchSales_btn.FlatAppearance.BorderSize = 0;
            this.SearchSales_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchSales_btn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.SearchSales_btn.ForeColor = System.Drawing.Color.White;
            this.SearchSales_btn.Location = new System.Drawing.Point(6, 137);
            this.SearchSales_btn.Name = "SearchSales_btn";
            this.SearchSales_btn.Size = new System.Drawing.Size(84, 75);
            this.SearchSales_btn.TabIndex = 80;
            this.SearchSales_btn.Text = "Most Sales By User";
            this.SearchSales_btn.UseVisualStyleBackColor = true;
            this.SearchSales_btn.Click += new System.EventHandler(this.MostSales_btn);
            // 
            // cusrtomersAndOrders
            // 
            this.cusrtomersAndOrders.DataSetName = "CusrtomersAndOrders";
            this.cusrtomersAndOrders.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource6
            // 
            this.ordersBindingSource6.DataMember = "Orders";
            this.ordersBindingSource6.DataSource = this.cusrtomersAndOrders;
            // 
            // ordersTableAdapter3
            // 
            this.ordersTableAdapter3.ClearBeforeFill = true;
            // 
            // tableAdapterManager4
            // 
            this.tableAdapterManager4.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager4.CustomersTableAdapter = null;
            this.tableAdapterManager4.OrdersTableAdapter = this.ordersTableAdapter3;
            this.tableAdapterManager4.UpdateOrder = WindowsFormsApp1.CusrtomersAndOrdersTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(231, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 72;
            this.label2.Text = "Free Search:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel4.Controls.Add(this.DeleteOrder_Button_Click);
            this.panel4.Controls.Add(this.AddOrder_Button_Click);
            this.panel4.Controls.Add(this.EditOrder_Button_Click);
            this.panel4.Location = new System.Drawing.Point(152, 530);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(828, 102);
            this.panel4.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(191, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 75;
            this.label3.Text = "Orders From Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(424, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 76;
            this.label4.Text = "To Price:";
            // 
            // FromPrice_txt
            // 
            this.FromPrice_txt.Location = new System.Drawing.Point(318, 136);
            this.FromPrice_txt.Name = "FromPrice_txt";
            this.FromPrice_txt.Size = new System.Drawing.Size(100, 20);
            this.FromPrice_txt.TabIndex = 77;
            // 
            // ToPrice_txt
            // 
            this.ToPrice_txt.Location = new System.Drawing.Point(487, 136);
            this.ToPrice_txt.Name = "ToPrice_txt";
            this.ToPrice_txt.Size = new System.Drawing.Size(102, 20);
            this.ToPrice_txt.TabIndex = 78;
            // 
            // Serch_btn
            // 
            this.Serch_btn.FlatAppearance.BorderSize = 0;
            this.Serch_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Serch_btn.Font = new System.Drawing.Font("Aharoni", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Serch_btn.ForeColor = System.Drawing.Color.White;
            this.Serch_btn.Location = new System.Drawing.Point(595, 131);
            this.Serch_btn.Name = "Serch_btn";
            this.Serch_btn.Size = new System.Drawing.Size(95, 22);
            this.Serch_btn.TabIndex = 79;
            this.Serch_btn.Text = "Search";
            this.Serch_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Serch_btn.UseVisualStyleBackColor = true;
            this.Serch_btn.Click += new System.EventHandler(this.Serch_btn_Click);
            // 
            // Search_Button
            // 
            this.Search_Button.FlatAppearance.BorderSize = 0;
            this.Search_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_Button.Font = new System.Drawing.Font("Aharoni", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Button.ForeColor = System.Drawing.Color.White;
            this.Search_Button.Location = new System.Drawing.Point(595, 82);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(95, 28);
            this.Search_Button.TabIndex = 18;
            this.Search_Button.Text = "Search";
            this.Search_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.search1;
            this.pictureBox5.Location = new System.Drawing.Point(663, 107);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 82;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.search1;
            this.pictureBox4.Location = new System.Drawing.Point(663, 132);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 81;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.search1;
            this.pictureBox3.Location = new System.Drawing.Point(663, 82);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 80;
            this.pictureBox3.TabStop = false;
            // 
            // ordersBindingSource5
            // 
            this.ordersBindingSource5.DataMember = "FK_Orders_Customers_CustomerID";
            this.ordersBindingSource5.DataSource = this.customersBindingSource;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::WindowsFormsApp1.Properties.Resources.search1;
            this.pictureBox7.Location = new System.Drawing.Point(663, 162);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(27, 20);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 83;
            this.pictureBox7.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(158, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(370, 16);
            this.label5.TabIndex = 84;
            this.label5.Text = "*Type duoble click on any row on table for display products details ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.Location = new System.Drawing.Point(153, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(827, 321);
            this.dataGridView1.TabIndex = 67;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDoubleClickEvent);
            // 
            // OrdersListScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1083, 632);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.searchDate_btn);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.Serch_btn);
            this.Controls.Add(this.ToPrice_txt);
            this.Controls.Add(this.FromPrice_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Sortlabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFields);
            this.Controls.Add(this.txtBox_Search);
            this.Controls.Add(orderDateLabel);
            this.Controls.Add(this.fromDate_txtBox);
            this.Controls.Add(this.toDate_txtBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrdersListScreen";
            this.Text = "OrdersList";
            this.Load += new System.EventHandler(this.OrdersListScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreDBDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreDBDataSet7BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerAndOrers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerAndOrersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreDBDataSetNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersCustomersNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cusrtomersAndOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource6)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button EditOrder_Button_Click;
        private System.Windows.Forms.Button AddOrder_Button_Click;
        private System.Windows.Forms.Button Show_All_Orders;
        private System.Windows.Forms.Button Search_Button;
        //private System.Windows.Forms.DataGridViewTextBoxColumn sendeingOrderDateDataGridViewTextBoxColumn;
        private ClothingStoreDBDataSet7 clothingStoreDBDataSet7;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private ClothingStoreDBDataSet7TableAdapters.OrdersTableAdapter ordersTableAdapter;
        private ClothingStoreDBDataSet7TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker fromDate_txtBox;
        private System.Windows.Forms.DateTimePicker toDate_txtBox;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private System.Windows.Forms.BindingSource ordersBindingSource2;
        private System.Windows.Forms.TextBox txtBox_Search;
        private System.Windows.Forms.BindingSource clothingStoreDBDataSet7BindingSource;
        private System.Windows.Forms.BindingSource customerAndOrersBindingSource;
        private CustomerAndOrers customerAndOrers;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private CustomerAndOrersTableAdapters.CustomersTableAdapter customersTableAdapter;
        private CustomerAndOrersTableAdapters.TableAdapterManager tableAdapterManager1;
        private CustomerAndOrersTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private System.Windows.Forms.BindingSource ordersBindingSource3;
        private System.Windows.Forms.ComboBox cbFields;
        private System.Windows.Forms.Label Sortlabel;
        private ClothingStoreDBDataSetNew clothingStoreDBDataSetNew;
        private System.Windows.Forms.BindingSource ordersBindingSource4;
        private ClothingStoreDBDataSetNewTableAdapters.OrdersTableAdapter ordersTableAdapter2;
        private ClothingStoreDBDataSetNewTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.Button DeleteOrder_Button_Click;
        private System.Windows.Forms.Button searchDate_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.BindingSource ordersBindingSource5;
        private OrdersCustomersNew ordersCustomersNew;
        private System.Windows.Forms.BindingSource customersBindingSource1;
        private OrdersCustomersNewTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private OrdersCustomersNewTableAdapters.TableAdapterManager tableAdapterManager3;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private CusrtomersAndOrders cusrtomersAndOrders;
        private System.Windows.Forms.BindingSource ordersBindingSource6;
        private CusrtomersAndOrdersTableAdapters.OrdersTableAdapter ordersTableAdapter3;
        private CusrtomersAndOrdersTableAdapters.TableAdapterManager tableAdapterManager4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Products_btn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Customers_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FromPrice_txt;
        private System.Windows.Forms.TextBox ToPrice_txt;
        private System.Windows.Forms.Button Serch_btn;
        private System.Windows.Forms.Button SearchSales_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
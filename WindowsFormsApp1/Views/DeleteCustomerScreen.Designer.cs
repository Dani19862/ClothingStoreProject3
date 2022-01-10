
namespace WindowsFormsApp1.Views
{
    partial class DeleteCustomerScreen
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
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label customerIDLabel1;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label no_HouseLabel;
            System.Windows.Forms.Label postalCodeLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label orderIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteCustomerScreen));
            this.Delete_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.customersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clothingStoreDBDataSet9 = new WindowsFormsApp1.ClothingStoreDBDataSet9();
            this.clothingStoreDBDataSet2 = new WindowsFormsApp1.ClothingStoreDBDataSet2();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new WindowsFormsApp1.ClothingStoreDBDataSet2TableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.ClothingStoreDBDataSet2TableAdapters.TableAdapterManager();
            this.customersTableAdapter1 = new WindowsFormsApp1.ClothingStoreDBDataSet9TableAdapters.CustomersTableAdapter();
            this.customerAndOrers = new WindowsFormsApp1.CustomerAndOrers();
            this.customersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter2 = new WindowsFormsApp1.CustomerAndOrersTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApp1.CustomerAndOrersTableAdapters.TableAdapterManager();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDTextBox1 = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.no_HouseTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Customers_btn = new System.Windows.Forms.Button();
            this.Orders_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            customerIDLabel = new System.Windows.Forms.Label();
            customerIDLabel1 = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            no_HouseLabel = new System.Windows.Forms.Label();
            postalCodeLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            orderIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreDBDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerAndOrers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(120, -36);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(68, 13);
            customerIDLabel.TabIndex = 3;
            customerIDLabel.Text = "Customer ID:";
            // 
            // customerIDLabel1
            // 
            customerIDLabel1.AutoSize = true;
            customerIDLabel1.Location = new System.Drawing.Point(60, -45);
            customerIDLabel1.Name = "customerIDLabel1";
            customerIDLabel1.Size = new System.Drawing.Size(68, 13);
            customerIDLabel1.TabIndex = 5;
            customerIDLabel1.Text = "Customer ID:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            firstNameLabel.ForeColor = System.Drawing.Color.White;
            firstNameLabel.Location = new System.Drawing.Point(268, 33);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(79, 17);
            firstNameLabel.TabIndex = 7;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            lastNameLabel.ForeColor = System.Drawing.Color.White;
            lastNameLabel.Location = new System.Drawing.Point(266, 59);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(81, 17);
            lastNameLabel.TabIndex = 9;
            lastNameLabel.Text = "Last Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            addressLabel.ForeColor = System.Drawing.Color.White;
            addressLabel.Location = new System.Drawing.Point(284, 85);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(61, 17);
            addressLabel.TabIndex = 11;
            addressLabel.Text = "Address:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            cityLabel.ForeColor = System.Drawing.Color.White;
            cityLabel.Location = new System.Drawing.Point(307, 111);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(37, 17);
            cityLabel.TabIndex = 13;
            cityLabel.Text = "City:";
            // 
            // no_HouseLabel
            // 
            no_HouseLabel.AutoSize = true;
            no_HouseLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            no_HouseLabel.ForeColor = System.Drawing.Color.White;
            no_HouseLabel.Location = new System.Drawing.Point(487, 111);
            no_HouseLabel.Name = "no_HouseLabel";
            no_HouseLabel.Size = new System.Drawing.Size(74, 17);
            no_HouseLabel.TabIndex = 15;
            no_HouseLabel.Text = "No House:";
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            postalCodeLabel.ForeColor = System.Drawing.Color.White;
            postalCodeLabel.Location = new System.Drawing.Point(472, 85);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new System.Drawing.Size(92, 17);
            postalCodeLabel.TabIndex = 17;
            postalCodeLabel.Text = "Postal Code:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            phoneNumberLabel.ForeColor = System.Drawing.Color.White;
            phoneNumberLabel.Location = new System.Drawing.Point(455, 59);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(109, 17);
            phoneNumberLabel.TabIndex = 19;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            orderIDLabel.ForeColor = System.Drawing.Color.White;
            orderIDLabel.Location = new System.Drawing.Point(499, 33);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new System.Drawing.Size(65, 17);
            orderIDLabel.TabIndex = 21;
            orderIDLabel.Text = "Order ID:";
            // 
            // Delete_btn
            // 
            this.Delete_btn.FlatAppearance.BorderSize = 0;
            this.Delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_btn.Font = new System.Drawing.Font("Aharoni", 14.25F, System.Drawing.FontStyle.Bold);
            this.Delete_btn.ForeColor = System.Drawing.Color.White;
            this.Delete_btn.Location = new System.Drawing.Point(497, 456);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(170, 75);
            this.Delete_btn.TabIndex = 0;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.FlatAppearance.BorderSize = 0;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Font = new System.Drawing.Font("Aharoni", 14.25F, System.Drawing.FontStyle.Bold);
            this.back_btn.ForeColor = System.Drawing.Color.White;
            this.back_btn.Location = new System.Drawing.Point(279, 455);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(163, 76);
            this.back_btn.TabIndex = 1;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // customersBindingSource1
            // 
            this.customersBindingSource1.DataMember = "Customers";
            this.customersBindingSource1.DataSource = this.clothingStoreDBDataSet9;
            // 
            // clothingStoreDBDataSet9
            // 
            this.clothingStoreDBDataSet9.DataSetName = "ClothingStoreDBDataSet9";
            this.clothingStoreDBDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clothingStoreDBDataSet2
            // 
            this.clothingStoreDBDataSet2.DataSetName = "ClothingStoreDBDataSet2";
            this.clothingStoreDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.clothingStoreDBDataSet2;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.ClothingStoreDBDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // customerAndOrers
            // 
            this.customerAndOrers.DataSetName = "CustomerAndOrers";
            this.customerAndOrers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource2
            // 
            this.customersBindingSource2.DataMember = "Customers";
            this.customersBindingSource2.DataSource = this.customerAndOrers;
            // 
            // customersTableAdapter2
            // 
            this.customersTableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CustomersTableAdapter = this.customersTableAdapter2;
            this.tableAdapterManager1.OrdersTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApp1.CustomerAndOrersTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource2, "CustomerID", true));
            this.customerIDTextBox.Location = new System.Drawing.Point(207, -39);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerIDTextBox.TabIndex = 4;
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.AutoGenerateColumns = false;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.customersDataGridView.DataSource = this.customersBindingSource2;
            this.customersDataGridView.Location = new System.Drawing.Point(146, 151);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.Size = new System.Drawing.Size(700, 275);
            this.customersDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CustomerID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn4.HeaderText = "Address";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn5.HeaderText = "City";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "No_House";
            this.dataGridViewTextBoxColumn6.HeaderText = "No_House";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PostalCode";
            this.dataGridViewTextBoxColumn7.HeaderText = "PostalCode";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn8.HeaderText = "PhoneNumber";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "OrderID";
            this.dataGridViewTextBoxColumn9.HeaderText = "OrderID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // customerIDTextBox1
            // 
            this.customerIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource2, "CustomerID", true));
            this.customerIDTextBox1.Location = new System.Drawing.Point(147, -48);
            this.customerIDTextBox1.Name = "customerIDTextBox1";
            this.customerIDTextBox1.Size = new System.Drawing.Size(100, 20);
            this.customerIDTextBox1.TabIndex = 6;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource2, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(349, 30);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 8;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource2, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(349, 56);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 10;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource2, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(349, 82);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 12;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource2, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(349, 108);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 14;
            // 
            // no_HouseTextBox
            // 
            this.no_HouseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource2, "No_House", true));
            this.no_HouseTextBox.Location = new System.Drawing.Point(567, 108);
            this.no_HouseTextBox.Name = "no_HouseTextBox";
            this.no_HouseTextBox.Size = new System.Drawing.Size(100, 20);
            this.no_HouseTextBox.TabIndex = 16;
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource2, "PostalCode", true));
            this.postalCodeTextBox.Location = new System.Drawing.Point(567, 82);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.postalCodeTextBox.TabIndex = 18;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource2, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(567, 56);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberTextBox.TabIndex = 20;
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource2, "OrderID", true));
            this.orderIDTextBox.Location = new System.Drawing.Point(567, 30);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.orderIDTextBox.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Customers_btn);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Orders_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 553);
            this.panel1.TabIndex = 23;
            // 
            // Customers_btn
            // 
            this.Customers_btn.FlatAppearance.BorderSize = 0;
            this.Customers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Customers_btn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Customers_btn.ForeColor = System.Drawing.Color.White;
            this.Customers_btn.Location = new System.Drawing.Point(-4, 177);
            this.Customers_btn.Name = "Customers_btn";
            this.Customers_btn.Size = new System.Drawing.Size(141, 42);
            this.Customers_btn.TabIndex = 86;
            this.Customers_btn.Text = "Customers";
            this.Customers_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Customers_btn.UseVisualStyleBackColor = true;
            this.Customers_btn.Click += new System.EventHandler(this.Customers_btn_Click);
            // 
            // Orders_btn
            // 
            this.Orders_btn.FlatAppearance.BorderSize = 0;
            this.Orders_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Orders_btn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Orders_btn.ForeColor = System.Drawing.Color.White;
            this.Orders_btn.Location = new System.Drawing.Point(-3, 129);
            this.Orders_btn.Name = "Orders_btn";
            this.Orders_btn.Size = new System.Drawing.Size(140, 42);
            this.Orders_btn.TabIndex = 84;
            this.Orders_btn.Text = "Orders";
            this.Orders_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Orders_btn.UseVisualStyleBackColor = true;
            this.Orders_btn.Click += new System.EventHandler(this.Orders_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.FlatAppearance.BorderSize = 0;
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Exit_btn.ForeColor = System.Drawing.Color.White;
            this.Exit_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Exit_btn.Location = new System.Drawing.Point(727, 0);
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
            this.pictureBox6.Location = new System.Drawing.Point(820, 9);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(23, 24);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 86;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.customer2;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(84, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.ordersIcon;
            this.pictureBox2.Location = new System.Drawing.Point(85, 129);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 85;
            this.pictureBox2.TabStop = false;
            // 
            // DeleteCustomerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(858, 553);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(customerIDLabel1);
            this.Controls.Add(this.customerIDTextBox1);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(no_HouseLabel);
            this.Controls.Add(this.no_HouseTextBox);
            this.Controls.Add(postalCodeLabel);
            this.Controls.Add(this.postalCodeTextBox);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(orderIDLabel);
            this.Controls.Add(this.orderIDTextBox);
            this.Controls.Add(this.customersDataGridView);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.Delete_btn);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteCustomerScreen";
            this.Text = "DeleteCusromerScreen";
            this.Load += new System.EventHandler(this.DeleteCusromerScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreDBDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerAndOrers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button back_btn;
        private ClothingStoreDBDataSet2 clothingStoreDBDataSet2;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private ClothingStoreDBDataSet2TableAdapters.CustomersTableAdapter customersTableAdapter;
        private ClothingStoreDBDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private ClothingStoreDBDataSet9 clothingStoreDBDataSet9;
        private System.Windows.Forms.BindingSource customersBindingSource1;
        private ClothingStoreDBDataSet9TableAdapters.CustomersTableAdapter customersTableAdapter1;
        private CustomerAndOrers customerAndOrers;
        private System.Windows.Forms.BindingSource customersBindingSource2;
        private CustomerAndOrersTableAdapters.CustomersTableAdapter customersTableAdapter2;
        private CustomerAndOrersTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox customerIDTextBox1;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox no_HouseTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox orderIDTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Customers_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Orders_btn;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button Exit_btn;
    }
}
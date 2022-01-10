
namespace WindowsFormsApp1.Views
{
    partial class CustomersListScreen
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
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label no_HouseLabel;
            System.Windows.Forms.Label postalCodeLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label orderIDLabel;
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Customers_List_label = new System.Windows.Forms.Label();
            this.DeleteCustomer_Button = new System.Windows.Forms.Button();
            this.EditCustomer_Button_Click = new System.Windows.Forms.Button();
            this.Clera_Button_Click = new System.Windows.Forms.Button();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clothingStoreDBDataSet2 = new WindowsFormsApp1.ClothingStoreDBDataSet2();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.Show_All_Customer_Button = new System.Windows.Forms.Button();
            this.clothingStoreDBDataSet = new WindowsFormsApp1.ClothingStoreDBDataSet();
            this.clothingStoreDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new WindowsFormsApp1.ClothingStoreDBDataSet2TableAdapters.CustomersTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerAndOrersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerAndOrers = new WindowsFormsApp1.CustomerAndOrers();
            this.customersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter1 = new WindowsFormsApp1.CustomerAndOrersTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.CustomerAndOrersTableAdapters.TableAdapterManager();
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
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.no_HouseTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Orders_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Products_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            customerIDLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            no_HouseLabel = new System.Windows.Forms.Label();
            postalCodeLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            orderIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerAndOrersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerAndOrers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            customerIDLabel.ForeColor = System.Drawing.Color.White;
            customerIDLabel.Location = new System.Drawing.Point(366, 101);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(92, 17);
            customerIDLabel.TabIndex = 64;
            customerIDLabel.Text = "Customer ID:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            firstNameLabel.ForeColor = System.Drawing.Color.White;
            firstNameLabel.Location = new System.Drawing.Point(379, 127);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(79, 17);
            firstNameLabel.TabIndex = 66;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            lastNameLabel.ForeColor = System.Drawing.Color.White;
            lastNameLabel.Location = new System.Drawing.Point(377, 154);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(81, 17);
            lastNameLabel.TabIndex = 68;
            lastNameLabel.Text = "Last Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            addressLabel.ForeColor = System.Drawing.Color.White;
            addressLabel.Location = new System.Drawing.Point(397, 184);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(61, 17);
            addressLabel.TabIndex = 70;
            addressLabel.Text = "Address:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            cityLabel.ForeColor = System.Drawing.Color.White;
            cityLabel.Location = new System.Drawing.Point(417, 210);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(37, 17);
            cityLabel.TabIndex = 72;
            cityLabel.Text = "City:";
            // 
            // no_HouseLabel
            // 
            no_HouseLabel.AutoSize = true;
            no_HouseLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            no_HouseLabel.ForeColor = System.Drawing.Color.White;
            no_HouseLabel.Location = new System.Drawing.Point(183, 101);
            no_HouseLabel.Name = "no_HouseLabel";
            no_HouseLabel.Size = new System.Drawing.Size(74, 17);
            no_HouseLabel.TabIndex = 74;
            no_HouseLabel.Text = "No House:";
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            postalCodeLabel.ForeColor = System.Drawing.Color.White;
            postalCodeLabel.Location = new System.Drawing.Point(165, 129);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new System.Drawing.Size(92, 17);
            postalCodeLabel.TabIndex = 76;
            postalCodeLabel.Text = "Postal Code:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            phoneNumberLabel.ForeColor = System.Drawing.Color.White;
            phoneNumberLabel.Location = new System.Drawing.Point(148, 152);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(109, 17);
            phoneNumberLabel.TabIndex = 78;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            orderIDLabel.ForeColor = System.Drawing.Color.White;
            orderIDLabel.Location = new System.Drawing.Point(189, 182);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new System.Drawing.Size(65, 17);
            orderIDLabel.TabIndex = 80;
            orderIDLabel.Text = "Order ID:";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "dab";
            // 
            // Customers_List_label
            // 
            this.Customers_List_label.AutoSize = true;
            this.Customers_List_label.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Customers_List_label.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customers_List_label.ForeColor = System.Drawing.Color.White;
            this.Customers_List_label.Location = new System.Drawing.Point(372, 9);
            this.Customers_List_label.Name = "Customers_List_label";
            this.Customers_List_label.Size = new System.Drawing.Size(220, 47);
            this.Customers_List_label.TabIndex = 29;
            this.Customers_List_label.Text = "Customers List";
            // 
            // DeleteCustomer_Button
            // 
            this.DeleteCustomer_Button.FlatAppearance.BorderSize = 0;
            this.DeleteCustomer_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteCustomer_Button.Font = new System.Drawing.Font("Aharoni", 14.25F, System.Drawing.FontStyle.Bold);
            this.DeleteCustomer_Button.ForeColor = System.Drawing.Color.White;
            this.DeleteCustomer_Button.Location = new System.Drawing.Point(499, 528);
            this.DeleteCustomer_Button.Name = "DeleteCustomer_Button";
            this.DeleteCustomer_Button.Size = new System.Drawing.Size(147, 59);
            this.DeleteCustomer_Button.TabIndex = 34;
            this.DeleteCustomer_Button.Text = "Delete Customer";
            this.DeleteCustomer_Button.UseVisualStyleBackColor = true;
            this.DeleteCustomer_Button.Click += new System.EventHandler(this.DeleteCustomer_Button_Click);
            // 
            // EditCustomer_Button_Click
            // 
            this.EditCustomer_Button_Click.FlatAppearance.BorderSize = 0;
            this.EditCustomer_Button_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditCustomer_Button_Click.Font = new System.Drawing.Font("Aharoni", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.EditCustomer_Button_Click.ForeColor = System.Drawing.Color.White;
            this.EditCustomer_Button_Click.Location = new System.Drawing.Point(332, 528);
            this.EditCustomer_Button_Click.Name = "EditCustomer_Button_Click";
            this.EditCustomer_Button_Click.Size = new System.Drawing.Size(126, 59);
            this.EditCustomer_Button_Click.TabIndex = 32;
            this.EditCustomer_Button_Click.Text = "Edit Customer";
            this.EditCustomer_Button_Click.UseVisualStyleBackColor = true;
            this.EditCustomer_Button_Click.Click += new System.EventHandler(this.EditCustomer_Button_Click_Click);
            // 
            // Clera_Button_Click
            // 
            this.Clera_Button_Click.FlatAppearance.BorderSize = 0;
            this.Clera_Button_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clera_Button_Click.Font = new System.Drawing.Font("Aharoni", 14.25F, System.Drawing.FontStyle.Bold);
            this.Clera_Button_Click.ForeColor = System.Drawing.Color.White;
            this.Clera_Button_Click.Location = new System.Drawing.Point(747, 69);
            this.Clera_Button_Click.Name = "Clera_Button_Click";
            this.Clera_Button_Click.Size = new System.Drawing.Size(126, 46);
            this.Clera_Button_Click.TabIndex = 30;
            this.Clera_Button_Click.Text = "Clear";
            this.Clera_Button_Click.UseVisualStyleBackColor = true;
            this.Clera_Button_Click.Click += new System.EventHandler(this.Clera_Button_Click_Click);
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.clothingStoreDBDataSet2;
            // 
            // clothingStoreDBDataSet2
            // 
            this.clothingStoreDBDataSet2.DataSetName = "ClothingStoreDBDataSet2";
            this.clothingStoreDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Show_All_Customer_Button
            // 
            this.Show_All_Customer_Button.FlatAppearance.BorderSize = 0;
            this.Show_All_Customer_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Show_All_Customer_Button.Font = new System.Drawing.Font("Aharoni", 14.25F, System.Drawing.FontStyle.Bold);
            this.Show_All_Customer_Button.ForeColor = System.Drawing.Color.White;
            this.Show_All_Customer_Button.Location = new System.Drawing.Point(748, 124);
            this.Show_All_Customer_Button.Name = "Show_All_Customer_Button";
            this.Show_All_Customer_Button.Size = new System.Drawing.Size(126, 47);
            this.Show_All_Customer_Button.TabIndex = 43;
            this.Show_All_Customer_Button.Text = "Show All Customers";
            this.Show_All_Customer_Button.UseVisualStyleBackColor = true;
            this.Show_All_Customer_Button.Click += new System.EventHandler(this.Show_All_Customer_Button_Click);
            // 
            // clothingStoreDBDataSet
            // 
            this.clothingStoreDBDataSet.DataSetName = "ClothingStoreDBDataSet";
            this.clothingStoreDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clothingStoreDBDataSetBindingSource
            // 
            this.clothingStoreDBDataSetBindingSource.DataSource = this.clothingStoreDBDataSet;
            this.clothingStoreDBDataSetBindingSource.Position = 0;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.customerAndOrersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(138, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(758, 261);
            this.dataGridView1.TabIndex = 45;
            // 
            // customerAndOrersBindingSource
            // 
            this.customerAndOrersBindingSource.DataSource = this.customerAndOrers;
            this.customerAndOrersBindingSource.Position = 0;
            // 
            // customerAndOrers
            // 
            this.customerAndOrers.DataSetName = "CustomerAndOrers";
            this.customerAndOrers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource1
            // 
            this.customersBindingSource1.DataMember = "Customers";
            this.customersBindingSource1.DataSource = this.customerAndOrers;
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter1;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.CustomerAndOrersTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.AllowUserToDeleteRows = false;
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
            this.customersDataGridView.DataSource = this.customersBindingSource1;
            this.customersDataGridView.Location = new System.Drawing.Point(138, 261);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.ReadOnly = true;
            this.customersDataGridView.Size = new System.Drawing.Size(758, 261);
            this.customersDataGridView.TabIndex = 64;
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
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn4.HeaderText = "Address";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn5.HeaderText = "City";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "No_House";
            this.dataGridViewTextBoxColumn6.HeaderText = "No_House";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PostalCode";
            this.dataGridViewTextBoxColumn7.HeaderText = "PostalCode";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn8.HeaderText = "PhoneNumber";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "OrderID";
            this.dataGridViewTextBoxColumn9.HeaderText = "OrderID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "CustomerID", true));
            this.customerIDTextBox.Location = new System.Drawing.Point(460, 98);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerIDTextBox.TabIndex = 65;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(460, 126);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 67;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(460, 153);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 69;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(460, 180);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 71;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(460, 209);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 73;
            // 
            // no_HouseTextBox
            // 
            this.no_HouseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "No_House", true));
            this.no_HouseTextBox.Location = new System.Drawing.Point(260, 98);
            this.no_HouseTextBox.Name = "no_HouseTextBox";
            this.no_HouseTextBox.Size = new System.Drawing.Size(100, 20);
            this.no_HouseTextBox.TabIndex = 75;
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "PostalCode", true));
            this.postalCodeTextBox.Location = new System.Drawing.Point(260, 126);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.postalCodeTextBox.TabIndex = 77;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(260, 153);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberTextBox.TabIndex = 79;
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "OrderID", true));
            this.orderIDTextBox.Location = new System.Drawing.Point(260, 182);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.orderIDTextBox.TabIndex = 81;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Orders_btn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Products_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 629);
            this.panel1.TabIndex = 82;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.ordersIcon;
            this.pictureBox2.Location = new System.Drawing.Point(77, 182);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 79;
            this.pictureBox2.TabStop = false;
            // 
            // Orders_btn
            // 
            this.Orders_btn.FlatAppearance.BorderSize = 0;
            this.Orders_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Orders_btn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Orders_btn.ForeColor = System.Drawing.Color.White;
            this.Orders_btn.Location = new System.Drawing.Point(0, 182);
            this.Orders_btn.Name = "Orders_btn";
            this.Orders_btn.Size = new System.Drawing.Size(132, 42);
            this.Orders_btn.TabIndex = 78;
            this.Orders_btn.Text = "Orders";
            this.Orders_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Orders_btn.UseVisualStyleBackColor = true;
            this.Orders_btn.Click += new System.EventHandler(this.Orders_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.products1;
            this.pictureBox1.Location = new System.Drawing.Point(77, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // Products_btn
            // 
            this.Products_btn.FlatAppearance.BorderSize = 0;
            this.Products_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Products_btn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Products_btn.ForeColor = System.Drawing.Color.White;
            this.Products_btn.Location = new System.Drawing.Point(0, 131);
            this.Products_btn.Name = "Products_btn";
            this.Products_btn.Size = new System.Drawing.Size(132, 42);
            this.Products_btn.TabIndex = 76;
            this.Products_btn.Text = "Products";
            this.Products_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Products_btn.UseVisualStyleBackColor = true;
            this.Products_btn.Click += new System.EventHandler(this.Products_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.FlatAppearance.BorderSize = 0;
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Exit_btn.ForeColor = System.Drawing.Color.White;
            this.Exit_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Exit_btn.Location = new System.Drawing.Point(780, 0);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(131, 45);
            this.Exit_btn.TabIndex = 83;
            this.Exit_btn.Text = "LogOut";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pictureBox6.Image = global::WindowsFormsApp1.Properties.Resources.logout2;
            this.pictureBox6.Location = new System.Drawing.Point(873, 9);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(23, 24);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 84;
            this.pictureBox6.TabStop = false;
            // 
            // CustomersListScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(908, 629);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDTextBox);
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Show_All_Customer_Button);
            this.Controls.Add(this.DeleteCustomer_Button);
            this.Controls.Add(this.EditCustomer_Button_Click);
            this.Controls.Add(this.Clera_Button_Click);
            this.Controls.Add(this.Customers_List_label);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomersListScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers List";
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerAndOrersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerAndOrers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label Customers_List_label;
        private System.Windows.Forms.Button DeleteCustomer_Button;
        private System.Windows.Forms.Button EditCustomer_Button_Click;
        private System.Windows.Forms.Button Clera_Button_Click;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private System.Windows.Forms.Button Show_All_Customer_Button;
        private ClothingStoreDBDataSet clothingStoreDBDataSet;
        private System.Windows.Forms.BindingSource clothingStoreDBDataSetBindingSource;
        private ClothingStoreDBDataSet2 clothingStoreDBDataSet2;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private ClothingStoreDBDataSet2TableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource customerAndOrersBindingSource;
        private CustomerAndOrers customerAndOrers;
        private System.Windows.Forms.BindingSource customersBindingSource1;
        private CustomerAndOrersTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private CustomerAndOrersTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox no_HouseTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox orderIDTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Products_btn;
        private System.Windows.Forms.Button Orders_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}
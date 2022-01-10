
namespace WindowsFormsApp1.Views
{
    partial class ProductsScreen
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
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label product_TypeLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label sizeLabel;
            System.Windows.Forms.Label quanitity_In_InventoryLabel;
            System.Windows.Forms.Label unit_PriceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsScreen));
            this.clothingStoreDBDataSet12ProductsN = new WindowsFormsApp1.ClothingStoreDBDataSet12ProductsN();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new WindowsFormsApp1.ClothingStoreDBDataSet12ProductsNTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.ClothingStoreDBDataSet12ProductsNTableAdapters.TableAdapterManager();
            this.productsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.product_TypeTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.quanitity_In_InventoryTextBox = new System.Windows.Forms.TextBox();
            this.unit_PriceTextBox = new System.Windows.Forms.TextBox();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Edit_Button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Customers_btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Orders_btn = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Logout_btn = new System.Windows.Forms.Button();
            productIDLabel = new System.Windows.Forms.Label();
            product_TypeLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            sizeLabel = new System.Windows.Forms.Label();
            quanitity_In_InventoryLabel = new System.Windows.Forms.Label();
            unit_PriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreDBDataSet12ProductsN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).BeginInit();
            this.productsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            productIDLabel.ForeColor = System.Drawing.Color.White;
            productIDLabel.Location = new System.Drawing.Point(203, 61);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(80, 17);
            productIDLabel.TabIndex = 2;
            productIDLabel.Text = "Product ID:";
            // 
            // product_TypeLabel
            // 
            product_TypeLabel.AutoSize = true;
            product_TypeLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            product_TypeLabel.ForeColor = System.Drawing.Color.White;
            product_TypeLabel.Location = new System.Drawing.Point(188, 90);
            product_TypeLabel.Name = "product_TypeLabel";
            product_TypeLabel.Size = new System.Drawing.Size(95, 17);
            product_TypeLabel.TabIndex = 4;
            product_TypeLabel.Text = "Product Type:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            colorLabel.ForeColor = System.Drawing.Color.White;
            colorLabel.Location = new System.Drawing.Point(235, 113);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(48, 17);
            colorLabel.TabIndex = 6;
            colorLabel.Text = "Color:";
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            sizeLabel.ForeColor = System.Drawing.Color.White;
            sizeLabel.Location = new System.Drawing.Point(527, 61);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new System.Drawing.Size(35, 17);
            sizeLabel.TabIndex = 8;
            sizeLabel.Text = "Size:";
            // 
            // quanitity_In_InventoryLabel
            // 
            quanitity_In_InventoryLabel.AutoSize = true;
            quanitity_In_InventoryLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            quanitity_In_InventoryLabel.ForeColor = System.Drawing.Color.White;
            quanitity_In_InventoryLabel.Location = new System.Drawing.Point(414, 87);
            quanitity_In_InventoryLabel.Name = "quanitity_In_InventoryLabel";
            quanitity_In_InventoryLabel.Size = new System.Drawing.Size(148, 17);
            quanitity_In_InventoryLabel.TabIndex = 10;
            quanitity_In_InventoryLabel.Text = "Quanitity In Inventory:";
            // 
            // unit_PriceLabel
            // 
            unit_PriceLabel.AutoSize = true;
            unit_PriceLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            unit_PriceLabel.ForeColor = System.Drawing.Color.White;
            unit_PriceLabel.Location = new System.Drawing.Point(491, 111);
            unit_PriceLabel.Name = "unit_PriceLabel";
            unit_PriceLabel.Size = new System.Drawing.Size(71, 17);
            unit_PriceLabel.TabIndex = 12;
            unit_PriceLabel.Text = "Unit Price:";
            // 
            // clothingStoreDBDataSet12ProductsN
            // 
            this.clothingStoreDBDataSet12ProductsN.DataSetName = "ClothingStoreDBDataSet12ProductsN";
            this.clothingStoreDBDataSet12ProductsN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.clothingStoreDBDataSet12ProductsN;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.ClothingStoreDBDataSet12ProductsNTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productsBindingNavigator
            // 
            this.productsBindingNavigator.AddNewItem = null;
            this.productsBindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.productsBindingNavigator.BindingSource = this.productsBindingSource;
            this.productsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productsBindingNavigator.DeleteItem = null;
            this.productsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.productsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productsBindingNavigator.Name = "productsBindingNavigator";
            this.productsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productsBindingNavigator.Size = new System.Drawing.Size(806, 25);
            this.productsBindingNavigator.TabIndex = 0;
            this.productsBindingNavigator.Text = "bindingNavigator1";
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
            // productsDataGridView
            // 
            this.productsDataGridView.AllowUserToAddRows = false;
            this.productsDataGridView.AllowUserToDeleteRows = false;
            this.productsDataGridView.AllowUserToOrderColumns = true;
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.productsDataGridView.DataSource = this.productsBindingSource;
            this.productsDataGridView.Location = new System.Drawing.Point(140, 181);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.ReadOnly = true;
            this.productsDataGridView.Size = new System.Drawing.Size(659, 220);
            this.productsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Product Type";
            this.dataGridViewTextBoxColumn2.HeaderText = "Product Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Color";
            this.dataGridViewTextBoxColumn3.HeaderText = "Color";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Size";
            this.dataGridViewTextBoxColumn4.HeaderText = "Size";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Quanitity In Inventory";
            this.dataGridViewTextBoxColumn5.HeaderText = "Quanitity In Inventory";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Unit Price";
            this.dataGridViewTextBoxColumn6.HeaderText = "Unit Price";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductID", true));
            this.productIDTextBox.Location = new System.Drawing.Point(289, 58);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.productIDTextBox.TabIndex = 3;
            // 
            // product_TypeTextBox
            // 
            this.product_TypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Product Type", true));
            this.product_TypeTextBox.Location = new System.Drawing.Point(289, 84);
            this.product_TypeTextBox.Name = "product_TypeTextBox";
            this.product_TypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.product_TypeTextBox.TabIndex = 5;
            // 
            // colorTextBox
            // 
            this.colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Color", true));
            this.colorTextBox.Location = new System.Drawing.Point(289, 110);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(100, 20);
            this.colorTextBox.TabIndex = 7;
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Size", true));
            this.sizeTextBox.Location = new System.Drawing.Point(568, 58);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.sizeTextBox.TabIndex = 9;
            // 
            // quanitity_In_InventoryTextBox
            // 
            this.quanitity_In_InventoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Quanitity In Inventory", true));
            this.quanitity_In_InventoryTextBox.Location = new System.Drawing.Point(568, 84);
            this.quanitity_In_InventoryTextBox.Name = "quanitity_In_InventoryTextBox";
            this.quanitity_In_InventoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.quanitity_In_InventoryTextBox.TabIndex = 11;
            // 
            // unit_PriceTextBox
            // 
            this.unit_PriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Unit Price", true));
            this.unit_PriceTextBox.Location = new System.Drawing.Point(568, 110);
            this.unit_PriceTextBox.Name = "unit_PriceTextBox";
            this.unit_PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.unit_PriceTextBox.TabIndex = 13;
            // 
            // Delete_button
            // 
            this.Delete_button.FlatAppearance.BorderSize = 0;
            this.Delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_button.Font = new System.Drawing.Font("Aharoni", 14.25F, System.Drawing.FontStyle.Bold);
            this.Delete_button.ForeColor = System.Drawing.Color.White;
            this.Delete_button.Location = new System.Drawing.Point(180, 428);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(159, 67);
            this.Delete_button.TabIndex = 19;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Edit_Button
            // 
            this.Edit_Button.FlatAppearance.BorderSize = 0;
            this.Edit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_Button.Font = new System.Drawing.Font("Aharoni", 14.25F, System.Drawing.FontStyle.Bold);
            this.Edit_Button.ForeColor = System.Drawing.Color.White;
            this.Edit_Button.Location = new System.Drawing.Point(345, 428);
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.Size = new System.Drawing.Size(146, 67);
            this.Edit_Button.TabIndex = 18;
            this.Edit_Button.Text = "Edit";
            this.Edit_Button.UseVisualStyleBackColor = true;
            this.Edit_Button.Click += new System.EventHandler(this.Edit_Button_Click);
            // 
            // Add_button
            // 
            this.Add_button.FlatAppearance.BorderSize = 0;
            this.Add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_button.Font = new System.Drawing.Font("Aharoni", 14.25F, System.Drawing.FontStyle.Bold);
            this.Add_button.ForeColor = System.Drawing.Color.White;
            this.Add_button.Location = new System.Drawing.Point(472, 428);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(154, 67);
            this.Add_button.TabIndex = 17;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Customers_btn);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Orders_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 498);
            this.panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.customer2;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(93, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // Customers_btn
            // 
            this.Customers_btn.FlatAppearance.BorderSize = 0;
            this.Customers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Customers_btn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Customers_btn.ForeColor = System.Drawing.Color.White;
            this.Customers_btn.Location = new System.Drawing.Point(1, 187);
            this.Customers_btn.Name = "Customers_btn";
            this.Customers_btn.Size = new System.Drawing.Size(128, 42);
            this.Customers_btn.TabIndex = 82;
            this.Customers_btn.Text = "Customers";
            this.Customers_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Customers_btn.UseVisualStyleBackColor = true;
            this.Customers_btn.Click += new System.EventHandler(this.Customers_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.ordersIcon;
            this.pictureBox2.Location = new System.Drawing.Point(93, 144);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 81;
            this.pictureBox2.TabStop = false;
            // 
            // Orders_btn
            // 
            this.Orders_btn.FlatAppearance.BorderSize = 0;
            this.Orders_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Orders_btn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.Orders_btn.ForeColor = System.Drawing.Color.White;
            this.Orders_btn.Location = new System.Drawing.Point(2, 135);
            this.Orders_btn.Name = "Orders_btn";
            this.Orders_btn.Size = new System.Drawing.Size(128, 45);
            this.Orders_btn.TabIndex = 80;
            this.Orders_btn.Text = "Orders";
            this.Orders_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Orders_btn.UseVisualStyleBackColor = true;
            this.Orders_btn.Click += new System.EventHandler(this.Orders_btn_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pictureBox6.Image = global::WindowsFormsApp1.Properties.Resources.logout2;
            this.pictureBox6.Location = new System.Drawing.Point(768, 9);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(23, 24);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 92;
            this.pictureBox6.TabStop = false;
            // 
            // Logout_btn
            // 
            this.Logout_btn.FlatAppearance.BorderSize = 0;
            this.Logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Logout_btn.ForeColor = System.Drawing.Color.White;
            this.Logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Logout_btn.Location = new System.Drawing.Point(675, 0);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(131, 45);
            this.Logout_btn.TabIndex = 91;
            this.Logout_btn.Text = "LogOut";
            this.Logout_btn.UseVisualStyleBackColor = true;
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // ProductsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(806, 523);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.Logout_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Edit_Button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(productIDLabel);
            this.Controls.Add(this.productIDTextBox);
            this.Controls.Add(product_TypeLabel);
            this.Controls.Add(this.product_TypeTextBox);
            this.Controls.Add(colorLabel);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(sizeLabel);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(quanitity_In_InventoryLabel);
            this.Controls.Add(this.quanitity_In_InventoryTextBox);
            this.Controls.Add(unit_PriceLabel);
            this.Controls.Add(this.unit_PriceTextBox);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.productsBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductsScreen";
            this.Text = "ProductsScreen";
            this.Load += new System.EventHandler(this.ProductsScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clothingStoreDBDataSet12ProductsN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).EndInit();
            this.productsBindingNavigator.ResumeLayout(false);
            this.productsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClothingStoreDBDataSet12ProductsN clothingStoreDBDataSet12ProductsN;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private ClothingStoreDBDataSet12ProductsNTableAdapters.ProductsTableAdapter productsTableAdapter;
        private ClothingStoreDBDataSet12ProductsNTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.TextBox product_TypeTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.TextBox quanitity_In_InventoryTextBox;
        private System.Windows.Forms.TextBox unit_PriceTextBox;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Edit_Button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Customers_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Orders_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button Logout_btn;
    }
}

namespace WindowsFormsApp1.Views
{
    partial class CustomersAndOrdersScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersAndOrdersScreen));
            this.CusromersClickButton = new System.Windows.Forms.Button();
            this.OrdersClickButtton = new System.Windows.Forms.Button();
            this.Products_btn = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // CusromersClickButton
            // 
            this.CusromersClickButton.FlatAppearance.BorderSize = 0;
            this.CusromersClickButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CusromersClickButton.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CusromersClickButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CusromersClickButton.Location = new System.Drawing.Point(176, 151);
            this.CusromersClickButton.Name = "CusromersClickButton";
            this.CusromersClickButton.Size = new System.Drawing.Size(415, 83);
            this.CusromersClickButton.TabIndex = 0;
            this.CusromersClickButton.Text = "Customers";
            this.CusromersClickButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CusromersClickButton.UseVisualStyleBackColor = true;
            this.CusromersClickButton.Click += new System.EventHandler(this.CusromersClickButton_Click);
            // 
            // OrdersClickButtton
            // 
            this.OrdersClickButtton.FlatAppearance.BorderSize = 0;
            this.OrdersClickButtton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdersClickButtton.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdersClickButtton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrdersClickButtton.Location = new System.Drawing.Point(176, 274);
            this.OrdersClickButtton.Name = "OrdersClickButtton";
            this.OrdersClickButtton.Size = new System.Drawing.Size(415, 81);
            this.OrdersClickButtton.TabIndex = 1;
            this.OrdersClickButtton.Text = "Orders";
            this.OrdersClickButtton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OrdersClickButtton.UseVisualStyleBackColor = true;
            this.OrdersClickButtton.Click += new System.EventHandler(this.OrdersClickButtton_Click);
            // 
            // Products_btn
            // 
            this.Products_btn.FlatAppearance.BorderSize = 0;
            this.Products_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Products_btn.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Products_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Products_btn.Location = new System.Drawing.Point(176, 391);
            this.Products_btn.Name = "Products_btn";
            this.Products_btn.Size = new System.Drawing.Size(415, 81);
            this.Products_btn.TabIndex = 2;
            this.Products_btn.Text = "Products";
            this.Products_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Products_btn.UseVisualStyleBackColor = true;
            this.Products_btn.Click += new System.EventHandler(this.Products_btn_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.Color.White;
            this.exit_button.Location = new System.Drawing.Point(762, 0);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(40, 40);
            this.exit_button.TabIndex = 37;
            this.exit_button.Text = "X";
            this.exit_button.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 58);
            this.label1.TabIndex = 38;
            this.label1.Text = "Main Screen";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.products1;
            this.pictureBox1.Location = new System.Drawing.Point(457, 391);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.ordersIcon;
            this.pictureBox2.Location = new System.Drawing.Point(457, 274);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 80;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.customer2;
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(457, 151);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(134, 83);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 81;
            this.pictureBox3.TabStop = false;
            // 
            // CustomersAndOrdersScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(801, 586);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.Products_btn);
            this.Controls.Add(this.OrdersClickButtton);
            this.Controls.Add(this.CusromersClickButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomersAndOrdersScreen";
            this.Text = "CustomersAndOrdersScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CusromersClickButton;
        private System.Windows.Forms.Button OrdersClickButtton;
        private System.Windows.Forms.Button Products_btn;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
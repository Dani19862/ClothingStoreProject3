
namespace WindowsFormsApp1.Views
{
    partial class LoginScreen
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
            this.EntertButton_Click = new System.Windows.Forms.Button();
            this.LabelEnteyUserAndPass = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_Img = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit_button = new System.Windows.Forms.Button();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ForgotPass_lable = new System.Windows.Forms.LinkLabel();
            this.panel_Img.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // EntertButton_Click
            // 
            this.EntertButton_Click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.EntertButton_Click.FlatAppearance.BorderSize = 0;
            this.EntertButton_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EntertButton_Click.Font = new System.Drawing.Font("Aharoni", 26.25F, System.Drawing.FontStyle.Bold);
            this.EntertButton_Click.ForeColor = System.Drawing.Color.Transparent;
            this.EntertButton_Click.Location = new System.Drawing.Point(239, 274);
            this.EntertButton_Click.Name = "EntertButton_Click";
            this.EntertButton_Click.Size = new System.Drawing.Size(266, 61);
            this.EntertButton_Click.TabIndex = 5;
            this.EntertButton_Click.Text = "Login";
            this.EntertButton_Click.UseVisualStyleBackColor = false;
            this.EntertButton_Click.Click += new System.EventHandler(this.EntertButton_Click_Click);
            // 
            // LabelEnteyUserAndPass
            // 
            this.LabelEnteyUserAndPass.AutoSize = true;
            this.LabelEnteyUserAndPass.BackColor = System.Drawing.SystemColors.Highlight;
            this.LabelEnteyUserAndPass.Font = new System.Drawing.Font("Aharoni", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEnteyUserAndPass.ForeColor = System.Drawing.Color.Transparent;
            this.LabelEnteyUserAndPass.Location = new System.Drawing.Point(3, 20);
            this.LabelEnteyUserAndPass.Name = "LabelEnteyUserAndPass";
            this.LabelEnteyUserAndPass.Size = new System.Drawing.Size(215, 28);
            this.LabelEnteyUserAndPass.TabIndex = 6;
            this.LabelEnteyUserAndPass.Text = "Clothing Store ";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.UserNameLabel.Font = new System.Drawing.Font("Aharoni", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.Transparent;
            this.UserNameLabel.Location = new System.Drawing.Point(273, 113);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(116, 19);
            this.UserNameLabel.TabIndex = 7;
            this.UserNameLabel.Text = "User Name:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.PasswordLabel.Font = new System.Drawing.Font("Aharoni", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Location = new System.Drawing.Point(273, 199);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(104, 19);
            this.PasswordLabel.TabIndex = 8;
            this.PasswordLabel.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Aharoni", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "System ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(241, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "Login To Your Account";
            // 
            // panel_Img
            // 
            this.panel_Img.AutoScroll = true;
            this.panel_Img.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_Img.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_Img.Controls.Add(this.label3);
            this.panel_Img.Controls.Add(this.LabelEnteyUserAndPass);
            this.panel_Img.Controls.Add(this.pictureBox1);
            this.panel_Img.Controls.Add(this.label1);
            this.panel_Img.Location = new System.Drawing.Point(-3, 1);
            this.panel_Img.Name = "panel_Img";
            this.panel_Img.Size = new System.Drawing.Size(238, 513);
            this.panel_Img.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Aharoni", 21.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "Online";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.loginImage;
            this.pictureBox1.Location = new System.Drawing.Point(3, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.Color.White;
            this.exit_button.Location = new System.Drawing.Point(517, 3);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(40, 40);
            this.exit_button.TabIndex = 12;
            this.exit_button.Text = "X";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(273, 135);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(238, 20);
            this.textBox_username.TabIndex = 14;
            this.textBox_username.TextChanged += new System.EventHandler(this.TextBox_username_TextChanged);
            this.textBox_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_username_KeyDown);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(273, 221);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(238, 20);
            this.textBox_password.TabIndex = 17;
            this.textBox_password.UseSystemPasswordChar = true;
            this.textBox_password.TextChanged += new System.EventHandler(this.TextBox_password_TextChanged);
            this.textBox_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_password_KeyDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.loginImage;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.username3;
            this.pictureBox2.Location = new System.Drawing.Point(239, 130);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.loginImage;
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.password3;
            this.pictureBox3.Location = new System.Drawing.Point(239, 216);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            this.pictureBox3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox3_MouseUp);
            // 
            // ForgotPass_lable
            // 
            this.ForgotPass_lable.AutoSize = true;
            this.ForgotPass_lable.ForeColor = System.Drawing.Color.Transparent;
            this.ForgotPass_lable.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.ForgotPass_lable.Location = new System.Drawing.Point(270, 244);
            this.ForgotPass_lable.Name = "ForgotPass_lable";
            this.ForgotPass_lable.Size = new System.Drawing.Size(92, 13);
            this.ForgotPass_lable.TabIndex = 18;
            this.ForgotPass_lable.TabStop = true;
            this.ForgotPass_lable.Text = "Forgot Password?";
            this.ForgotPass_lable.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgotPass_lable_LinkClicked);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(563, 351);
            this.ControlBox = false;
            this.Controls.Add(this.ForgotPass_lable);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_Img);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.EntertButton_Click);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "LoginScreen";
            this.Text = "Login";
            this.panel_Img.ResumeLayout(false);
            this.panel_Img.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EntertButton_Click;
        private System.Windows.Forms.Label LabelEnteyUserAndPass;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Panel panel_Img;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.LinkLabel ForgotPass_lable;
        private System.Windows.Forms.Label label3;
    }
}

namespace WindowsFormsApp1.Views
{
    partial class ChangePasswordScreen
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
            this.exit_button = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.Confirm_btn = new System.Windows.Forms.Button();
            this.ConforimPass_txt = new System.Windows.Forms.TextBox();
            this.newPass_txt = new System.Windows.Forms.TextBox();
            this.userName_txt = new System.Windows.Forms.TextBox();
            this.Confirm_lable = new System.Windows.Forms.Label();
            this.newPass_label = new System.Windows.Forms.Label();
            this.username_lable = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.Color.White;
            this.exit_button.Location = new System.Drawing.Point(382, -2);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(40, 40);
            this.exit_button.TabIndex = 36;
            this.exit_button.Text = "X";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.emailLabel.ForeColor = System.Drawing.Color.White;
            this.emailLabel.Location = new System.Drawing.Point(128, 62);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(47, 17);
            this.emailLabel.TabIndex = 30;
            this.emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(215, 59);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(185, 20);
            this.emailTextBox.TabIndex = 31;
            // 
            // Confirm_btn
            // 
            this.Confirm_btn.FlatAppearance.BorderSize = 0;
            this.Confirm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirm_btn.Font = new System.Drawing.Font("Aharoni", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_btn.ForeColor = System.Drawing.Color.White;
            this.Confirm_btn.Location = new System.Drawing.Point(214, 189);
            this.Confirm_btn.Name = "Confirm_btn";
            this.Confirm_btn.Size = new System.Drawing.Size(185, 37);
            this.Confirm_btn.TabIndex = 29;
            this.Confirm_btn.Text = "Enter";
            this.Confirm_btn.UseVisualStyleBackColor = true;
            this.Confirm_btn.Click += new System.EventHandler(this.Confirm_btn_Click);
            // 
            // ConforimPass_txt
            // 
            this.ConforimPass_txt.Location = new System.Drawing.Point(215, 151);
            this.ConforimPass_txt.Name = "ConforimPass_txt";
            this.ConforimPass_txt.PasswordChar = '*';
            this.ConforimPass_txt.Size = new System.Drawing.Size(185, 20);
            this.ConforimPass_txt.TabIndex = 28;
            // 
            // newPass_txt
            // 
            this.newPass_txt.Location = new System.Drawing.Point(215, 121);
            this.newPass_txt.Name = "newPass_txt";
            this.newPass_txt.PasswordChar = '*';
            this.newPass_txt.Size = new System.Drawing.Size(184, 20);
            this.newPass_txt.TabIndex = 27;
            // 
            // userName_txt
            // 
            this.userName_txt.Location = new System.Drawing.Point(215, 90);
            this.userName_txt.Name = "userName_txt";
            this.userName_txt.Size = new System.Drawing.Size(185, 20);
            this.userName_txt.TabIndex = 26;
            // 
            // Confirm_lable
            // 
            this.Confirm_lable.AutoSize = true;
            this.Confirm_lable.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Confirm_lable.ForeColor = System.Drawing.Color.White;
            this.Confirm_lable.Location = new System.Drawing.Point(12, 157);
            this.Confirm_lable.Name = "Confirm_lable";
            this.Confirm_lable.Size = new System.Drawing.Size(163, 17);
            this.Confirm_lable.TabIndex = 25;
            this.Confirm_lable.Text = "Confirm New Password:";
            // 
            // newPass_label
            // 
            this.newPass_label.AutoSize = true;
            this.newPass_label.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.newPass_label.ForeColor = System.Drawing.Color.White;
            this.newPass_label.Location = new System.Drawing.Point(64, 126);
            this.newPass_label.Name = "newPass_label";
            this.newPass_label.Size = new System.Drawing.Size(111, 17);
            this.newPass_label.TabIndex = 24;
            this.newPass_label.Text = "New Password: ";
            // 
            // username_lable
            // 
            this.username_lable.AutoSize = true;
            this.username_lable.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.username_lable.ForeColor = System.Drawing.Color.White;
            this.username_lable.Location = new System.Drawing.Point(94, 95);
            this.username_lable.Name = "username_lable";
            this.username_lable.Size = new System.Drawing.Size(81, 17);
            this.username_lable.TabIndex = 23;
            this.username_lable.Text = "User Name:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.loginImage;
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.username3;
            this.pictureBox4.Location = new System.Drawing.Point(181, 87);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 35;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.loginImage;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.email;
            this.pictureBox2.Location = new System.Drawing.Point(181, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.loginImage;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.password3;
            this.pictureBox1.Location = new System.Drawing.Point(181, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.loginImage;
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.password3;
            this.pictureBox3.Location = new System.Drawing.Point(181, 118);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // ChangePasswordScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(423, 247);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.Confirm_btn);
            this.Controls.Add(this.ConforimPass_txt);
            this.Controls.Add(this.newPass_txt);
            this.Controls.Add(this.userName_txt);
            this.Controls.Add(this.Confirm_lable);
            this.Controls.Add(this.newPass_label);
            this.Controls.Add(this.username_lable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePasswordScreen";
            this.Text = "ChangePasswordScreen";
            this.Load += new System.EventHandler(this.ChangePasswordScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button Confirm_btn;
        private System.Windows.Forms.TextBox ConforimPass_txt;
        private System.Windows.Forms.TextBox newPass_txt;
        private System.Windows.Forms.TextBox userName_txt;
        private System.Windows.Forms.Label Confirm_lable;
        private System.Windows.Forms.Label newPass_label;
        private System.Windows.Forms.Label username_lable;
    }
}
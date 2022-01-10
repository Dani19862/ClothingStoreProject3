
namespace WindowsFormsApp1
{
    partial class EnteryScreen
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
            this.DirctorClick = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.OfficiaClick = new System.Windows.Forms.Button();
            this.ChhooseUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DirctorClick
            // 
            this.DirctorClick.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
            this.DirctorClick.Location = new System.Drawing.Point(147, 255);
            this.DirctorClick.Margin = new System.Windows.Forms.Padding(2);
            this.DirctorClick.Name = "DirctorClick";
            this.DirctorClick.Size = new System.Drawing.Size(385, 81);
            this.DirctorClick.TabIndex = 0;
            this.DirctorClick.Text = "Director";
            this.DirctorClick.UseVisualStyleBackColor = true;
            this.DirctorClick.Click += new System.EventHandler(this.DirctorClick_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(330, 80);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(6, 6);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // OfficiaClick
            // 
            this.OfficiaClick.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OfficiaClick.Location = new System.Drawing.Point(147, 143);
            this.OfficiaClick.Margin = new System.Windows.Forms.Padding(2);
            this.OfficiaClick.Name = "OfficiaClick";
            this.OfficiaClick.Size = new System.Drawing.Size(385, 79);
            this.OfficiaClick.TabIndex = 2;
            this.OfficiaClick.Text = "Official";
            this.OfficiaClick.UseVisualStyleBackColor = true;
            this.OfficiaClick.Click += new System.EventHandler(this.OfficiaClick_Click);
            // 
            // ChhooseUser
            // 
            this.ChhooseUser.AutoSize = true;
            this.ChhooseUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ChhooseUser.Font = new System.Drawing.Font("Aharoni", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ChhooseUser.Location = new System.Drawing.Point(177, 62);
            this.ChhooseUser.Name = "ChhooseUser";
            this.ChhooseUser.Size = new System.Drawing.Size(321, 35);
            this.ChhooseUser.TabIndex = 3;
            this.ChhooseUser.Text = "Hello! choose User";
            
            // 
            // EnteryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.חנות_בגדים;
            this.ClientSize = new System.Drawing.Size(752, 502);
            this.Controls.Add(this.ChhooseUser);
            this.Controls.Add(this.OfficiaClick);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DirctorClick);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EnteryScreen";
            this.Text = "Choose User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DirctorClick;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button OfficiaClick;
        private System.Windows.Forms.Label ChhooseUser;
    }
}


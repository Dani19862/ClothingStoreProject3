using Services;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class ChangePasswordScreen : Form
    {
        readonly LoginClassSingelton lc;
        public ChangePasswordScreen()
        {
            InitializeComponent();
            lc = LoginClassSingelton.GetSingelton();
        }
        // check if user exist in system.
        //check if the new pass = confirm pass and atlist 6 lenght.
        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (lc.IsExist(userName_txt.Text, emailTextBox.Text) == true)
                {

                    if (newPass_txt.Text == ConforimPass_txt.Text  && !string.IsNullOrEmpty(newPass_txt.Text))
                    {
                        if ( newPass_txt.Text.Length >= 6 && ConforimPass_txt.Text.Length >= 6  )
                        {
                            var c = lc.RecoverPassword(userName_txt.Text, newPass_txt.Text, emailTextBox.Text);
                            MessageBox.Show("Yoar Password Has Been Changed successfully");
                            var frm = new LoginScreen();
                            frm.Location = this.Location;
                            frm.StartPosition = FormStartPosition.Manual;
                            frm.FormClosing += delegate { this.Show(); };
                            frm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("New Password must be atlist 6 charcters");
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("cnofirm password must be same new password");
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("No user exists");
                    ConforimPass_txt.Text = emailTextBox.Text = newPass_txt.Text = userName_txt.Text = "";
                    return;
                }
            }
            catch (Exception)
            {
              
            }
           

        }
        //  // Logout button - pass to login screen
        private void Exit_button_Click(object sender, EventArgs e)
        {
            var frm = new LoginScreen();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void ChangePasswordScreen_Load(object sender, EventArgs e)
        {
            //if (emailTextBox.Visible && userName_txt.Visible)
            //{
            //    newPass_txt.Visible = ConforimPass_txt.Visible = newPass_label.Visible = Confirm_lable.Visible = pictureBox3.Visible = pictureBox4.Visible = false;


            //}
        }
    }
}

using Model;
using Services;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class LoginScreen : Form
    {
        readonly LoginClassSingelton lc;
       
        public LoginScreen()
        {
            InitializeComponent();
            lc = LoginClassSingelton.GetSingelton();

        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private void EntertButton_Click_Click(object sender, EventArgs e)
        {


            try
            {
                if ((!string.IsNullOrEmpty(textBox_username.Text) && (!string.IsNullOrEmpty(textBox_password.Text))))
                {
                    var entery = lc.Login(textBox_username.Text, textBox_password.Text);
                    if (entery != null)
                    {
                        UserDetails.UserType = entery.UserType;
                        MessageBox.Show("Hello " + textBox_username.Text);
                        var frm = new CustomersAndOrdersScreen();
                        frm.Location = this.Location;
                        frm.StartPosition = FormStartPosition.Manual;
                        frm.FormClosing += delegate { this.Show(); };
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Your Name Or Password Incorct! \n Plesea Try Again");
                        textBox_username.Text = textBox_password.Text = "";
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Enter Your username and password");
                    return;

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Your Name Or Password Incorct! \n Plesea Try Again");
                textBox_username.Text = textBox_password.Text = "";
            }


        }

       

        private void TextBox_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void TextBox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void TextBox_username_TextChanged(object sender, EventArgs e)
        {
            var logintxt = new LoginScreen();
            logintxt.Text = textBox_username.Text;
        }

        private void TextBox_password_TextChanged(object sender, EventArgs e)
        {
            var loginPass = new LoginScreen();
            loginPass.Text = textBox_username.Text;
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = false;
        }

        private void PictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
        }
        //for Exit Applictaion
        private void Exit_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To exit application?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
              
            }
        }

        private void ForgotPass_lable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new ChangePasswordScreen();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
    }
}

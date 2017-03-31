using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Webbrowser2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string faaas,user;
        string cnstr = Webbrowser2.Properties.Settings.Default.cnstr;
        public static int log=0,l=0;
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
           

            
            SqlConnection cmd = new SqlConnection(cnstr);
            user = this.TxtUsername.Text;
            string pass = this.TxtPassword.Text;
            if (String.IsNullOrEmpty(user) || String.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Please enter all details");
            }
            else
            {
                cmd.Open();
                SqlCommand cmd1;
                string uniq = @"select count(*) from WebDB where Username='"+user+"'AND Password='"+pass+"'";
                cmd1 = new SqlCommand(uniq, cmd);
                int count = (int)cmd1.ExecuteScalar();
                cmd.Close();
                if (count > 0)
                {
                    MessageBox.Show("Login Successful");
                    faaas = TxtUsername.Text;
                    log = 1;
                    l = 1;
                    
                }
                else
                {
                    MessageBox.Show("Sorry Try Again");
                }
            }
            this.Hide();
       
            Browser sw = new Browser();
            sw.Show();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register s1 = new Register();
            s1.Show();
           
            
        }

        private void LblUsername_Click(object sender, EventArgs e)
        {

        }

        private void LblPassword_Click(object sender, EventArgs e)
        {

        }
        public static int otp;
        private void BtnForgot_Click(object sender, EventArgs e)
        {
            //OTP
            Random rnd = new Random();
            otp = rnd.Next(1000, 25000);
            this.Hide();
            ForgotPS s1 = new ForgotPS();
            s1.Show();


        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

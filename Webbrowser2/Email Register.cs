using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webbrowser2
{
    public partial class Email_Register : Form
    {
        public Email_Register()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
     
        public static string user;
        public static string pass;
        string cnstr = Webbrowser2.Properties.Settings.Default.cnstr;

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection cmd;
           
            user = this.TxtUsername.Text;
            pass = this.TxtPassword.Text;
            if (String.IsNullOrEmpty(user) || String.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Please enter all details");
            }
            else
            {
                cmd = new SqlConnection(cnstr);
                cmd.Open();
                SqlCommand cmd1;
                string uniq = @"insert into Emaillog (Email,Password) values('" + user + "','" + pass + "')";
                cmd1 = new SqlCommand(uniq, cmd);
                cmd1.ExecuteNonQuery();
                
                cmd.Close();
                MessageBox.Show("Login Successful");
                this.Hide();
                Login_Email s1 = new Login_Email();
                s1.Show();

            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            
        }
    }
}

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
    public partial class Login_Email : Form
    {
        string cnstr = Webbrowser2.Properties.Settings.Default.cnstr;
     
        public Login_Email()
        {
            InitializeComponent();
        }
        public static string user,chuser;
        public static string pass,chpass;
      
        
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
           SqlConnection cmd = new SqlConnection(cnstr);
           SqlCommand cm;
            user = this.TxtUsername.Text;
            pass = this.TxtPassword.Text;
            if (String.IsNullOrEmpty(user) || String.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Please enter all details");
            }
            else
            {     
               
                cmd.Open();                
                string xyz = @"select * from Emaillog where Email='"+user+"' and Password='"+pass+"'";
                cm = new SqlCommand(xyz, cmd);
                SqlDataReader rdr = cm.ExecuteReader();
                rdr.Read();
                chuser = rdr["Email"].ToString();
                chpass = rdr["Password"].ToString();
                rdr.Close();
                cm.ExecuteNonQuery();               
                cmd.Close();
                MessageBox.Show("Login Successful");
                this.Hide();
                EmailSender s1 = new EmailSender();
                s1.Show();
               
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Email_Register s1 = new Email_Register();
            s1.Show();        
        }
    }
}

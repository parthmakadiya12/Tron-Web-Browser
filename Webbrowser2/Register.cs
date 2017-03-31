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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void lblRegContact_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Webbrowser2.exe","http://www.alltricks007.blogspot.com");
            
        }

        private void btnRegCancel_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void btnRegLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login s2 = new Login();
            s2.Show();
        }
       
        
        private void btnRegSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection cmd;
            string name=txtRegName.Text;
            string username = txtRegUsername.Text;
            string email = txtRegEmail.Text;
            string password = txtRegPassword.Text;
            
            DateTimePicker s1=dateTimePicker1;
            if (String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(username) || String.IsNullOrEmpty(username) || String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter all details");
            }
            else
            {
                    string cnstr = Webbrowser2.Properties.Settings.Default.cnstr;
                    cmd = new SqlConnection(cnstr);
                    
                    cmd.Open();
                    SqlCommand cmd1;

                    string uniq = @"insert into WebDB (Username,Password,Name,Email,DOB) values('" + username + "','" + password + "','" + name + "','"+email+"','"+dateTimePicker1.Value.Date+"')";
                    cmd1 = new SqlCommand(uniq, cmd);
                    cmd1.ExecuteNonQuery();
                    cmd.Close();
                    MessageBox.Show("User Created");
                
            }
            
        }

       
    }
}

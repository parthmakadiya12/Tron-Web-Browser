using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mime;

namespace Webbrowser2
{
    public partial class EmailSender : Form
    {
        public EmailSender()
        {
            InitializeComponent();
        }
        string cnstr = Webbrowser2.Properties.Settings.Default.cnstr;
        string chuser, chpass;

        private void btn_send_Click(object sender, EventArgs e)
        {

            chuser = txtID.Text;
            chpass = txtPass.Text;

            try
            {
                SmtpClient client = new SmtpClient
                {
                    Host = "smtp-mail.outlook.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new System.Net.NetworkCredential(chuser, chpass),
                   // Timeout = 10000,
                };
                MailMessage mm = new MailMessage("parthmakadiya12@outlook.com", txtTo.Text, txtSubject.Text,richBody.Text);
                //MailMessage mm = new MailMessage(chuser,txtTo.Text,txtSubject.Text,richBody.Text);
                client.Send(mm);
               MessageBox.Show("Email Sent");
            }
            catch (Exception eee)
            {
                MessageBox.Show("Could not mail\n\n" + eee.ToString());
            }
        }

        

        private void btnEmailLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Email s22 = new Login_Email();
            s22.Show();
        }

        private void btnEmailBrowser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Browser s22 = new Browser();
            s22.Show();
        }

        private void btnEmailLogout_Click(object sender, EventArgs e)
        {

            this.Hide();
            
        }

        private void EmailSender_Load(object sender, EventArgs e)
        {
            lbllogin.Text = Login_Email.user;
        }

        
    }
}

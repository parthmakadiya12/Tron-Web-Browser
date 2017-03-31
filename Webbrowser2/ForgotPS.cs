using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webbrowser2
{
    public partial class ForgotPS : Form
    {
        public ForgotPS()
        {
            InitializeComponent();
        }
        public static string chid;
        public static string chpass;
        string cnstr = Webbrowser2.Properties.Settings.Default.cnstr;
        private void label4_Click(object sender, EventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chid = txtID.Text;
            chpass = txtPass.Text;
            string xx="OTP";
            try
            {
                SmtpClient client = new SmtpClient
                {
                    Host = "smtp-mail.outlook.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new System.Net.NetworkCredential(chid, chpass),
                    // Timeout = 10000,
                };
                int x = Login.otp;
                xx = x.ToString();
                MailMessage mm = new MailMessage(chid, chid, "OTP Generated", xx);
                //MailMessage mm = new MailMessage(chuser,txtTo.Text,txtSubject.Text,richBody.Text);
                client.Send(mm);
                MessageBox.Show("Email Sent");
            }
            catch (Exception eee)
            {
                MessageBox.Show("Could not mail.Check Your Proxy Setting .Internet Error.\n\n" + eee.ToString());
            }
            string up=TxtUPDATE.Text;
            string mail=txtID.Text;
            if(TxtOTP.Text==xx)
             {
                 SqlConnection cmd = new SqlConnection(cnstr);
                 cmd.Open();
                 SqlCommand con;
                 string uniq = "update WebDb set Password='" + up + "' where Email='"+mail+"'";
                 con = new SqlCommand(uniq, cmd);
                 con.ExecuteNonQuery();
             }
            else
            {
                MessageBox.Show("OTP Wrong.If You Face any Error Feel Free To contact Admin parthmakadiya007@gmail.com");
            }
            
             
        }
    }
}

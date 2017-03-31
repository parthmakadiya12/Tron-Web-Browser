using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Webbrowser2
{
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();

        }


        string fw = Login.faaas;
        
        public int btnpress;

        public static string faas = "Logged in";
        WebBrowser web = new WebBrowser();
        int i = 0;
        int flag = 0;
        string cnstr = Webbrowser2.Properties.Settings.Default.cnstr;
        private void Form1_Load(object sender, EventArgs e)
        {
            //This two lines for Full Screen
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            WindowState = FormWindowState.Maximized;

            web = new WebBrowser();
            web.ScriptErrorsSuppressed = true;
            web.Dock = DockStyle.Fill;
            web.Visible = true;
            web.DocumentCompleted += web_DocumentCompleted;
            tabControl1.TabPages.Add("New tab");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(web);
            i = i + 1;
            web.Navigate("www.google.com");
            label1.Text = fw;
            


        }
      
        public void addtab()
        {
            web = new WebBrowser();
            web.ScriptErrorsSuppressed = true;
            web.Dock = DockStyle.Fill;
            web.Visible = true;
            //web.ProgressChanged += new WebBrowserProgressChangedEventHandler(Browser_ProgressChanged);
            
            web.DocumentCompleted += web_DocumentCompleted;
            tabControl1.TabPages.Add("New tab");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(web);
            i = i + 1;
            web.Navigate("www.bing.com");
            label1.Text = Login.faaas;
        }
        public void closetab()
        {
            if (tabControl1.TabPages.Count > 1)
            {
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
                tabControl1.SelectTab(tabControl1.TabPages.Count - 1);
                i -= 1;
            }
        }

        private WebBrowser getCurrentBrowser()
        {
            return (WebBrowser)tabControl1.SelectedTab.Controls[0];
        }

        void web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = ((WebBrowser)tabControl1.SelectedTab.Controls[0]).DocumentTitle;
            toolStripComboBox1.Text = web.Url.AbsoluteUri;

        }

        private void goToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //            ((webBrowser)tabControl1.SelectedTabs.Controls[0]).Navigate(toolStripComboBox1.Text);
            web.Navigate(toolStripComboBox1.Text);
            if (toolStripComboBox1.Items.Contains(toolStripComboBox1.Text))
            {
                toolStripComboBox1.Items.Add(toolStripComboBox1);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (web.CanGoBack)
            {
                web.GoBack();
            }
            else
            {
                MessageBox.Show("Cannot Go Back.");
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (web.CanGoForward)
            {
                web.GoForward();
            }
            else
            {
                MessageBox.Show("Cannot Go Forward.");
            }
        }

        public void addTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addtab();
        }


        private void removePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closetab();
        }
      

        public static Image favicon(String u, string file)
        {
            Uri url = new Uri(u);
            String iconurl = "http://" + url.Host + "/favicon.ico";

            WebRequest request = WebRequest.Create(iconurl);
            try
            {
                WebResponse response = request.GetResponse();

                Stream s = response.GetResponseStream();
                return Image.FromStream(s);
            }
            catch (Exception ex)
            {
                //return a default icon in case 
                //the web site doesn`t have a favicon
                return Image.FromFile(file);
            }
        }

        private void fullScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (flag == 0)
            {
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                flag = 1;
            }
            else if (flag == 1)
            {
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                WindowState = FormWindowState.Maximized;
                flag = 0;
            }


        }


        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login s1 = new Login();
            s1.Closed += (s, args) => this.Close();
            s1.Show();


        }

   


        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        int ii = 1, x = Login.log;
        SqlConnection cmd;
        string user=Login.faaas;
        
        private void goToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
            toolStripComboBox1.Items.Add(toolStripComboBox1);
            comboBox1.Items.Add("" + ii + " " + toolStripComboBox1.Text);
            ii++;
            web.Navigate(toolStripComboBox1.Text);
            btnpress = 1;
            if (x == 1) //It will check Logged in or not
            {
                
                cmd = new SqlConnection(cnstr);
                string hist = toolStripComboBox1.Text;


                cmd.Open();
                SqlCommand cmd1;

                string uniq = @"insert into History (Username,History) values('" + user + "','" + hist + "')";
                cmd1 = new SqlCommand(uniq, cmd);
                cmd1.ExecuteNonQuery();
                cmd.Close();

            }
        }
        int w=0;
        private void toolStripComboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            w = 1;

        }
        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {

            if (w ==0)
            {
              
                toolStripComboBox1.Items.Add(toolStripComboBox1);
                comboBox1.Items.Add("" + ii + " " + toolStripComboBox1.Text);
                ii++;
                w = 0;
                
            }
            w = 0;
        }

        private void emailSenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            EmailSender s1 = new EmailSender();
            s1.Show();
        }

   

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addtab(); 
        }

       

        private void closeTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closetab();
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Browser()).Show();
        }

       

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().ShowSaveAsDialog();
        }

        private void pagePrintoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().ShowPrintDialog();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().ShowPageSetupDialog();
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().ShowPropertiesDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().Document.ExecCommand("Copy", false, null);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().Document.ExecCommand("Cut", false, null);
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().Document.ExecCommand("Paste", false, null);
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().Document.ExecCommand("SelectAll", true, null);
        }

        private void addToFavoritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addfav();
        }

        //added for favourites added by other form
        public void addfav()
        {
            cmd = new SqlConnection(cnstr);
            string user = Login.user;
            string fav = toolStripComboBox1.Text;
            string[] ar = new string[30];

            if (Login.l == 1)
            {
                cmd.Open();
                SqlCommand cmd1;

                string uniq = @"insert into Fav (Username,favourites) values('" + user + "','" + fav + "')";
                cmd1 = new SqlCommand(uniq, cmd);
                cmd1.ExecuteNonQuery();
                
                
                listBox1.Items.Add(toolStripComboBox1.Text);
                string xyz = "select * from Fav where Username=" +user;
                SqlCommand cmd3 = new SqlCommand(xyz, cmd);
                SqlDataReader rdr = cmd3.ExecuteReader();
                while (rdr.Read())
                {int q=0;
                    rdr.Read();
                    ar[q] = rdr["favourites"].ToString();
                    q++;
                    listBox1.Items.Add(ar);
                }
                    cmd.Close();
            }

        }

          

    }
}



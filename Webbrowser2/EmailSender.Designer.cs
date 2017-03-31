namespace Webbrowser2
{
    partial class EmailSender
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lbllogin = new System.Windows.Forms.Label();
            this.btnEmailLogout = new System.Windows.Forms.Button();
            this.btnEmailLogin = new System.Windows.Forms.Button();
            this.btnEmailBrowser = new System.Windows.Forms.Button();
            this.richBody = new System.Windows.Forms.RichTextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.lbllogin);
            this.groupBox1.Controls.Add(this.btnEmailLogout);
            this.groupBox1.Controls.Add(this.btnEmailLogin);
            this.groupBox1.Controls.Add(this.btnEmailBrowser);
            this.groupBox1.Controls.Add(this.richBody);
            this.groupBox1.Controls.Add(this.txtSubject);
            this.groupBox1.Controls.Add(this.txtTo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_send);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 396);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Email Sender";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(344, 36);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(183, 20);
            this.txtPass.TabIndex = 39;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(75, 36);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(183, 20);
            this.txtID.TabIndex = 38;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(285, 38);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(35, 18);
            this.lblPassword.TabIndex = 37;
            this.lblPassword.Text = "Pass";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(31, 38);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(22, 18);
            this.lblID.TabIndex = 36;
            this.lblID.Text = "ID";
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.Location = new System.Drawing.Point(403, 378);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(27, 18);
            this.lbllogin.TabIndex = 35;
            this.lbllogin.Text = "To:";
            // 
            // btnEmailLogout
            // 
            this.btnEmailLogout.Location = new System.Drawing.Point(474, 314);
            this.btnEmailLogout.Name = "btnEmailLogout";
            this.btnEmailLogout.Size = new System.Drawing.Size(83, 44);
            this.btnEmailLogout.TabIndex = 34;
            this.btnEmailLogout.Text = "Logout";
            this.btnEmailLogout.UseVisualStyleBackColor = true;
            this.btnEmailLogout.Click += new System.EventHandler(this.btnEmailLogout_Click);
            // 
            // btnEmailLogin
            // 
            this.btnEmailLogin.Location = new System.Drawing.Point(474, 116);
            this.btnEmailLogin.Name = "btnEmailLogin";
            this.btnEmailLogin.Size = new System.Drawing.Size(83, 42);
            this.btnEmailLogin.TabIndex = 33;
            this.btnEmailLogin.Text = "Login";
            this.btnEmailLogin.UseVisualStyleBackColor = true;
            this.btnEmailLogin.Click += new System.EventHandler(this.btnEmailLogin_Click);
            // 
            // btnEmailBrowser
            // 
            this.btnEmailBrowser.Location = new System.Drawing.Point(474, 216);
            this.btnEmailBrowser.Name = "btnEmailBrowser";
            this.btnEmailBrowser.Size = new System.Drawing.Size(83, 45);
            this.btnEmailBrowser.TabIndex = 32;
            this.btnEmailBrowser.Text = "Open Browser";
            this.btnEmailBrowser.UseVisualStyleBackColor = true;
            this.btnEmailBrowser.Click += new System.EventHandler(this.btnEmailBrowser_Click);
            // 
            // richBody
            // 
            this.richBody.Location = new System.Drawing.Point(174, 188);
            this.richBody.Name = "richBody";
            this.richBody.Size = new System.Drawing.Size(183, 170);
            this.richBody.TabIndex = 31;
            this.richBody.Text = "";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(174, 149);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(183, 20);
            this.txtSubject.TabIndex = 29;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(174, 116);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(183, 20);
            this.txtTo.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Body:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "To:";
            // 
            // btn_send
            // 
            this.btn_send.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.Location = new System.Drawing.Point(380, 116);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 242);
            this.btn_send.TabIndex = 23;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Login only for Outlook Users.(Gmail has updated its security to v 5.0 so you have" +
    " to use outlook id in order to send mail.";
            // 
            // EmailSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 411);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmailSender";
            this.Text = "EmailSender";
            this.Load += new System.EventHandler(this.EmailSender_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richBody;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btnEmailLogout;
        private System.Windows.Forms.Button btnEmailLogin;
        private System.Windows.Forms.Button btnEmailBrowser;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
    }
}
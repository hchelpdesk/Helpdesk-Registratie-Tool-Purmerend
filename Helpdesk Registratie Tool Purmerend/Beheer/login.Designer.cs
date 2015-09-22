namespace Helpdesk_Registratie_Tool_Purmerend.Beheer
{
    partial class beheer_login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(beheer_login_form));
            this.beheer_login_lbl_username = new System.Windows.Forms.Label();
            this.beheer_login_txtbox_username = new System.Windows.Forms.TextBox();
            this.beheer_login_lbl_password = new System.Windows.Forms.Label();
            this.beheer_login_txtbox_password = new System.Windows.Forms.TextBox();
            this.beheer_login_btn_login = new System.Windows.Forms.Button();
            this.beheer_login_lbl_pwvergeten = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // beheer_login_lbl_username
            // 
            this.beheer_login_lbl_username.AutoSize = true;
            this.beheer_login_lbl_username.Location = new System.Drawing.Point(13, 13);
            this.beheer_login_lbl_username.Name = "beheer_login_lbl_username";
            this.beheer_login_lbl_username.Size = new System.Drawing.Size(84, 13);
            this.beheer_login_lbl_username.TabIndex = 0;
            this.beheer_login_lbl_username.Text = "Gebruikersnaam";
            // 
            // beheer_login_txtbox_username
            // 
            this.beheer_login_txtbox_username.Location = new System.Drawing.Point(16, 30);
            this.beheer_login_txtbox_username.Name = "beheer_login_txtbox_username";
            this.beheer_login_txtbox_username.Size = new System.Drawing.Size(182, 20);
            this.beheer_login_txtbox_username.TabIndex = 1;
            // 
            // beheer_login_lbl_password
            // 
            this.beheer_login_lbl_password.AutoSize = true;
            this.beheer_login_lbl_password.Location = new System.Drawing.Point(16, 57);
            this.beheer_login_lbl_password.Name = "beheer_login_lbl_password";
            this.beheer_login_lbl_password.Size = new System.Drawing.Size(68, 13);
            this.beheer_login_lbl_password.TabIndex = 2;
            this.beheer_login_lbl_password.Text = "Wachtwoord";
            // 
            // beheer_login_txtbox_password
            // 
            this.beheer_login_txtbox_password.Location = new System.Drawing.Point(19, 74);
            this.beheer_login_txtbox_password.Name = "beheer_login_txtbox_password";
            this.beheer_login_txtbox_password.PasswordChar = '¿';
            this.beheer_login_txtbox_password.Size = new System.Drawing.Size(179, 20);
            this.beheer_login_txtbox_password.TabIndex = 3;
            // 
            // beheer_login_btn_login
            // 
            this.beheer_login_btn_login.Location = new System.Drawing.Point(123, 100);
            this.beheer_login_btn_login.Name = "beheer_login_btn_login";
            this.beheer_login_btn_login.Size = new System.Drawing.Size(75, 23);
            this.beheer_login_btn_login.TabIndex = 4;
            this.beheer_login_btn_login.Text = "Inloggen";
            this.beheer_login_btn_login.UseVisualStyleBackColor = true;
            // 
            // beheer_login_lbl_pwvergeten
            // 
            this.beheer_login_lbl_pwvergeten.AutoSize = true;
            this.beheer_login_lbl_pwvergeten.Location = new System.Drawing.Point(19, 109);
            this.beheer_login_lbl_pwvergeten.Name = "beheer_login_lbl_pwvergeten";
            this.beheer_login_lbl_pwvergeten.Size = new System.Drawing.Size(99, 13);
            this.beheer_login_lbl_pwvergeten.TabIndex = 5;
            this.beheer_login_lbl_pwvergeten.TabStop = true;
            this.beheer_login_lbl_pwvergeten.Text = "Password Vergeten";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(204, 33);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(13, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // beheer_login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 145);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.beheer_login_lbl_pwvergeten);
            this.Controls.Add(this.beheer_login_btn_login);
            this.Controls.Add(this.beheer_login_txtbox_password);
            this.Controls.Add(this.beheer_login_lbl_password);
            this.Controls.Add(this.beheer_login_txtbox_username);
            this.Controls.Add(this.beheer_login_lbl_username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "beheer_login_form";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label beheer_login_lbl_username;
        private System.Windows.Forms.TextBox beheer_login_txtbox_username;
        private System.Windows.Forms.Label beheer_login_lbl_password;
        private System.Windows.Forms.TextBox beheer_login_txtbox_password;
        private System.Windows.Forms.Button beheer_login_btn_login;
        private System.Windows.Forms.LinkLabel beheer_login_lbl_pwvergeten;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
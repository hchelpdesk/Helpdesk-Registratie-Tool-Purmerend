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
            this.username = new System.Windows.Forms.TextBox();
            this.beheer_login_lbl_password = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.beheer_login_btn_login = new System.Windows.Forms.Button();
            this.beheer_login_lbl_pwvergeten = new System.Windows.Forms.LinkLabel();
            this.beheer_login_lbl_gebruikersnaam = new System.Windows.Forms.LinkLabel();
            this.beheer_login_lbl_wachtwoord = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // beheer_login_lbl_username
            // 
            this.beheer_login_lbl_username.AutoSize = true;
            this.beheer_login_lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beheer_login_lbl_username.Location = new System.Drawing.Point(13, 13);
            this.beheer_login_lbl_username.Name = "beheer_login_lbl_username";
            this.beheer_login_lbl_username.Size = new System.Drawing.Size(98, 13);
            this.beheer_login_lbl_username.TabIndex = 0;
            this.beheer_login_lbl_username.Text = "Gebruikersnaam";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(16, 30);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(182, 20);
            this.username.TabIndex = 1;
            // 
            // beheer_login_lbl_password
            // 
            this.beheer_login_lbl_password.AutoSize = true;
            this.beheer_login_lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beheer_login_lbl_password.Location = new System.Drawing.Point(13, 58);
            this.beheer_login_lbl_password.Name = "beheer_login_lbl_password";
            this.beheer_login_lbl_password.Size = new System.Drawing.Size(78, 13);
            this.beheer_login_lbl_password.TabIndex = 2;
            this.beheer_login_lbl_password.Text = "Wachtwoord";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(16, 74);
            this.password.Name = "password";
            this.password.PasswordChar = '¿';
            this.password.Size = new System.Drawing.Size(179, 20);
            this.password.TabIndex = 3;
            // 
            // beheer_login_btn_login
            // 
            this.beheer_login_btn_login.Location = new System.Drawing.Point(123, 100);
            this.beheer_login_btn_login.Name = "beheer_login_btn_login";
            this.beheer_login_btn_login.Size = new System.Drawing.Size(75, 23);
            this.beheer_login_btn_login.TabIndex = 4;
            this.beheer_login_btn_login.Text = "Inloggen";
            this.beheer_login_btn_login.UseVisualStyleBackColor = true;
            this.beheer_login_btn_login.Click += new System.EventHandler(this.beheer_login_btn_login_Click);
            // 
            // beheer_login_lbl_pwvergeten
            // 
            this.beheer_login_lbl_pwvergeten.AutoSize = true;
            this.beheer_login_lbl_pwvergeten.Location = new System.Drawing.Point(12, 123);
            this.beheer_login_lbl_pwvergeten.Name = "beheer_login_lbl_pwvergeten";
            this.beheer_login_lbl_pwvergeten.Size = new System.Drawing.Size(114, 13);
            this.beheer_login_lbl_pwvergeten.TabIndex = 5;
            this.beheer_login_lbl_pwvergeten.TabStop = true;
            this.beheer_login_lbl_pwvergeten.Text = "Wachtwoord Vergeten";
            // 
            // beheer_login_lbl_gebruikersnaam
            // 
            this.beheer_login_lbl_gebruikersnaam.AutoSize = true;
            this.beheer_login_lbl_gebruikersnaam.Location = new System.Drawing.Point(201, 32);
            this.beheer_login_lbl_gebruikersnaam.Name = "beheer_login_lbl_gebruikersnaam";
            this.beheer_login_lbl_gebruikersnaam.Size = new System.Drawing.Size(13, 13);
            this.beheer_login_lbl_gebruikersnaam.TabIndex = 6;
            this.beheer_login_lbl_gebruikersnaam.TabStop = true;
            this.beheer_login_lbl_gebruikersnaam.Text = "?";
            this.beheer_login_lbl_gebruikersnaam.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // beheer_login_lbl_wachtwoord
            // 
            this.beheer_login_lbl_wachtwoord.AutoSize = true;
            this.beheer_login_lbl_wachtwoord.Location = new System.Drawing.Point(201, 77);
            this.beheer_login_lbl_wachtwoord.Name = "beheer_login_lbl_wachtwoord";
            this.beheer_login_lbl_wachtwoord.Size = new System.Drawing.Size(13, 13);
            this.beheer_login_lbl_wachtwoord.TabIndex = 7;
            this.beheer_login_lbl_wachtwoord.TabStop = true;
            this.beheer_login_lbl_wachtwoord.Text = "?";
            this.beheer_login_lbl_wachtwoord.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.beheer_login_lbl_wachtwoord_LinkClicked);
            // 
            // beheer_login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 145);
            this.Controls.Add(this.beheer_login_lbl_wachtwoord);
            this.Controls.Add(this.beheer_login_lbl_gebruikersnaam);
            this.Controls.Add(this.beheer_login_lbl_pwvergeten);
            this.Controls.Add(this.beheer_login_btn_login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.beheer_login_lbl_password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.beheer_login_lbl_username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "beheer_login_form";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.beheer_login_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label beheer_login_lbl_username;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label beheer_login_lbl_password;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button beheer_login_btn_login;
        private System.Windows.Forms.LinkLabel beheer_login_lbl_pwvergeten;
        private System.Windows.Forms.LinkLabel beheer_login_lbl_gebruikersnaam;
        private System.Windows.Forms.LinkLabel beheer_login_lbl_wachtwoord;
    }
}
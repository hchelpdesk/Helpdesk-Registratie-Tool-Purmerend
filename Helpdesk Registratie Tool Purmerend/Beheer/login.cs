using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace Helpdesk_Registratie_Tool_Purmerend.Beheer
{
    public partial class beheer_login_form : Form
    {
        public beheer_login_form()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Gebruik je e-mailadres als gebruikersnaam!");
        }

        private void beheer_login_lbl_wachtwoord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Je hebt een e-mail ontvangen met daarin je wachtwoord.");
        }

        private void beheer_login_btn_login_Click(object sender, EventArgs e)
        {
            if (username.Text != "" & password.Text != "")
            {

                string connectionString = (@"Data Source=DENNIS-PC\SQLEXPRESS;Initial Catalog=helpdesk;Integrated Security=True");
                string queryText = @"SELECT Count(*) FROM werknemers WHERE emailadres = @username AND password = @password";
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(queryText, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@username", username.Text);
                    cmd.Parameters.AddWithValue("@password", password.Text);
                    // ExecuteScalar, geeft alleen de row (rij) terug die overeenkomt met de query.
                    int result = (int)cmd.ExecuteScalar();
                    if (result > 0)
                    {
                        MessageBox.Show("Logged In!");
                        
                        if (result > 0)
                        {
                            
                        }
                    }

                    else
                        MessageBox.Show("User Not Found!");
                }
            }
        }

        private void beheer_login_form_Load(object sender, EventArgs e)
        {

        }
    }
}


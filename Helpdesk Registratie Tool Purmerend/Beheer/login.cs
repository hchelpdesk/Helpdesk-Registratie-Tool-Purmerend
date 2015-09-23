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
            //Locals to hold values
            string emailadres = beheer_login_txtbox_username.Text;
            string password = beheer_login_txtbox_password.Text;


            //Loop through database
            foreach (DataRow row in LoginDataSet.werknemersDataTable)
            {
                //And search for Username and Pass that match
                if (row.ItemArray[0].Equals(emailadres) && row.ItemArray[1].Equals(password))
                {
                    beheer_login_txtbox_username.Text = String.Empty;
                    beheer_login_txtbox_password.Text = String.Empty;
                    MessageBox.Show("Login Success");
                    break;
                }
                //If not, then show this message.
                else
                {
                    MessageBox.Show("Username/Password incorrect");
                    break;
                }
            }
        }
    }
}

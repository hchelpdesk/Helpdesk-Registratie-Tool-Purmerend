﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Helpdesk_Registratie_Tool_Purmerend.Incidenten
{
    public partial class call_add : Form
    {
        public call_add()
        {
            InitializeComponent();
        }
        private void call_add_existingcust1_combobx_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection klantenconn = new SqlConnection(@"Data Source=DENNIS-PC\SQLEXPRESS;Initial Catalog=helpdesk;Integrated Security=True");
                klantenconn.Open();
                SqlCommand sc = new SqlCommand("SELECT * from klanten WHERE ID =" + call_add_existingcust1_combobx_name.SelectedValue.ToString(), klantenconn);
                SqlDataReader Klantenreader;
                Klantenreader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID", typeof(Int16));
                dt.Columns.Add("voornaam", typeof(string));
                dt.Columns.Add("achternaam", typeof(string));
                dt.Columns.Add("email", typeof(string));
                dt.Columns.Add("telefoon", typeof(string));
                dt.Columns.Add("bedrijf", typeof(string));
                dt.Columns.Add("afdeling", typeof(string));
                dt.Load(Klantenreader);
                call_add_existingcust1_lbl_bedrijf.Text = dt.Rows[0]["bedrijf"].ToString();
                call_add_existingcust1_lbl_telefoon.Text = dt.Rows[0]["telefoon"].ToString();
                call_add_existingcust1_lbl_afdeling.Text = dt.Rows[0]["afdeling"].ToString();
                call_add_existingcust1_lbl_email.Text = dt.Rows[0]["email"].ToString();

                klantenconn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops: \n" + ex);
            }
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            // Incident toevoegen aan de database. Email sturen naar gebruiker met call nummer
            // Verbinding opzetten naar MS SQL server, en database kiezen.
            SqlConnection conn = new SqlConnection("Server=DENNIS-PC\\SQLEXPRESS;Database=helpdesk;Trusted_Connection=True;");

            // Verbinding tot stand proberen te brengen, Messagebox laten zien als er een foutmelding naar voren komt.
            try
            {
                conn.Open();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            // Callnummer genereren.
            Random rnd = new Random();
            int callnumber = rnd.Next(1, 1000000);
            // Query opstellen
            SqlCommand query1 = new SqlCommand("INSERT INTO call_details" +
                 "(callnummer, datum, naamklant, telefoonnummer, emailadres, probleemdetails, vraagvandeklant)" +
                "VALUES(@callnummer,@datum, @naamklant, @telefoonnummer, @emailadres, @probleemdetails, @vraagvandeklant)", conn);
            query1.Parameters.Add("@callnummer", SqlDbType.VarChar).Value = "ICT-Helpdesk-PUR" + callnumber.ToString();
            query1.Parameters.Add("@datum", SqlDbType.VarChar).Value = DateTime.Now.ToString();
            query1.Parameters.Add("@naamklant", SqlDbType.VarChar).Value = call_add_existingcust1_combobx_name.Text;
            query1.Parameters.Add("@telefoonnummer", SqlDbType.VarChar).Value = call_add_existingcust1_lbl_telefoon.Text;
            query1.Parameters.Add("@emailadres", SqlDbType.VarChar).Value = call_add_existingcust1_lbl_email.Text;
            query1.Parameters.Add("@probleemdetails", SqlDbType.VarChar, -1).Value = call_add_problemdetails_txtbox.Text;
            query1.Parameters.Add("@vraagvandeklant", SqlDbType.VarChar, -1).Value = call_add_customerquestion_txtbox.Text;


            // Query uitvoeren
            // email sturen naar klant met callnummer
            try
            {
                var fromAddress = new MailAddress("helpdeskpur@gmail.com", "ICT Helpdesk Purmerend");
                var toAddress = new MailAddress(call_add_existingcust1_lbl_email.Text, call_add_existingcust1_combobx_name.Text);
                const string fromPassword = "Ict00012";
                const string subject = "Incident Melding ICT Helpdesk Purmerend";
                string body = string.Format("Beste " + call_add_existingcust1_combobx_name.Text + ", \n\n U ontvangt deze e-mail omdat u met een verzoek bij onze helpdesk bent geweest. \n\n Uw verzoek is geregisteerd onder het nummer ICT-Helpdesk-PUR000" + callnumber.ToString() + "\n\n Houdt dit nummer bij de hand wanneer u contact met ons op neemt\n\n Met vriendelijke groet,\n\n De ICT Helpdesk Purmerend\n\n E-mail: helpdeskpur@gmail.com \n Telefoonnummer: 5304 ");

                /*
                // This piece of code is to auto accept expired ssl certificates.
                ServicePointManager.ServerCertificateValidationCallback =
                delegate (object sender1, X509Certificate certificate, X509Chain chain,
                       SslPolicyErrors sslPolicyErrors)
                   { return true; }; 
                   
                */

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                    Timeout = 10000
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                    try
                    {
                        {
                            smtp.Send(message);
                        }
                    }
                    catch (SmtpFailedRecipientException errornotsend)
                    {
                        MessageBox.Show(errornotsend.ToString());
                    }
            }
            catch (Exception mailerror)
            {
                MessageBox.Show(mailerror.ToString());
            }
            //
            try
            {
                query1.ExecuteNonQuery();
                MessageBox.Show("Het incident is aangemaakt. Er is een e-mail naar de klant gestuurd met het call nummer ICT-Helpdesk-PUR" + callnumber.ToString(), "",
                    MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
                // Foutmelding mailen naar programmeur
                try
                {
                    var fromAddress = new MailAddress("helpdeskpur@gmail.com", "ICT Helpdesk Purmerend");
                    var toAddress = new MailAddress(call_add_existingcust1_lbl_email.Text, call_add_existingcust1_combobx_name.Text);
                    const string fromPassword = "Ict00012";
                    const string subject = "Foutmelding Helpdesk";
                    string body = string.Format("Beste " + call_add_existingcust1_combobx_name.Text + ", \n\n U ontvangt deze e-mail omdat u met een verzoek bij onze helpdesk bent geweest. \n\n Uw verzoek is geregisteerd onder het nummer ICT-Helpdesk-PUR000" + callnumber.ToString() + "\n\n Houdt dit nummer bij de hand wanneer u contact met ons op neemt\n\n Met vriendelijke groet,\n\n De ICT Helpdesk Purmerend\n\n E-mail: helpdeskpur@gmail.com \n Telefoonnummer: 5304 ");

                    /*
                    // This piece of code is to auto accept expired ssl certificates.
                    ServicePointManager.ServerCertificateValidationCallback =
                    delegate (object sender1, X509Certificate certificate, X509Chain chain,
                           SslPolicyErrors sslPolicyErrors)
                       { return true; }; 

                    */

                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                        Timeout = 10000
                    };
                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = subject,
                        Body = body
                    })
                        try
                        {
                            {
                                smtp.Send(message);
                            }
                        }
                        catch (SmtpFailedRecipientException errornotsend)
                        {
                            MessageBox.Show(errornotsend.ToString());
                        }
                }
                catch (Exception mailerror)
                {
                    MessageBox.Show(mailerror.ToString());
                }
            }
            this.Close();
        }

        private void call_add_newcust_btn_CheckedChanged(object sender, EventArgs e)
        {
            call_add_grpbox_newcustomer.Show();
            call_add_grpbox_existingcustomer.Visible = false;
        }

        private void call_add_existingcust1_btn_CheckedChanged(object sender, EventArgs e)
        {
            call_add_grpbox_existingcustomer.Show();
            call_add_grpbox_newcustomer.Visible = false;

            // Klant naam ophalen en in combobox weergeven
            try
            {
                SqlConnection klantenconn = new SqlConnection(@"Data Source=DENNIS-PC\SQLEXPRESS;Initial Catalog=helpdesk;Integrated Security=True");
                klantenconn.Open();
                SqlCommand sc = new SqlCommand("SELECT * from klanten", klantenconn);
                SqlDataReader Klantenreader;
                Klantenreader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID", typeof(Int16));
                dt.Columns.Add("voornaam", typeof(string));
                dt.Columns.Add("achternaam", typeof(string));
                dt.Columns.Add("email", typeof(string));
                dt.Columns.Add("telefoon", typeof(string));
                dt.Columns.Add("bedrijf", typeof(string));
                dt.Columns.Add("afdeling", typeof(string));
                dt.Load(Klantenreader);

                call_add_existingcust1_combobx_name.ValueMember = "ID";
                call_add_existingcust1_combobx_name.DisplayMember = "voornaam";
                call_add_existingcust1_combobx_name.DataSource = dt;
                klantenconn.Close();
                //MessageBox.Show(call_add_existingcust1_combobx_name.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops: \n\n" + ex);
            }
        }

        private void call_add_Load(object sender, EventArgs e)
        {
            label14.Text = call_add_problemdetails_txtbox.MaxLength.ToString();
            label15.Text = call_add_problemdetails_txtbox.MaxLength.ToString();
        }

        private void call_add_problemdetails_txtbox_TextChanged(object sender, EventArgs e)
        {
            var max = call_add_problemdetails_txtbox.MaxLength;
            var length = call_add_problemdetails_txtbox.Text.Length;
            var total = max - length;

            label12.Text = total.ToString();
        }

        private void call_add_customerquestion_txtbox_TextChanged(object sender, EventArgs e)
        {
            var max = call_add_customerquestion_txtbox.MaxLength;
            var length = call_add_customerquestion_txtbox.Text.Length;
            var total = max - length;

            label17.Text = total.ToString();
        }
    }
}

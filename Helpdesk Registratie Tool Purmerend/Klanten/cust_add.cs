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

namespace Helpdesk_Registratie_Tool_Purmerend.Klanten
{
    public partial class cust_add : Form
    {
        public cust_add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=HELPDESK-PC\SQLEXPRESS;Initial Catalog=helpdesk;Integrated Security=True");

                string sql = "INSERT INTO klanten (aanhef, voornaam, achternaam, adres, email, telefoon, bedrijf, afdeling, opmerkingen) values (@aanhef, @voornaam, @achternaam, @adres, @email, @telefoon, @bedrijf, @afdeling, @opmerkingen)";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@aanhef", SqlDbType.VarChar);
                cmd.Parameters.Add("@voornaam", SqlDbType.VarChar);
                cmd.Parameters.Add("@achternaam", SqlDbType.VarChar);
                cmd.Parameters.Add("@adres", SqlDbType.VarChar);
                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters.Add("@telefoon", SqlDbType.VarChar);
                cmd.Parameters.Add("@bedrijf", SqlDbType.VarChar);
                cmd.Parameters.Add("@afdeling", SqlDbType.VarChar);
                cmd.Parameters.Add("@opmerkingen", SqlDbType.VarChar);
                if (cust_add_rdiobtn_dhr.Checked == true)
                {
                    cmd.Parameters["@aanhef"].Value = "Dhr.";
                }
                else
                {
                    cmd.Parameters["@aanhef"].Value = "Mevr.";
                }

                //cmd.Parameters["@aanhef"].Value = _;
                cmd.Parameters["@voornaam"].Value = cust_add_txtbx_voornaam.Text;
                cmd.Parameters["@achternaam"].Value = cust_add_txtbx_achternaam.Text;
                cmd.Parameters["@adres"].Value = cust_add_txtbx_adres.Text;
                cmd.Parameters["@email"].Value = cust_add_txtbx_email.Text;
                cmd.Parameters["@telefoon"].Value = cust_add_txtbx_telefoon.Text;
                cmd.Parameters["@bedrijf"].Value = cust_add_txtbx_bedrijf.Text;
                cmd.Parameters["@afdeling"].Value = cust_add_txtbx_afdeling.Text;
                cmd.Parameters["@opmerkingen"].Value = cust_add_txtbx_opmerkingen.Text;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Klant is toegevoegd aan de database.");
                cust_add_txtbx_opmerkingen.Clear();
                // cust_add_txtbx_aanhef.Clear();
                cust_add_txtbx_voornaam.Clear();
                cust_add_txtbx_achternaam.Clear();
                cust_add_txtbx_adres.Clear();
                cust_add_txtbx_email.Clear();
                cust_add_txtbx_telefoon.Clear();
                cust_add_txtbx_bedrijf.Clear();
                cust_add_txtbx_afdeling.Clear();
                cust_add_txtbx_opmerkingen.Clear();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void cust_add_Load(object sender, EventArgs e)
        {

        }

        private void cust_add_btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


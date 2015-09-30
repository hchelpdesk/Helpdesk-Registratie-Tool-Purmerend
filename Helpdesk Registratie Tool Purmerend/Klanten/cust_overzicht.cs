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
    public partial class cust_overzicht : Form
    {
        public cust_overzicht()
        {
            InitializeComponent();
        }

        private void cust_overzicht_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            string connectionString = (@"Data Source=DENNIS-PC\SQLEXPRESS;Initial Catalog=helpdesk;Integrated Security=True");
            string sql = "SELECT ID, aanhef, voornaam, achternaam, adres, email, telefoon, bedrijf, afdeling, opmerkingen  FROM klanten";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Authors_table");
            connection.Close();
            cust_overzicht_dgv1.DataSource = ds;
            cust_overzicht_dgv1.DataMember = "Authors_table";
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

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
    public partial class call_overzicht : Form
    {
        public call_overzicht()
        {
            InitializeComponent();
        }

       private void call_overzicht_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            string connectionString = (@"Data Source=DENNIS-PC\SQLEXPRESS;Initial Catalog=helpdesk;Integrated Security=True");
            string sql = "SELECT ID, naam, klas, product, ingeleverd, tijddatum, tijddatumingeleverd  FROM uitlenen";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Authors_table");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Authors_table";
        }
    }
}

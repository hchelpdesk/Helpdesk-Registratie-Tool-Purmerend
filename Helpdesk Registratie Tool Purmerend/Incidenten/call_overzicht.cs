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
            /*
            SqlConnection conn = new SqlConnection();
            string connectionString = (@"Data Source=DENNIS-PC\SQLEXPRESS;Initial Catalog=helpdesk;Integrated Security=True");
            string sql = "SELECT * FROM call_details";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Authors_table");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Authors_table";
            */
            SqlConnection conn = new SqlConnection();
            string connectionString = (@"Data Source=DENNIS-PC\SQLEXPRESS;Initial Catalog=helpdesk;Integrated Security=True");
            string sql = "SELECT * FROM call_details";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet dbDataSet1 = new DataSet();
            connection.Open();
            dataadapter.Fill(dbDataSet1, "calldetails");

            //Set AutoGenerateColumns False
            dataGridView1.AutoGenerateColumns = false;

            //Set Columns Count
            dataGridView1.ColumnCount = 5;

            //Add Columns
            dataGridView1.Columns[0].Name = "callnummer"; // name
            dataGridView1.Columns[0].HeaderText = "Call Nummer"; // header text
            dataGridView1.Columns[0].DataPropertyName = "callnummer"; // field name

            dataGridView1.Columns[1].HeaderText = "Datum";
            dataGridView1.Columns[1].Name = "datum";
            dataGridView1.Columns[1].DataPropertyName = "datum";

            dataGridView1.Columns[2].Name = "naamklant";
            dataGridView1.Columns[2].HeaderText = "Naam Klant";
            dataGridView1.Columns[2].DataPropertyName = "naamklant";

            dataGridView1.Columns[3].Name = "emailadres";
            dataGridView1.Columns[3].HeaderText = "E-mailadres";
            dataGridView1.Columns[3].DataPropertyName = "emailadres";

            dataGridView1.Columns[4].Name = "probleemdetails";
            dataGridView1.Columns[4].HeaderText = "Probleem Details";
            dataGridView1.Columns[4].DataPropertyName = "probleemdetails";

            dataGridView1.Columns[4].Name = "vraagvandeklant";
            dataGridView1.Columns[4].HeaderText = "Vraag van de Klant";
            dataGridView1.Columns[4].DataPropertyName = "vraagvandeklant";



            dataGridView1.DataSource = dbDataSet1;
            dataGridView1.DataMember = "calldetails";
        }
    }
}

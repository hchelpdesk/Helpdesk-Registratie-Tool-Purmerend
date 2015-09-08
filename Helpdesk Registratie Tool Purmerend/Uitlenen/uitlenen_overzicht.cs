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

namespace Helpdesk_Registratie_Tool_Purmerend.Uitlenen
{
    public partial class uitlenen_overzicht : Form
    {
        public uitlenen_overzicht()
        {
            InitializeComponent();
        }

        private void uitlenen_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection();
            string connectionString = (@"Data Source=HELPDESK-PC\SQLEXPRESS;Initial Catalog=helpdesk;Integrated Security=True");
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

        private void uitlenen_btn_addnew_Click(object sender, EventArgs e)
        {
            uitlenen_toevoegen NewMDIChild = new uitlenen_toevoegen();
            NewMDIChild.MdiParent = this.MdiParent;
            NewMDIChild.Show();
        }
        private void ShowData()
        {
            DataSet DS = new DataSet();
            SqlConnection conn = new SqlConnection(@"Data Source=HELPDESK-PC\SQLEXPRESS;Initial Catalog=helpdesk;Integrated Security=True");
            conn.Open();
            string sql = "SELECT ID, naam, klas, product, ingeleverd, tijddatum, tijddatumingeleverd  FROM uitlenen";
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            dataadapter.Fill(DS, "Authors_table");
            dataGridView1.DataSource = DS.Tables["Authors_table"];
            conn.Close();
        }
        private void uitlenen_btn_returned_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = dataGridView1.CurrentCell.RowIndex;
                int columnindex = dataGridView1.CurrentCell.ColumnIndex;
                string value = dataGridView1.Rows[rowindex].Cells[columnindex].Value.ToString();
                var currenttime = DateTime.Now;
                SqlConnection conn = new SqlConnection(@"Data Source=HELPDESK-PC\SQLEXPRESS;Initial Catalog=helpdesk;Integrated Security=True");

                // Als er op de knop Teruggebracht word de drukt
                // Wordt de database geupdatët met datum en tijd
                // Controle om te kijken of tijddatumingeleverd leeg is in database.
                // SQL query string
                string sqlcheck = "SELECT tijddatumingeleverd FROM uitlenen WHERE ID =" + value;
                conn.Open();
                SqlCommand checkcmd = new SqlCommand(sqlcheck, conn);
                SqlDataReader reader = checkcmd.ExecuteReader();
                reader.Read();

                if (reader["tijddatumingeleverd"] != DBNull.Value)
                {
                    MessageBox.Show("Het product is al ingeleverd!");
                    reader.Close();
                }
                else {
                    conn.Close();
                    string sql = "UPDATE uitlenen SET tijddatumingeleverd ='" + currenttime + "' WHERE ID =" + value;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.Add("@tijddatumingeleverd", SqlDbType.DateTime);
                    cmd.Parameters["@tijddatumingeleverd"].Value = DateTime.Now;
                    ShowData();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Het product is ingeleverd bij de Helpdesk.");
                    conn.Close();
                }

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}

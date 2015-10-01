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

namespace Helpdesk_Registratie_Tool_Purmerend.Magazijn
{
    public partial class magazijn_overzicht : Form
    {
        public magazijn_overzicht()
        {
            InitializeComponent();
        }

        private void magazijn_overzicht_Load(object sender, EventArgs e)
        {
            // Verbinding opzetten naar MS SQL server, en database kiezen.
            SqlConnection conn = new SqlConnection("Server=DENNIS-PC\\SQLEXPRESS;Database=helpdesk;Trusted_Connection=True;");

            // Verbinding tot stand proberen te brengen, anders Messagebox laten zien met de foutmelding.
            try
            {
                conn.Open();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            
            string sql = "SELECT * FROM magazijn_overzicht";
            
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            
            dataadapter.Fill(ds, "magazijnoverzicht");
            conn.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "magazijnoverzicht";
        }
        

 private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(e.RowIndex.ToString());
        }
    }
}

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
            if (call_add_newcust.Checked)
            {
                
                
            }else if (call_add_existingcust.Checked)
            {
                
            }

        }

        private void call_add_grpbox_customerdetails_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            call_add_cust_existingdetails.Visible = false;
            call_add_grpbox_customerdetails.Visible = true;
            call_add_grpbox_customerdetails.Show();
            SqlConnection conn = new SqlConnection();
            string connectionString = (@"Data Source=HELPDESK-PC\SQLEXPRESS;Initial Catalog=helpdesk;Integrated Security=True");
            string sql = "SELECT naam, klas, product, ingeleverd, tijddatum, tijddatumingeleverd  FROM uitlenen";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Authors_table");
            connection.Close();
            //dataGridView1.DataSource = ds;
            //dataGridView1.DataMember = "Authors_table";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            call_add_grpbox_customerdetails.Visible = false;
            call_add_cust_existingdetails.Visible = true;
            call_add_cust_existingdetails.Show();

        }
    }
}

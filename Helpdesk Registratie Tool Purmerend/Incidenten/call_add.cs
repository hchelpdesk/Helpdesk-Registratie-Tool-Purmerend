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


            }
            else if (call_add_existingcust.Checked)
            {

            }

        }

        private void call_add_grpbox_customerdetails_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            call_add_grpbox_existingcustomer.Show();
            call_add_grpbox_newcustomer.Visible = false;

            SqlConnection conn = new SqlConnection(@"Data Source=DENNIS-PC\SQLEXPRESS;Initial Catalog=helpdesk;Integrated Security=True");
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM klanten", conn);
            da.Fill(ds, "klanten");
            call_add_existingcust1_combobx_name.DisplayMember = "" ;
            call_add_existingcust1_combobx_name.ValueMember = "voornaam" + "achternaam";
            call_add_existingcust1_combobx_name.DataSource = ds.Tables["klanten"];
            //uitlenen_toevoegen_fullname_SelectedIndexChanged(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            call_add_grpbox_newcustomer.Show();
            call_add_grpbox_existingcustomer.Visible = false;


        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Helpdesk_Registratie_Tool_Purmerend.Magazijn
{
    public partial class magazijn_invoeren : Form
    {
        public magazijn_invoeren()
        {
            InitializeComponent();
        }

        private void magazijn_invoeren_Load(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conn = new SqlConnection(@"Data Source=DENNIS-PC\SQLEXPRESS;Initial Catalog=helpdesk;Integrated Security=True");
                conn.Open();
                SqlCommand sc = new SqlCommand("SELECT ID, categorie from magazijncategorieen", conn);
                SqlDataReader reader;

                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID", typeof(string));
                dt.Columns.Add("categorie", typeof(string));
                dt.Load(reader);

                magazijn_invoer_combobx_categorie.ValueMember = "ID";
                magazijn_invoer_combobx_categorie.DisplayMember = "categorie";
                magazijn_invoer_combobx_categorie.DataSource = dt;

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Oeps zomer: \n" + ex);
            }
        }

        private void magazijn_invoer_combobx_categorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ID van geselecteerde waarde weergeven in Label2
            label2.Text = "Huidige ID : " + magazijn_invoer_combobx_categorie.SelectedValue.ToString();
            magazijn_invoer_combobx_subcategorie.Items.Clear();
            magazijn_invoer_combobx_subcategorie.Visible = true;
            magazijn_invoer_combobx_subcategorie.Show();

            SqlConnection conn = new SqlConnection(@"Data Source=DENNIS-PC\SQLEXPRESS;Initial Catalog=helpdesk;Integrated Security=True");
            conn.Open();
            SqlCommand sc = new SqlCommand("SELECT subcategorie ,subcategorie1,subcategorie2,subcategorie3,subcategorie4,subcategorie5,subcategorie6,subcategorie7,subcategorie8,subcategorie9 FROM magazijncategorieen WHERE ID = " + magazijn_invoer_combobx_categorie.SelectedValue.ToString(), conn);

            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Columns.Add("subcategorie", typeof(string));
            dt.Columns.Add("subcategorie1", typeof(string));
            dt.Columns.Add("subcategorie2", typeof(string));
            dt.Columns.Add("subcategorie3", typeof(string));
            dt.Columns.Add("subcategorie4", typeof(string));
            dt.Columns.Add("subcategorie5", typeof(string));
            dt.Columns.Add("subcategorie6", typeof(string));
            dt.Columns.Add("subcategorie7", typeof(string));
            dt.Columns.Add("subcategorie8", typeof(string));
            dt.Columns.Add("subcategorie9", typeof(string));
            
            

            dt.Load(reader);

            foreach (DataRow row in dt.Rows)
            {

                var subcategorie = row["subcategorie"];
                var subcategorie1 = row["subcategorie1"];
                var subcategorie2 = row["subcategorie2"];
                var subcategorie3 = row["subcategorie3"];
                var subcategorie4 = row["subcategorie4"];
                var subcategorie5 = row["subcategorie5"];
                var subcategorie6 = row["subcategorie6"];
                var subcategorie7 = row["subcategorie7"];
                var subcategorie8 = row["subcategorie8"];
                var subcategorie9 = row["subcategorie9"];

                if (subcategorie != null)
                {
                    magazijn_invoer_combobx_subcategorie.Items.Add(row["subcategorie"].ToString());
                }
                if (row["subcategorie1"] != null)
                {
                    magazijn_invoer_combobx_subcategorie.Items.Add(row["subcategorie1"].ToString());
                }
                if (subcategorie2 != null)
                {
                    magazijn_invoer_combobx_subcategorie.Items.Add(row["subcategorie2"].ToString());
                }
                if (subcategorie3 != null)
                {
                    magazijn_invoer_combobx_subcategorie.Items.Add(row["subcategorie3"].ToString());
                }
                if (subcategorie4 != null)
                {
                    magazijn_invoer_combobx_subcategorie.Items.Add(row["subcategorie4"].ToString());
                }
                if (subcategorie5 != null)
                {
                    magazijn_invoer_combobx_subcategorie.Items.Add(row["subcategorie5"].ToString());
                }
                if (subcategorie6 != null)
                {
                    magazijn_invoer_combobx_subcategorie.Items.Add(row["subcategorie6"].ToString());
                }
                if (subcategorie7 != null)
                {
                    magazijn_invoer_combobx_subcategorie.Items.Add(row["subcategorie7"].ToString());
                }
                if (subcategorie8 != null)
                {
                    magazijn_invoer_combobx_subcategorie.Items.Add(row["subcategorie8"].ToString());
                }
                if (subcategorie9 != null)
                {
                    magazijn_invoer_combobx_subcategorie.Items.Add(row["subcategorie9"].ToString());
                }
               

            }
            conn.Close();

        }

      
    }
}

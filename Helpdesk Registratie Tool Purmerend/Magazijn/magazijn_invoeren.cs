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

                SqlConnection conn = new SqlConnection(@"Data Source=HELPDESK-PC\SQLEXPRESS;Initial Catalog=helpdesk;Integrated Security=True");
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
                MessageBox.Show("Er ging iets fout : \n" + ex);
            }
        }

        private void magazijn_invoer_combobx_categorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ID van geselecteerde waarde weergeven in Label2
            label2.Text = "Huidige ID : " + magazijn_invoer_combobx_categorie.SelectedValue.ToString();
            magazijn_invoer_combobx_subcategorie.Items.Clear();
            magazijn_invoer_combobx_subcategorie.Visible = true;
            magazijn_invoer_combobx_subcategorie.Show();

            SqlConnection conn = new SqlConnection(@"Data Source=HELPDESK-PC\SQLEXPRESS;Initial Catalog=helpdesk;Integrated Security=True");
            conn.Open();
            SqlCommand sc = new SqlCommand("SELECT subcategorie,subcategorie1,subcategorie2,subcategorie3,subcategorie4,subcategorie5,subcategorie6,subcategorie7,subcategorie8,subcategorie9 ,subcategorie10,subcategorie11 FROM magazijncategorieen WHERE ID = " + magazijn_invoer_combobx_categorie.SelectedValue.ToString(), conn);

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
            dt.Columns.Add("subcategorie10", typeof(string));
            dt.Columns.Add("subcategorie11", typeof(string));

            dt.Load(reader);

            foreach (DataRow row in dt.Rows)
            {

                magazijn_invoer_combobx_subcategorie.Items.Add(row["subcategorie"].ToString());
                magazijn_invoer_combobx_subcategorie.Items.Add(row["subcategorie1"].ToString());
                magazijn_invoer_combobx_subcategorie.Items.Add(row["subcategorie2"].ToString());
                magazijn_invoer_combobx_subcategorie.Items.Add(row["subcategorie3"].ToString());
                magazijn_invoer_combobx_subcategorie.Items.Add(row["subcategorie4"].ToString());
                magazijn_invoer_combobx_subcategorie.Items.Add(row["subcategorie5"].ToString());
                magazijn_invoer_combobx_subcategorie.Items.Add(row["subcategorie6"].ToString());
                magazijn_invoer_combobx_subcategorie.Items.Add(row["subcategorie7"].ToString());
                magazijn_invoer_combobx_subcategorie.Items.Add(row["subcategorie8"].ToString());
                magazijn_invoer_combobx_subcategorie.Items.Add(row["subcategorie9"].ToString());
                magazijn_invoer_combobx_subcategorie.Items.Add(row["subcategorie10"].ToString());
                magazijn_invoer_combobx_subcategorie.Items.Add(row["subcategorie11"].ToString());
            }
            conn.Close();

        }

    }
}

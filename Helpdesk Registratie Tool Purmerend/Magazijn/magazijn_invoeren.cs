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
                MessageBox.Show("Oeps zomer: \n" + ex);
            }
        }

        private void magazijn_invoer_combobx_categorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ID van geselecteerde waarde weergeven in Label2
            label2.Text = "Huidige ID :" + magazijn_invoer_combobx_categorie.SelectedValue.ToString();
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
            dt.Load(reader);

            magazijn_invoer_combobx_subcategorie.ValueMember = "subcategorie";
            magazijn_invoer_combobx_subcategorie.DisplayMember = "subcategorie";
            magazijn_invoer_combobx_subcategorie.DataSource = dt;

            conn.Close();
        }

    }
}

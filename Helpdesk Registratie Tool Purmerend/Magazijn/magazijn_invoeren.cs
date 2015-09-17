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
                SqlCommand sc = new SqlCommand("SELECT ID, categorie from magazijn_categorie", conn);
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
                MessageBox.Show("Oops S.W.R.: \n" + ex);
            }
            try
            {

                SqlConnection conn_memory = new SqlConnection(@"Data Source=DENNIS-PC\SQLEXPRESS;Initial Catalog=helpdesk;Integrated Security=True");
                conn_memory.Open();
                SqlCommand sc = new SqlCommand("SELECT * from memorytypes", conn_memory);
                SqlDataReader reader;

                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID", typeof(string));
                dt.Columns.Add("standaardnaam", typeof(string));
                dt.Load(reader);

                magazijn_invoeren_combobx_geheugentype.ValueMember = "ID";

                magazijn_invoeren_combobx_geheugentype.DisplayMember = "standaardnaam";
                magazijn_invoeren_combobx_geheugentype.DataSource = dt;

                conn_memory.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops S.W.R. : \n" + ex);
            }
        }

        private void magazijn_invoer_combobx_categorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ID van geselecteerde waarde weergeven in Label2
            //label2.Text = "Huidige ID : " + magazijn_invoer_combobx_categorie.SelectedValue.ToString();
            magazijn_invoer_combobx_subcategorie.Items.Clear();
            magazijn_invoer_combobx_subcategorie.Visible = true;
            magazijn_invoer_combobx_subcategorie.Show();

            SqlConnection conn = new SqlConnection(@"Data Source=DENNIS-PC\SQLEXPRESS;Initial Catalog=helpdesk;Integrated Security=True");
            conn.Open();
            SqlCommand sc = new SqlCommand("SELECT subcategorie FROM magazijn_subcategorie WHERE subcategorieid = " + magazijn_invoer_combobx_categorie.SelectedValue.ToString(), conn);

            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Columns.Add("subcategorie", typeof(string));
            dt.Load(reader);
            foreach (DataRow row in dt.Rows)
            {

                var subcategorie = row["subcategorie"];


                if (subcategorie != null)
                {
                    magazijn_invoer_combobx_subcategorie.Items.Add(row["subcategorie"].ToString()); 
                }
            }
            conn.Close();
        }
    }
}

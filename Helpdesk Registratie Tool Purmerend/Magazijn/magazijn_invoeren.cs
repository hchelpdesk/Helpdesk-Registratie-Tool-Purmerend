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
            // TODO: This line of code loads data into the 'magazijnCategorie.magazijncategorieen' table. You can move, or remove it, as needed.
            //this.magazijncategorieenTableAdapter.Fill(this.magazijnCategorie.magazijncategorieen);
            // Dropdown list vullen met categorieën

        }

        private void magazijn_invoer_combobx_categorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            string connection = (@"Data Source=HELPDESK-PC\SQLEXPRESS;Initial Catalog=helpdesk;Integrated Security=True");
            string query = @"SELECT * from Table1, Table2"; //use your query!

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = new SqlCommand(query, connection);

            adapter.Fill(ds);
            //now you have 2 dataSets (or more).
            //lets bind dataSet to dropDownList:

            magazijn_invoer_combobx_categorie.DataSource = ds.Tables[0];

            dropdownlistid.DisplayMember = "name"; //write table`s column name, that one you want to show in dropDownList!

            dropdownlistid.ValueMember = "id"; //write table`s column name you want to have it a value (it can be the sameas DisplayMember!
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            magazijn_invoer_combobx_subcat.Visible = true;
            magazijn_invoer_combobx_subcat.Show();

        }
    }
}

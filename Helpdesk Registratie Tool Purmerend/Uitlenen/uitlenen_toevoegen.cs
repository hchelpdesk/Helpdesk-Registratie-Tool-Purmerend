using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Helpdesk_Registratie_Tool_Purmerend.Uitlenen
{
    public partial class uitlenen_toevoegen : Form
    {
        public uitlenen_toevoegen()
        {
            InitializeComponent();
        }

        private void uitlenen_toevoegen_Load(object sender, EventArgs e)
        {

            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=HELPDESK-PC\SQLEXPRESS;Initial Catalog=helpdesk;Integrated Security=True");
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM deelnemersICT", conn);
                da.Fill(ds, "uitlenen_toevoegen_fullname");
                uitlenen_toevoegen_fullname.DisplayMember = "Fullname";
                uitlenen_toevoegen_fullname.ValueMember = "Klas";
                uitlenen_toevoegen_fullname.DataSource = ds.Tables["uitlenen_toevoegen_fullname"];
                klas_lbl.Text = uitlenen_toevoegen_fullname.ValueMember.ToString();

                uitlenen_toevoegen_fullname_SelectedIndexChanged(sender, e);
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void uitlenen_toevoegen_fullname_SelectedIndexChanged(object sender, EventArgs e)
        {
            klas_lbl.Text = uitlenen_toevoegen_fullname.SelectedValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void uitlenen_toevoegen_btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=HELPDESK-PC\SQLEXPRESS;Initial Catalog=helpdesk;Integrated Security=True");

                string sql = "INSERT INTO uitlenen (naam, klas, product, ingeleverd, tijddatum) values (@uitlenen_toevoegen_fullname, @klas_lbl, @uitlenen_toevoegen_product_txtbox, @uitlenen_toevoegen_ingeleverd,@tijddatum)";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@uitlenen_toevoegen_fullname", SqlDbType.VarChar);
                cmd.Parameters.Add("@klas_lbl", SqlDbType.VarChar);
                cmd.Parameters.Add("@uitlenen_toevoegen_product_txtbox", SqlDbType.VarChar);
                cmd.Parameters.Add("@uitlenen_toevoegen_ingeleverd", SqlDbType.VarChar);
                cmd.Parameters.Add("@tijddatum", SqlDbType.DateTime);

                cmd.Parameters["@uitlenen_toevoegen_fullname"].Value = uitlenen_toevoegen_fullname.Text;
                cmd.Parameters["@klas_lbl"].Value = klas_lbl.Text;
                cmd.Parameters["@uitlenen_toevoegen_product_txtbox"].Value = uitlenen_toevoegen_product.Text;
                cmd.Parameters["@uitlenen_toevoegen_ingeleverd"].Value = uitlenen_toevoegen_ingeleverd.Text;
                cmd.Parameters["@tijddatum"].Value = DateTime.Now;


                cmd.ExecuteNonQuery();
                MessageBox.Show("Het product is geregistreerd nu op naam van " + uitlenen_toevoegen_fullname.Text + " geregistreerd.");
                Close();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

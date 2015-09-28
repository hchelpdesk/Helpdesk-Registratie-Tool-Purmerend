using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Helpdesk_Registratie_Tool_Purmerend.Magazijn
{
    public partial class magazijn_toevoegen : Form
    {

        public magazijn_toevoegen()
        {
            InitializeComponent();
        }
        private void magazijn_toevoegen_enkelproductoevoegen_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible = false;
        }

        private void magazijn_toevoevoegen_btn_productoevoegen_Click(object sender, EventArgs e)
        {
            // Kijken of Single of Multiple radiobutton is gekozen.
            if (magazijn_toevoegen_enkelproductoevoegen.Checked == true)
            {
                #region veldencheck_singleinsert 
                // Kijken of er geen velden leeg zijn.
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_singleinsert_aantal1.Text))
                {
                    MessageBox.Show("Vul een Aantal in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_singleinsert_merk1.Text))
                {
                    MessageBox.Show("Vul het Merk in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_singleinsert_type1.Text))
                {
                    MessageBox.Show("Vul het Type in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_singleinsert_aansluiting1.Text))
                {
                    MessageBox.Show("Vul het soort Aansluiting in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_singleinsert_functies1.Text))
                {
                    MessageBox.Show("Vul de Functie in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_singleinsert_product1.Text))
                {
                    MessageBox.Show("Vul het Product in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_singleinsert_geheugen1.Text))
                {
                    MessageBox.Show("Vul het geheugen (example: 1024) in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_singleinsert_combobx_didactisch.Text))
                {
                    MessageBox.Show("Kies of het Didactisch is of niet. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                #endregion
                else
                {
                    // Verbinding opzetten naar MS SQL server, en database kiezen.
                    SqlConnection conn_singleinsert = new SqlConnection("Server=DENNIS-PC\\SQLEXPRESS;Database=helpdesk;Trusted_Connection=True;");

                    // Verbinding tot stand proberen te brengen, anders Messagebox late zien met de foutmelding.
                    try
                    {
                        conn_singleinsert.Open();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.ToString());
                    }
                    #region singleinsert_query
                    // Query 1 opstellen
                    SqlCommand query1_singleinsert = new SqlCommand("INSERT INTO magazijn_overzicht" +
                         "(aantal, merk, type, aansluiting, functies, product, geheugensize, didactisch)" +
                        "VALUES(@aantal, @merk, @type, @aansluiting, @functies, @products, @geheugensize, @didactisch)");
                    query1_singleinsert.Parameters.Add("@aantal", SqlDbType.VarChar).Value = magazijn_toevoegen_singleinsert_aantal1.Text;
                    query1_singleinsert.Parameters.Add("@merk", SqlDbType.VarChar).Value = magazijn_toevoegen_singleinsert_merk1.Text;
                    query1_singleinsert.Parameters.Add("@type", SqlDbType.VarChar).Value = magazijn_toevoegen_singleinsert_type1.Text;
                    query1_singleinsert.Parameters.Add("@aansluiting", SqlDbType.VarChar).Value = magazijn_toevoegen_singleinsert_aansluiting1.Text;
                    query1_singleinsert.Parameters.Add("@functies", SqlDbType.VarChar).Value = magazijn_toevoegen_singleinsert_functies1.Text;
                    query1_singleinsert.Parameters.Add("@product", SqlDbType.VarChar).Value = magazijn_toevoegen_singleinsert_product1.Text;
                    query1_singleinsert.Parameters.Add("@geheugensize", SqlDbType.VarChar).Value = magazijn_toevoegen_singleinsert_geheugen1.Text;
                    query1_singleinsert.Parameters.Add("@didactisch", SqlDbType.VarChar).Value = magazijn_toevoegen_singleinsert_combobx_didactisch.Text;
                    #endregion
                    // DataTable Aanmaken met kolommen.
                    DataTable table_singleinsert = new DataTable();
                    table_singleinsert.Columns.Add("ID", typeof(string));
                    table_singleinsert.Columns.Add("aantal", typeof(int));
                    table_singleinsert.Columns.Add("merk", typeof(string));
                    table_singleinsert.Columns.Add("type", typeof(string));
                    table_singleinsert.Columns.Add("aansluiting", typeof(string));
                    table_singleinsert.Columns.Add("functies", typeof(string));
                    table_singleinsert.Columns.Add("product", typeof(string));
                    table_singleinsert.Columns.Add("geheugensize", typeof(int));
                    table_singleinsert.Columns.Add("didactisch", typeof(string));

                    // Enkele Rij met input verwerken.
                    table_singleinsert.Rows.Add("", magazijn_toevoegen_singleinsert_aantal1.Text, magazijn_toevoegen_singleinsert_merk1.Text, magazijn_toevoegen_singleinsert_type1.Text, magazijn_toevoegen_singleinsert_aansluiting1.Text, magazijn_toevoegen_singleinsert_functies1.Text, magazijn_toevoegen_singleinsert_product1.Text, magazijn_toevoegen_singleinsert_geheugen1.Text, magazijn_toevoegen_singleinsert_combobx_didactisch.Text);

                    try
                    {
                        SqlBulkCopy bulkCopy = new SqlBulkCopy
                        (
                        conn_singleinsert,
                        SqlBulkCopyOptions.TableLock |
                        SqlBulkCopyOptions.FireTriggers |
                        SqlBulkCopyOptions.UseInternalTransaction,
                        null
                        );

                        // set the destination table name
                        bulkCopy.DestinationTableName = "magazijn_overzicht";
                        //conn.Open();

                        // write the data in the "dataTable"
                        bulkCopy.WriteToServer(table_singleinsert);
                        conn_singleinsert.Close();
                        MessageBox.Show("Het product is met succes toegevoegd aan de database",
                        "Helpdesk Registratie Tool Purmerend",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.ToString());
                    }
                }
            }
            else if (magazijn_toevoegen_multipleinserttoevoegen.Checked == true)
            {
                #region veldencheck_multipleinsert
                // Kijken of er geen lege velden zijn.

                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_aantal1.Text))
                {
                    MessageBox.Show("Vul een Aantal in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_merk1.Text))
                {
                    MessageBox.Show("Vul het Merk in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_type1.Text))
                {
                    MessageBox.Show("Vul het Type in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_aansluiting1.Text))
                {
                    MessageBox.Show("Vul het soort Aansluiting in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_functies1.Text))
                {
                    MessageBox.Show("Vul de Functie in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_product1.Text))
                {
                    MessageBox.Show("Vul het Product in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_geheugensize1.Text))
                {
                    MessageBox.Show("Vul het geheugen (example: 1024) in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_combobx1.Text))
                {
                    MessageBox.Show("Kies of het Didactisch is of niet. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }

                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_aantal2.Text))
                {
                    MessageBox.Show("Vul een Aantal in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_merk2.Text))
                {
                    MessageBox.Show("Vul het Merk in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_type2.Text))
                {
                    MessageBox.Show("Vul het Type in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_aansluiting2.Text))
                {
                    MessageBox.Show("Vul het soort Aansluiting in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_functies2.Text))
                {
                    MessageBox.Show("Vul de Functie in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_product2.Text))
                {
                    MessageBox.Show("Vul het Product in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_geheugensize2.Text))
                {
                    MessageBox.Show("Vul het geheugen (example: 1024) in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_combobx2.Text))
                {
                    MessageBox.Show("Kies of het Didactisch is of niet. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }

                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_aantal3.Text))
                {
                    MessageBox.Show("Vul een Aantal in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_merk3.Text))
                {
                    MessageBox.Show("Vul het Merk in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_type3.Text))
                {
                    MessageBox.Show("Vul het Type in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_aansluiting3.Text))
                {
                    MessageBox.Show("Vul het soort Aansluiting in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_functies3.Text))
                {
                    MessageBox.Show("Vul de Functie in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_product3.Text))
                {
                    MessageBox.Show("Vul het Product in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_geheugensize3.Text))
                {
                    MessageBox.Show("Vul het geheugen (example: 1024) in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_combobx3.Text))
                {
                    MessageBox.Show("Kies of het Didactisch is of niet. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }

                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_aantal4.Text))
                {
                    MessageBox.Show("Vul een Aantal in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_merk4.Text))
                {
                    MessageBox.Show("Vul het Merk in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_type4.Text))
                {
                    MessageBox.Show("Vul het Type in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_aansluiting4.Text))
                {
                    MessageBox.Show("Vul het soort Aansluiting in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_functies4.Text))
                {
                    MessageBox.Show("Vul de Functie in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_product4.Text))
                {
                    MessageBox.Show("Vul het Product in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_geheugensize4.Text))
                {
                    MessageBox.Show("Vul het geheugen (example: 1024) in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_combobx4.Text))
                {
                    MessageBox.Show("Kies of het Didactisch is of niet. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }

                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_aantal5.Text))
                {
                    MessageBox.Show("Vul een Aantal in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_merk5.Text))
                {
                    MessageBox.Show("Vul het Merk in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_type5.Text))
                {
                    MessageBox.Show("Vul het Type in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_aansluiting5.Text))
                {
                    MessageBox.Show("Vul het soort Aansluiting in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_functies5.Text))
                {
                    MessageBox.Show("Vul de Functie in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_product5.Text))
                {
                    MessageBox.Show("Vul het Product in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_geheugensize5.Text))
                {
                    MessageBox.Show("Vul het geheugen (example: 1024) in. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                if (string.IsNullOrWhiteSpace(magazijn_toevoegen_multipleinsert_combobx5.Text))
                {
                    MessageBox.Show("Kies of het Didactisch is of niet. Veld mag niet leeg zijn.",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                #endregion
                else
                {

                    // Verbinding opzetten naar MS SQL server, en database kiezen.
                    SqlConnection conn = new SqlConnection("Server=DENNIS-PC\\SQLEXPRESS;Database=helpdesk;Trusted_Connection=True;");

                    // Verbinding tot stand proberen te brengen, anders Messagebox late zien met de foutmelding.
                    try
                    {
                        conn.Open();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.ToString());
                    }
                    #region multipleinsert_querys
                    // Query 1 opstellen
                    SqlCommand query1 = new SqlCommand("INSERT INTO magazijn_overzicht" +
                         "(aantal, merk, type, aansluiting, functies, product, geheugensize, didactisch)" +
                        "VALUES(@aantal, @merk, @type, @aansluiting, @functies, @products, @geheugensize, @didactisch)");
                    query1.Parameters.Add("@aantal", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_aantal1.Text;
                    query1.Parameters.Add("@merk", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_merk1.Text;
                    query1.Parameters.Add("@type", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_type1.Text;
                    query1.Parameters.Add("@aansluiting", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_aansluiting1.Text;
                    query1.Parameters.Add("@functies", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_functies1.Text;
                    query1.Parameters.Add("@product", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_product1.Text;
                    query1.Parameters.Add("@geheugensize", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_geheugensize1.Text;
                    query1.Parameters.Add("@didactisch", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_combobx1.Text;

                    // Query 2 opstellen
                    SqlCommand query2 = new SqlCommand("INSERT INTO magazijn_overzicht" +
                         "(aantal, merk, type, aansluiting, functies, product, geheugensize, didactisch)" +
                        "VALUES(@aantal, @merk, @type, @aansluiting, @functies, @products, @geheugensize, @didactisch)");
                    query2.Parameters.Add("@aantal", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_aantal2.Text;
                    query2.Parameters.Add("@merk", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_merk2.Text;
                    query2.Parameters.Add("@type", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_type2.Text;
                    query2.Parameters.Add("@aansluiting", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_aansluiting2.Text;
                    query2.Parameters.Add("@functies", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_functies2.Text;
                    query2.Parameters.Add("@product", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_product2.Text;
                    query2.Parameters.Add("@geheugensize", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_geheugensize2.Text;
                    query2.Parameters.Add("@didactisch", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_combobx2.Text;

                    // Query 3 opstellen
                    SqlCommand query3 = new SqlCommand("INSERT INTO magazijn_overzicht" +
                         "(aantal, merk, type, aansluiting, functies, product, geheugensize, didactisch)" +
                        "VALUES(@aantal, @merk, @type, @aansluiting, @functies, @products, @geheugensize, @didactisch)");
                    query3.Parameters.Add("@aantal", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_aantal3.Text;
                    query3.Parameters.Add("@merk", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_merk3.Text;
                    query3.Parameters.Add("@type", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_type3.Text;
                    query3.Parameters.Add("@aansluiting", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_aansluiting3.Text;
                    query3.Parameters.Add("@functies", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_functies3.Text;
                    query3.Parameters.Add("@product", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_product3.Text;
                    query3.Parameters.Add("@geheugensize", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_geheugensize3.Text;
                    query3.Parameters.Add("@didactisch", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_combobx3.Text;

                    // Query 4 opstellen
                    SqlCommand query4 = new SqlCommand("INSERT INTO magazijn_overzicht" +
                         "(aantal, merk, type, aansluiting, functies, product, geheugensize, didactisch)" +
                        "VALUES(@aantal, @merk, @type, @aansluiting, @functies, @products, @geheugensize, @didactisch)");
                    query4.Parameters.Add("@aantal", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_aantal4.Text;
                    query4.Parameters.Add("@merk", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_merk4.Text;
                    query4.Parameters.Add("@type", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_type4.Text;
                    query4.Parameters.Add("@aansluiting", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_aansluiting4.Text;
                    query4.Parameters.Add("@functies", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_functies4.Text;
                    query4.Parameters.Add("@product", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_product4.Text;
                    query4.Parameters.Add("@geheugensize", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_geheugensize4.Text;
                    query4.Parameters.Add("@didactisch", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_combobx4.Text;

                    // Query 5 opstellen
                    SqlCommand query5 = new SqlCommand("INSERT INTO magazijn_overzicht" +
                         "(aantal, merk, type, aansluiting, functies, product, geheugensize, didactisch)" +
                        "VALUES(@aantal, @merk, @type, @aansluiting, @functies, @products, @geheugensize, @didactisch)");
                    query5.Parameters.Add("@aantal", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_aantal5.Text;
                    query5.Parameters.Add("@merk", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_merk5.Text;
                    query5.Parameters.Add("@type", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_type5.Text;
                    query5.Parameters.Add("@aansluiting", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_aansluiting5.Text; query5.Parameters.Add("@functies", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_functies2.Text;
                    query5.Parameters.Add("@product", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_product5.Text;
                    query5.Parameters.Add("@geheugensize", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_geheugensize5.Text;
                    query5.Parameters.Add("@didactisch", SqlDbType.VarChar).Value = magazijn_toevoegen_multipleinsert_combobx5.Text;
                    #endregion


                    // Here we create a DataTable with four columns.
                    DataTable table = new DataTable();
                    table.Columns.Add("ID", typeof(string));
                    table.Columns.Add("aantal", typeof(int));
                    table.Columns.Add("merk", typeof(string));
                    table.Columns.Add("type", typeof(string));
                    table.Columns.Add("aansluiting", typeof(string));
                    table.Columns.Add("functies", typeof(string));
                    table.Columns.Add("product", typeof(string));
                    table.Columns.Add("geheugensize", typeof(int));
                    table.Columns.Add("didactisch", typeof(string));

                    // Here we add five DataRows.
                    table.Rows.Add("", magazijn_toevoegen_multipleinsert_aantal1.Text, magazijn_toevoegen_multipleinsert_merk1.Text, magazijn_toevoegen_multipleinsert_type1.Text, magazijn_toevoegen_multipleinsert_aansluiting1.Text, magazijn_toevoegen_multipleinsert_functies1.Text, magazijn_toevoegen_multipleinsert_product1.Text, magazijn_toevoegen_multipleinsert_geheugensize1.Text, magazijn_toevoegen_multipleinsert_combobx1.Text);
                    table.Rows.Add("", magazijn_toevoegen_multipleinsert_aantal2.Text, magazijn_toevoegen_multipleinsert_merk2.Text, magazijn_toevoegen_multipleinsert_type2.Text, magazijn_toevoegen_multipleinsert_aansluiting2.Text, magazijn_toevoegen_multipleinsert_functies2.Text, magazijn_toevoegen_multipleinsert_product2.Text, magazijn_toevoegen_multipleinsert_geheugensize2.Text, magazijn_toevoegen_multipleinsert_combobx2.Text);
                    table.Rows.Add("", magazijn_toevoegen_multipleinsert_aantal3.Text, magazijn_toevoegen_multipleinsert_merk3.Text, magazijn_toevoegen_multipleinsert_type3.Text, magazijn_toevoegen_multipleinsert_aansluiting3.Text, magazijn_toevoegen_multipleinsert_functies3.Text, magazijn_toevoegen_multipleinsert_product3.Text, magazijn_toevoegen_multipleinsert_geheugensize3.Text, magazijn_toevoegen_multipleinsert_combobx3.Text);
                    table.Rows.Add("", magazijn_toevoegen_multipleinsert_aantal4.Text, magazijn_toevoegen_multipleinsert_merk4.Text, magazijn_toevoegen_multipleinsert_type4.Text, magazijn_toevoegen_multipleinsert_aansluiting4.Text, magazijn_toevoegen_multipleinsert_functies4.Text, magazijn_toevoegen_multipleinsert_product4.Text, magazijn_toevoegen_multipleinsert_geheugensize4.Text, magazijn_toevoegen_multipleinsert_combobx4.Text);
                    table.Rows.Add("", magazijn_toevoegen_multipleinsert_aantal5.Text, magazijn_toevoegen_multipleinsert_merk5.Text, magazijn_toevoegen_multipleinsert_type5.Text, magazijn_toevoegen_multipleinsert_aansluiting5.Text, magazijn_toevoegen_multipleinsert_functies5.Text, magazijn_toevoegen_multipleinsert_product5.Text, magazijn_toevoegen_multipleinsert_geheugensize5.Text, magazijn_toevoegen_multipleinsert_combobx5.Text);

                    try
                    {
                        SqlBulkCopy bulkCopy =
               new SqlBulkCopy
               (
               conn,
               SqlBulkCopyOptions.TableLock |
               SqlBulkCopyOptions.FireTriggers |
               SqlBulkCopyOptions.UseInternalTransaction,
               null
               );

                        // set the destination table name
                        bulkCopy.DestinationTableName = "magazijn_overzicht";
                        //conn.Open();

                        // write the data in the "dataTable"
                        bulkCopy.WriteToServer(table);
                        conn.Close();
                        MessageBox.Show("De producten zijn met succes toegevoegd aan de database",
                        "Helpdesk Registratie Tool Purmerend",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.ToString());
                    }
                }
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Van MB -> GB = ÷ 1024 \n van GB -> MB = x 1024");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Van MB -> GB = ÷ 1024 \n van GB -> MB = x 1024");
        }

        private void magazijn_toevoegen_Load(object sender, EventArgs e)
        {

        }
    }
}

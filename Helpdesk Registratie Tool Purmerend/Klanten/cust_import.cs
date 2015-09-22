using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Helpdesk_Registratie_Tool_Purmerend.Klanten
{
    public partial class cust_import : Form
    {
        public cust_import()
        {
            InitializeComponent();
        }

        private void cust_import_btn_csv_browse_Click(object sender, EventArgs e)
        {

            cust_import_filedialog1.Filter = "Text File (*.txt) | *.txt| CSV files (*.csv) | *.csv";
            //cust_import_filedialog1.ShowDialog();
            if (cust_import_filedialog1.ShowDialog() == DialogResult.Cancel)
            {
                Close();
            }
            
            else
            {
                cust_import_txtbox_csv.Text = Path.GetFullPath(cust_import_filedialog1.FileName.ToString());
                cust_import_csv_path.Text = Path.GetFileName(cust_import_filedialog1.FileName);
            }
        }

        private void cust_import_csv_btn_import_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cust_import_txtbox_csv.Text))
            {
                MessageBox.Show("Geen bestand gekozen. Kies een .CSV bestand en probeer het opnieuw");
            }
            else
            {
                var result = MessageBox.Show("Deze actie laadt alle klanten uit bestand " + cust_import_csv_path.Text);
                string text = File.ReadAllText(cust_import_txtbox_csv.Text, Encoding.Default);
                File.WriteAllText(cust_import_txtbox_csv.Text, text, Encoding.BigEndianUnicode);
                if (result == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection((@"Data Source=DENNIS-PC\SQLEXPRESS;Initial Catalog=helpdesk;Integrated Security=True"));
                    string filepath = cust_import_filedialog1.FileName.ToString();
                    StreamReader sr = new StreamReader(filepath);
                    string line = sr.ReadLine();
                    string[] value = line.Split(',');
                    DataTable dt = new DataTable();
                    DataRow row;
                    foreach (string dc in value)
                    {
                        dt.Columns.Add(new DataColumn(dc));
                    }

                    while (!sr.EndOfStream)
                    {
                        value = sr.ReadLine().Split(',');
                        if (value.Length == dt.Columns.Count)
                        {
                            row = dt.NewRow();
                            row.ItemArray = value;
                            dt.Rows.Add(row);
                        }
                    }
                    SqlBulkCopy bc = new SqlBulkCopy(con.ConnectionString, SqlBulkCopyOptions.TableLock);
                    bc.DestinationTableName = "klanten";
                    bc.BatchSize = dt.Rows.Count;
                    con.Open();
                    bc.WriteToServer(dt);
                    bc.Close();
                    con.Close();
                    MessageBox.Show("Klanten zijn succesvol geimporteerd in de klanten database.");
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
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
            cust_import_filedialog1.Filter = "CSV files (*.csv) | *.csv| Text Files (*.txt) | *.txt";
            cust_import_filedialog1.ShowDialog();
            cust_import_txtbox_csv.Text = cust_import_filedialog1.FileName.ToString();
            cust_import_csv_path.Text = System.IO.Path.GetFileName(cust_import_filedialog1.FileName);
        }

        private void cust_import_csv_btn_import_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deze actie laadt alle klanten uit bestand " + cust_import_csv_path.Text);
            if (result == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection((@"Data Source=HELPDESK-PC\SQLEXPRESS;Initial Catalog=helpdesk;Integrated Security=True"));
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
}

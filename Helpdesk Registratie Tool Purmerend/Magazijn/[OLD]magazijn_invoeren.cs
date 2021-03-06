﻿using System;
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
            // geheugen invullen vanaf slider
            magazijn_invoer_txtbox_geheugenamount.Text = magazijn_invoer_memoryslide.Value.ToString();
            // Toegevoegd op datum invullen
            magazijn_invoer_txtbox_toegevoegdop.Text = DateTime.Today.ToString("dd-MM-yyyy");
            try
            {
                SqlConnection categorieconn = new SqlConnection(@"Data Source=DENNIS-PC\SQLEXPRESS;Initial Catalog=helpdesk;Integrated Security=True");
                categorieconn.Open();
                SqlCommand sc = new SqlCommand("SELECT ID, categorie from magazijn_categorie", categorieconn);
                SqlDataReader Categoriereader;
                Categoriereader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID", typeof(string));
                dt.Columns.Add("categorie", typeof(string));
                dt.Load(Categoriereader);

                magazijn_invoer_combobx_categorie.ValueMember = "ID";
                magazijn_invoer_combobx_categorie.DisplayMember = "categorie";
                magazijn_invoer_combobx_categorie.DataSource = dt;
                categorieconn.Close();
            }
            catch (Exception ex)
            {   
                MessageBox.Show("Oops: \n" + ex);
            }
            // Geheugen Types Uit de Database halen.
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

                magazijn_invoer_combobx_geheugentype.ValueMember = "ID";
                magazijn_invoer_combobx_geheugentype.DisplayMember = "standaardnaam";
                magazijn_invoer_combobx_geheugentype.DataSource = dt;
                magazijn_invoer_combobx_geheugenslot.ValueMember = "ID";
                magazijn_invoer_combobx_geheugenslot.DisplayMember = "standaardnaam";
                magazijn_invoer_combobx_geheugenslot.DataSource = dt;

                conn_memory.Close();

            }
            catch (Exception ex)
            {
                // S.W.R. = Something Went Wrong
                MessageBox.Show("Oops S.W.R. : \n" + ex);
            }
            // Einde geheugen types ophalen.
        }

        private void magazijn_invoer_combobx_categorie_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // ID van geselecteerde waarde weergeven in Label2
            // magazijn_invoer_combobx_categorie.SelectedValue.ToString();
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void magazijn_invoer_btn_toevoegen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(magazijn_invoer_txtbox_merk.Text))
            {
                MessageBox.Show("Merk mag niet leeg zijn!");
            }
            if (string.IsNullOrWhiteSpace(magazijn_invoer_txtbox_type.Text))
            {
                MessageBox.Show("Type mag niet leeg zijn!");
            }
            if (string.IsNullOrWhiteSpace(magazijn_invoer_txtbox_product.Text))
            {
                MessageBox.Show("Product mag niet leeg zijn!");
            }

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
            // Query die uitgevoerd moet worden.
            /*
            ,[categorie]
            ,[subcategorie]
            ,[product]
            ,[merk]
            ,[type]
            ,[geheugen]
            ,[geheugentype]
            ,[cpusocket]
            ,[cpusnelheid]
            ,[architecture]
            ,[cache]
            ,[watts]
            ,[rpm]
            ,[opslagcapaciteit]
            ,[typeaansluiting]
            ,[moboconnector]
            ,[mobosocket]
            ,[mobogeheugenslot]
            ,[mobosataide]
            ,[toegevoegdop]
            ,[vendorlink]
            ,[aantal]
            */
            SqlCommand cmd = new SqlCommand("INSERT INTO magazijn_products" +
                 "(categorie, subcategorie, product, merk, type, geheugen, geheugentype, cpusocket, cpusnelheid, architecture, cache, watts, rpm, opslagcapaciteit, typeaansluiting, moboconnector, mobosocket, mobogeheugenslot, mobosataide, toegevoegdop, vendorlink, aantal)" +
                "VALUES(@categorie, @subcategorie, @product, @merk, @type, @geheugen, @geheugentype, @cpusocket, @cpusnelheid, @architecture, @cache, @watts, @rpm, @opslagcapaciteit, @typeaansluiting, @moboconnector, @mobosocket @mobogeheugenslot, @mobosataide, @toegevoegdop @vendorlink, @aantal)", conn);
            cmd.Parameters.Add("@categorie", SqlDbType.VarChar).Value = magazijn_invoer_combobx_categorie.Text;
            cmd.Parameters.Add("@subcategorie", SqlDbType.VarChar).Value = magazijn_invoer_combobx_subcategorie.Text;
            cmd.Parameters.Add("@merk", SqlDbType.VarChar).Value = magazijn_invoer_txtbox_merk.Text;
            cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = magazijn_invoer_txtbox_type.Text;

            cmd.Parameters.Add("@product", SqlDbType.VarChar).Value = magazijn_invoer_txtbox_product.Text;
            cmd.Parameters.Add("@rpm", SqlDbType.VarChar).Value = magazijn_invoer_txtbox_rpm.Text;
            cmd.Parameters.Add("@geheugen", SqlDbType.VarChar).Value = magazijn_invoer_txtbox_geheugenamount.Text;
            cmd.Parameters.Add("@socket", SqlDbType.VarChar).Value = magazijn_invoer_txtbox_cpusocket.Text;
            cmd.Parameters.Add("@wattage", SqlDbType.VarChar).Value = magazijn_invoer_txtbox_watt.Text;
            cmd.Parameters.Add("@moboconnector", SqlDbType.VarChar).Value = magazijn_invoer_txtbox_moboconnector.Text; ;
            cmd.Parameters.Add("@geheugentype", SqlDbType.VarChar).Value = magazijn_invoer_combobx_geheugentype.Text;
            cmd.Parameters.Add("@opslagcapaciteit", SqlDbType.VarChar).Value = magazijn_invoer_txtbox_opslagcapaciteit.Text;
            cmd.Parameters.Add("@aansluitingstype", SqlDbType.VarChar).Value = "To be coded";
            cmd.Parameters.Add("@bijgewerktop", SqlDbType.DateTime).Value = DateTime.Now;
            cmd.Parameters.Add("@toegevoegdop", SqlDbType.DateTime).Value = "";
            cmd.Parameters.Add("@vendorlink", SqlDbType.VarChar).Value = magazijn_invoer_txtbox_vendorlink.Text;
            // Query uitvoeren
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product is met succes toegevoegd aan de database",
                "Helpdesk Registratie Tool Purmerend",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            magazijn_invoer_txtbox_geheugenamount.Text = magazijn_invoer_memoryslide.Value.ToString();
        }

    }
}

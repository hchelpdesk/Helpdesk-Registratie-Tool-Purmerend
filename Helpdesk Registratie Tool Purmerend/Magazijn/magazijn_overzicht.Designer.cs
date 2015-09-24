namespace Helpdesk_Registratie_Tool_Purmerend.Magazijn
{
    partial class magazijn_overzicht
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(magazijn_overzicht));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.magazijnProductsDataSet = new Helpdesk_Registratie_Tool_Purmerend.MagazijnProductsDataSet();
            this.magazijnproductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazijn_productsTableAdapter = new Helpdesk_Registratie_Tool_Purmerend.MagazijnProductsDataSetTableAdapters.magazijn_productsTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subcategorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.merkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serienummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rpmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geheugenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wattageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moboconnectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geheugentypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opslagcapaciteitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aansluitingstypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bijgewerktopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toegevoegdopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorlinkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazijnProductsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazijnproductsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.categorieDataGridViewTextBoxColumn,
            this.subcategorieDataGridViewTextBoxColumn,
            this.merkDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.serienummerDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.rpmDataGridViewTextBoxColumn,
            this.geheugenDataGridViewTextBoxColumn,
            this.socketDataGridViewTextBoxColumn,
            this.wattageDataGridViewTextBoxColumn,
            this.moboconnectorDataGridViewTextBoxColumn,
            this.geheugentypeDataGridViewTextBoxColumn,
            this.opslagcapaciteitDataGridViewTextBoxColumn,
            this.aansluitingstypeDataGridViewTextBoxColumn,
            this.bijgewerktopDataGridViewTextBoxColumn,
            this.toegevoegdopDataGridViewTextBoxColumn,
            this.vendorlinkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.magazijnproductsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1136, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // magazijnProductsDataSet
            // 
            this.magazijnProductsDataSet.DataSetName = "MagazijnProductsDataSet";
            this.magazijnProductsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // magazijnproductsBindingSource
            // 
            this.magazijnproductsBindingSource.DataMember = "magazijn_products";
            this.magazijnproductsBindingSource.DataSource = this.magazijnProductsDataSet;
            // 
            // magazijn_productsTableAdapter
            // 
            this.magazijn_productsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 43;
            // 
            // categorieDataGridViewTextBoxColumn
            // 
            this.categorieDataGridViewTextBoxColumn.DataPropertyName = "categorie";
            this.categorieDataGridViewTextBoxColumn.HeaderText = "categorie";
            this.categorieDataGridViewTextBoxColumn.Name = "categorieDataGridViewTextBoxColumn";
            this.categorieDataGridViewTextBoxColumn.ReadOnly = true;
            this.categorieDataGridViewTextBoxColumn.Width = 76;
            // 
            // subcategorieDataGridViewTextBoxColumn
            // 
            this.subcategorieDataGridViewTextBoxColumn.DataPropertyName = "subcategorie";
            this.subcategorieDataGridViewTextBoxColumn.HeaderText = "subcategorie";
            this.subcategorieDataGridViewTextBoxColumn.Name = "subcategorieDataGridViewTextBoxColumn";
            this.subcategorieDataGridViewTextBoxColumn.ReadOnly = true;
            this.subcategorieDataGridViewTextBoxColumn.Width = 93;
            // 
            // merkDataGridViewTextBoxColumn
            // 
            this.merkDataGridViewTextBoxColumn.DataPropertyName = "merk";
            this.merkDataGridViewTextBoxColumn.HeaderText = "merk";
            this.merkDataGridViewTextBoxColumn.Name = "merkDataGridViewTextBoxColumn";
            this.merkDataGridViewTextBoxColumn.ReadOnly = true;
            this.merkDataGridViewTextBoxColumn.Width = 55;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 52;
            // 
            // serienummerDataGridViewTextBoxColumn
            // 
            this.serienummerDataGridViewTextBoxColumn.DataPropertyName = "serienummer";
            this.serienummerDataGridViewTextBoxColumn.HeaderText = "serienummer";
            this.serienummerDataGridViewTextBoxColumn.Name = "serienummerDataGridViewTextBoxColumn";
            this.serienummerDataGridViewTextBoxColumn.ReadOnly = true;
            this.serienummerDataGridViewTextBoxColumn.Width = 91;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "product";
            this.productDataGridViewTextBoxColumn.HeaderText = "product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.ReadOnly = true;
            this.productDataGridViewTextBoxColumn.Width = 68;
            // 
            // rpmDataGridViewTextBoxColumn
            // 
            this.rpmDataGridViewTextBoxColumn.DataPropertyName = "rpm";
            this.rpmDataGridViewTextBoxColumn.HeaderText = "rpm";
            this.rpmDataGridViewTextBoxColumn.Name = "rpmDataGridViewTextBoxColumn";
            this.rpmDataGridViewTextBoxColumn.ReadOnly = true;
            this.rpmDataGridViewTextBoxColumn.Width = 49;
            // 
            // geheugenDataGridViewTextBoxColumn
            // 
            this.geheugenDataGridViewTextBoxColumn.DataPropertyName = "geheugen";
            this.geheugenDataGridViewTextBoxColumn.HeaderText = "geheugen";
            this.geheugenDataGridViewTextBoxColumn.Name = "geheugenDataGridViewTextBoxColumn";
            this.geheugenDataGridViewTextBoxColumn.ReadOnly = true;
            this.geheugenDataGridViewTextBoxColumn.Width = 80;
            // 
            // socketDataGridViewTextBoxColumn
            // 
            this.socketDataGridViewTextBoxColumn.DataPropertyName = "socket";
            this.socketDataGridViewTextBoxColumn.HeaderText = "socket";
            this.socketDataGridViewTextBoxColumn.Name = "socketDataGridViewTextBoxColumn";
            this.socketDataGridViewTextBoxColumn.ReadOnly = true;
            this.socketDataGridViewTextBoxColumn.Width = 64;
            // 
            // wattageDataGridViewTextBoxColumn
            // 
            this.wattageDataGridViewTextBoxColumn.DataPropertyName = "wattage";
            this.wattageDataGridViewTextBoxColumn.HeaderText = "wattage";
            this.wattageDataGridViewTextBoxColumn.Name = "wattageDataGridViewTextBoxColumn";
            this.wattageDataGridViewTextBoxColumn.ReadOnly = true;
            this.wattageDataGridViewTextBoxColumn.Width = 70;
            // 
            // moboconnectorDataGridViewTextBoxColumn
            // 
            this.moboconnectorDataGridViewTextBoxColumn.DataPropertyName = "moboconnector";
            this.moboconnectorDataGridViewTextBoxColumn.HeaderText = "moboconnector";
            this.moboconnectorDataGridViewTextBoxColumn.Name = "moboconnectorDataGridViewTextBoxColumn";
            this.moboconnectorDataGridViewTextBoxColumn.ReadOnly = true;
            this.moboconnectorDataGridViewTextBoxColumn.Width = 106;
            // 
            // geheugentypeDataGridViewTextBoxColumn
            // 
            this.geheugentypeDataGridViewTextBoxColumn.DataPropertyName = "geheugentype";
            this.geheugentypeDataGridViewTextBoxColumn.HeaderText = "geheugentype";
            this.geheugentypeDataGridViewTextBoxColumn.Name = "geheugentypeDataGridViewTextBoxColumn";
            this.geheugentypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opslagcapaciteitDataGridViewTextBoxColumn
            // 
            this.opslagcapaciteitDataGridViewTextBoxColumn.DataPropertyName = "opslagcapaciteit";
            this.opslagcapaciteitDataGridViewTextBoxColumn.HeaderText = "opslagcapaciteit";
            this.opslagcapaciteitDataGridViewTextBoxColumn.Name = "opslagcapaciteitDataGridViewTextBoxColumn";
            this.opslagcapaciteitDataGridViewTextBoxColumn.ReadOnly = true;
            this.opslagcapaciteitDataGridViewTextBoxColumn.Width = 109;
            // 
            // aansluitingstypeDataGridViewTextBoxColumn
            // 
            this.aansluitingstypeDataGridViewTextBoxColumn.DataPropertyName = "aansluitingstype";
            this.aansluitingstypeDataGridViewTextBoxColumn.HeaderText = "aansluitingstype";
            this.aansluitingstypeDataGridViewTextBoxColumn.Name = "aansluitingstypeDataGridViewTextBoxColumn";
            this.aansluitingstypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.aansluitingstypeDataGridViewTextBoxColumn.Width = 107;
            // 
            // bijgewerktopDataGridViewTextBoxColumn
            // 
            this.bijgewerktopDataGridViewTextBoxColumn.DataPropertyName = "bijgewerktop";
            this.bijgewerktopDataGridViewTextBoxColumn.HeaderText = "bijgewerktop";
            this.bijgewerktopDataGridViewTextBoxColumn.Name = "bijgewerktopDataGridViewTextBoxColumn";
            this.bijgewerktopDataGridViewTextBoxColumn.ReadOnly = true;
            this.bijgewerktopDataGridViewTextBoxColumn.Width = 92;
            // 
            // toegevoegdopDataGridViewTextBoxColumn
            // 
            this.toegevoegdopDataGridViewTextBoxColumn.DataPropertyName = "toegevoegdop";
            this.toegevoegdopDataGridViewTextBoxColumn.HeaderText = "toegevoegdop";
            this.toegevoegdopDataGridViewTextBoxColumn.Name = "toegevoegdopDataGridViewTextBoxColumn";
            this.toegevoegdopDataGridViewTextBoxColumn.ReadOnly = true;
            this.toegevoegdopDataGridViewTextBoxColumn.Width = 101;
            // 
            // vendorlinkDataGridViewTextBoxColumn
            // 
            this.vendorlinkDataGridViewTextBoxColumn.DataPropertyName = "vendorlink";
            this.vendorlinkDataGridViewTextBoxColumn.HeaderText = "vendorlink";
            this.vendorlinkDataGridViewTextBoxColumn.Name = "vendorlinkDataGridViewTextBoxColumn";
            this.vendorlinkDataGridViewTextBoxColumn.ReadOnly = true;
            this.vendorlinkDataGridViewTextBoxColumn.Width = 81;
            // 
            // magazijn_overzicht
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1136, 450);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "magazijn_overzicht";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magazijn Overzicht";
            this.Load += new System.EventHandler(this.magazijn_overzicht_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazijnProductsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazijnproductsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MagazijnProductsDataSet magazijnProductsDataSet;
        private System.Windows.Forms.BindingSource magazijnproductsBindingSource;
        private MagazijnProductsDataSetTableAdapters.magazijn_productsTableAdapter magazijn_productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcategorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn merkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serienummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rpmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn geheugenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn socketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wattageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moboconnectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn geheugentypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opslagcapaciteitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aansluitingstypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bijgewerktopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toegevoegdopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorlinkDataGridViewTextBoxColumn;
    }
}
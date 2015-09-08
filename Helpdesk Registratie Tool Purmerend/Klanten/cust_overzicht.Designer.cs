namespace Helpdesk_Registratie_Tool_Purmerend.Klanten
{
    partial class cust_overzicht
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cust_overzicht));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.klantenBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.helpdeskDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.klantenBindingSource = new System.Windows.Forms.BindingSource(this.components);
           
            this.aanhefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voornaamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.achternaamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedrijfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afdelingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opmerkingenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klantenBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpdeskDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klantenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aanhefDataGridViewTextBoxColumn,
            this.voornaamDataGridViewTextBoxColumn,
            this.achternaamDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefoonDataGridViewTextBoxColumn,
            this.bedrijfDataGridViewTextBoxColumn,
            this.afdelingDataGridViewTextBoxColumn,
            this.opmerkingenDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.klantenBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(946, 44);
            this.dataGridView1.TabIndex = 0;
          
            // aanhefDataGridViewTextBoxColumn
            // 
            this.aanhefDataGridViewTextBoxColumn.DataPropertyName = "aanhef";
            this.aanhefDataGridViewTextBoxColumn.HeaderText = "Aanhef";
            this.aanhefDataGridViewTextBoxColumn.Name = "aanhefDataGridViewTextBoxColumn";
            this.aanhefDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // voornaamDataGridViewTextBoxColumn
            // 
            this.voornaamDataGridViewTextBoxColumn.DataPropertyName = "voornaam";
            this.voornaamDataGridViewTextBoxColumn.HeaderText = "Voornaam";
            this.voornaamDataGridViewTextBoxColumn.Name = "voornaamDataGridViewTextBoxColumn";
            this.voornaamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // achternaamDataGridViewTextBoxColumn
            // 
            this.achternaamDataGridViewTextBoxColumn.DataPropertyName = "achternaam";
            this.achternaamDataGridViewTextBoxColumn.HeaderText = "Achternaam";
            this.achternaamDataGridViewTextBoxColumn.Name = "achternaamDataGridViewTextBoxColumn";
            this.achternaamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoonDataGridViewTextBoxColumn
            // 
            this.telefoonDataGridViewTextBoxColumn.DataPropertyName = "telefoon";
            this.telefoonDataGridViewTextBoxColumn.HeaderText = "Telefoon";
            this.telefoonDataGridViewTextBoxColumn.Name = "telefoonDataGridViewTextBoxColumn";
            this.telefoonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bedrijfDataGridViewTextBoxColumn
            // 
            this.bedrijfDataGridViewTextBoxColumn.DataPropertyName = "bedrijf";
            this.bedrijfDataGridViewTextBoxColumn.HeaderText = "Bedrijf";
            this.bedrijfDataGridViewTextBoxColumn.Name = "bedrijfDataGridViewTextBoxColumn";
            this.bedrijfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // afdelingDataGridViewTextBoxColumn
            // 
            this.afdelingDataGridViewTextBoxColumn.DataPropertyName = "afdeling";
            this.afdelingDataGridViewTextBoxColumn.HeaderText = "Afdeling";
            this.afdelingDataGridViewTextBoxColumn.Name = "afdelingDataGridViewTextBoxColumn";
            this.afdelingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opmerkingenDataGridViewTextBoxColumn
            // 
            this.opmerkingenDataGridViewTextBoxColumn.DataPropertyName = "opmerkingen";
            this.opmerkingenDataGridViewTextBoxColumn.HeaderText = "Opmerkingen";
            this.opmerkingenDataGridViewTextBoxColumn.Name = "opmerkingenDataGridViewTextBoxColumn";
            this.opmerkingenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cust_overzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 453);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cust_overzicht";
            this.Text = "Klanten Overzicht";
            this.Load += new System.EventHandler(this.cust_overzicht_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klantenBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpdeskDataSetBindingSource)).EndInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.klantenBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        
        private System.Windows.Forms.BindingSource klantenBindingSource;
      
        private System.Windows.Forms.BindingSource klantenBindingSource1;
        private System.Windows.Forms.BindingSource helpdeskDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn aanhefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voornaamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn achternaamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedrijfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn afdelingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opmerkingenDataGridViewTextBoxColumn;
    }
}
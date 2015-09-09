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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cust_overzicht));
            this.cust_overzicht_dgv1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cust_overzicht_dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // cust_overzicht_dgv1
            // 
            this.cust_overzicht_dgv1.AllowUserToDeleteRows = false;
            this.cust_overzicht_dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cust_overzicht_dgv1.Location = new System.Drawing.Point(13, 13);
            this.cust_overzicht_dgv1.Name = "cust_overzicht_dgv1";
            this.cust_overzicht_dgv1.ReadOnly = true;
            this.cust_overzicht_dgv1.Size = new System.Drawing.Size(946, 196);
            this.cust_overzicht_dgv1.TabIndex = 0;
            // 
            // cust_overzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 453);
            this.Controls.Add(this.cust_overzicht_dgv1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cust_overzicht";
            this.Text = "Klanten Overzicht";
            this.Load += new System.EventHandler(this.cust_overzicht_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cust_overzicht_dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView cust_overzicht_dgv1;
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
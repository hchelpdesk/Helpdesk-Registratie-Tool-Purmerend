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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cust_overzicht_dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // cust_overzicht_dgv1
            // 
            this.cust_overzicht_dgv1.AllowUserToAddRows = false;
            this.cust_overzicht_dgv1.AllowUserToDeleteRows = false;
            this.cust_overzicht_dgv1.AllowUserToResizeColumns = false;
            this.cust_overzicht_dgv1.AllowUserToResizeRows = false;
            this.cust_overzicht_dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.cust_overzicht_dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.cust_overzicht_dgv1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cust_overzicht_dgv1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.cust_overzicht_dgv1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.cust_overzicht_dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cust_overzicht_dgv1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.cust_overzicht_dgv1.Location = new System.Drawing.Point(12, 67);
            this.cust_overzicht_dgv1.Name = "cust_overzicht_dgv1";
            this.cust_overzicht_dgv1.ReadOnly = true;
            this.cust_overzicht_dgv1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.cust_overzicht_dgv1.RowHeadersVisible = false;
            this.cust_overzicht_dgv1.ShowEditingIcon = false;
            this.cust_overzicht_dgv1.Size = new System.Drawing.Size(1235, 188);
            this.cust_overzicht_dgv1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zoeken";
            // 
            // cust_overzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 267);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cust_overzicht_dgv1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "cust_overzicht";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Klanten Overzicht";
            this.Load += new System.EventHandler(this.cust_overzicht_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cust_overzicht_dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView cust_overzicht_dgv1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}
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
            this.cust_overzicht_dgv1.AllowUserToAddRows = false;
            this.cust_overzicht_dgv1.AllowUserToDeleteRows = false;
            this.cust_overzicht_dgv1.AllowUserToResizeColumns = false;
            this.cust_overzicht_dgv1.AllowUserToResizeRows = false;
            this.cust_overzicht_dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.cust_overzicht_dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.cust_overzicht_dgv1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.cust_overzicht_dgv1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.cust_overzicht_dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cust_overzicht_dgv1.Dock = System.Windows.Forms.DockStyle.Left;
            this.cust_overzicht_dgv1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.cust_overzicht_dgv1.Location = new System.Drawing.Point(0, 0);
            this.cust_overzicht_dgv1.Name = "cust_overzicht_dgv1";
            this.cust_overzicht_dgv1.ReadOnly = true;
            this.cust_overzicht_dgv1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.cust_overzicht_dgv1.RowHeadersVisible = false;
            this.cust_overzicht_dgv1.Size = new System.Drawing.Size(1152, 237);
            this.cust_overzicht_dgv1.TabIndex = 0;
            // 
            // cust_overzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 237);
            this.Controls.Add(this.cust_overzicht_dgv1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "cust_overzicht";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Klanten Overzicht";
            this.Load += new System.EventHandler(this.cust_overzicht_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cust_overzicht_dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView cust_overzicht_dgv1;
        
        
    }
}
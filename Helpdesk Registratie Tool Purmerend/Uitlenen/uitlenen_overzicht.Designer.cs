namespace Helpdesk_Registratie_Tool_Purmerend.Uitlenen
{
    partial class uitlenen_overzicht
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uitlenen_overzicht));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uitlenen_btn_addnew = new System.Windows.Forms.Button();
            this.uitlenen_btn_returned = new System.Windows.Forms.Button();
            this.uitlenenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uitlenenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(777, 362);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // uitlenen_btn_addnew
            // 
            this.uitlenen_btn_addnew.Location = new System.Drawing.Point(4, 1);
            this.uitlenen_btn_addnew.Name = "uitlenen_btn_addnew";
            this.uitlenen_btn_addnew.Size = new System.Drawing.Size(75, 23);
            this.uitlenen_btn_addnew.TabIndex = 1;
            this.uitlenen_btn_addnew.Text = "Toevoegen";
            this.uitlenen_btn_addnew.UseVisualStyleBackColor = true;
            this.uitlenen_btn_addnew.Click += new System.EventHandler(this.uitlenen_btn_addnew_Click);
            // 
            // uitlenen_btn_returned
            // 
            this.uitlenen_btn_returned.Location = new System.Drawing.Point(84, 0);
            this.uitlenen_btn_returned.Name = "uitlenen_btn_returned";
            this.uitlenen_btn_returned.Size = new System.Drawing.Size(89, 23);
            this.uitlenen_btn_returned.TabIndex = 2;
            this.uitlenen_btn_returned.Text = "Teruggebracht";
            this.uitlenen_btn_returned.UseVisualStyleBackColor = true;
            this.uitlenen_btn_returned.Click += new System.EventHandler(this.uitlenen_btn_returned_Click);
            // 
            // uitlenenBindingSource
            // 
            this.uitlenenBindingSource.DataMember = "uitlenen";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(2, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.uitlenen_btn_addnew);
            this.splitContainer1.Panel1.Controls.Add(this.uitlenen_btn_returned);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(777, 391);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 4;
            // 
            // uitlenen_overzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 396);
            this.Controls.Add(this.splitContainer1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "uitlenen_overzicht";
            this.Text = "Uitlenen Overzicht";
            this.Load += new System.EventHandler(this.uitlenen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uitlenenBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource uitlenenBindingSource;
        private System.Windows.Forms.Button uitlenen_btn_addnew;
        private System.Windows.Forms.Button uitlenen_btn_returned;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
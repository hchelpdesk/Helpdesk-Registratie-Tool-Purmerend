namespace Helpdesk_Registratie_Tool_Purmerend.Klanten
{
    partial class cust_import
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cust_import));
            this.cust_import_lbl_pickfile = new System.Windows.Forms.Label();
            this.cust_import_txtbox_csv = new System.Windows.Forms.TextBox();
            this.cust_import_btn_csv_browse = new System.Windows.Forms.Button();
            this.cust_import_filedialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cust_import_csv_path = new System.Windows.Forms.Label();
            this.cust_import_csv_btn_import = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // cust_import_lbl_pickfile
            // 
            this.cust_import_lbl_pickfile.AutoSize = true;
            this.cust_import_lbl_pickfile.Location = new System.Drawing.Point(13, 13);
            this.cust_import_lbl_pickfile.Name = "cust_import_lbl_pickfile";
            this.cust_import_lbl_pickfile.Size = new System.Drawing.Size(104, 13);
            this.cust_import_lbl_pickfile.TabIndex = 0;
            this.cust_import_lbl_pickfile.Text = "CSV Bestand kiezen";
            // 
            // cust_import_txtbox_csv
            // 
            this.cust_import_txtbox_csv.Location = new System.Drawing.Point(16, 30);
            this.cust_import_txtbox_csv.Name = "cust_import_txtbox_csv";
            this.cust_import_txtbox_csv.Size = new System.Drawing.Size(230, 20);
            this.cust_import_txtbox_csv.TabIndex = 1;
            // 
            // cust_import_btn_csv_browse
            // 
            this.cust_import_btn_csv_browse.Location = new System.Drawing.Point(252, 29);
            this.cust_import_btn_csv_browse.Name = "cust_import_btn_csv_browse";
            this.cust_import_btn_csv_browse.Size = new System.Drawing.Size(75, 23);
            this.cust_import_btn_csv_browse.TabIndex = 2;
            this.cust_import_btn_csv_browse.Text = "Browse...";
            this.cust_import_btn_csv_browse.UseVisualStyleBackColor = true;
            this.cust_import_btn_csv_browse.Click += new System.EventHandler(this.cust_import_btn_csv_browse_Click);
            // 
            // cust_import_filedialog1
            // 
            this.cust_import_filedialog1.FileName = "openFileDialog1";
            // 
            // cust_import_csv_path
            // 
            this.cust_import_csv_path.AutoSize = true;
            this.cust_import_csv_path.Location = new System.Drawing.Point(16, 57);
            this.cust_import_csv_path.Name = "cust_import_csv_path";
            this.cust_import_csv_path.Size = new System.Drawing.Size(127, 13);
            this.cust_import_csv_path.TabIndex = 3;
            this.cust_import_csv_path.Text = "Geen bestand gekozen...";
            // 
            // cust_import_csv_btn_import
            // 
            this.cust_import_csv_btn_import.Location = new System.Drawing.Point(252, 57);
            this.cust_import_csv_btn_import.Name = "cust_import_csv_btn_import";
            this.cust_import_csv_btn_import.Size = new System.Drawing.Size(75, 23);
            this.cust_import_csv_btn_import.TabIndex = 4;
            this.cust_import_csv_btn_import.Text = "Import File";
            this.cust_import_csv_btn_import.UseVisualStyleBackColor = true;
            this.cust_import_csv_btn_import.Click += new System.EventHandler(this.cust_import_csv_btn_import_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(13, 102);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(101, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "View CSV Template";
            // 
            // cust_import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 127);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cust_import_csv_btn_import);
            this.Controls.Add(this.cust_import_csv_path);
            this.Controls.Add(this.cust_import_btn_csv_browse);
            this.Controls.Add(this.cust_import_txtbox_csv);
            this.Controls.Add(this.cust_import_lbl_pickfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "cust_import";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Klanten Importeren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox cust_import_txtbox_csv;
        private System.Windows.Forms.Button cust_import_btn_csv_browse;
        public System.Windows.Forms.Label cust_import_lbl_pickfile;
        private System.Windows.Forms.OpenFileDialog cust_import_filedialog1;
        private System.Windows.Forms.Label cust_import_csv_path;
        private System.Windows.Forms.Button cust_import_csv_btn_import;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
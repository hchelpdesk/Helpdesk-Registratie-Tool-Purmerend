namespace Helpdesk_Registratie_Tool_Purmerend.Uitlenen
{
    partial class uitlenen_import
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
            this.uitlenen_import_csv = new System.Windows.Forms.OpenFileDialog();
            this.uitlenen_import_btn_browse = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uitlenen_import_csv
            // 
            this.uitlenen_import_csv.FileName = "openFileDialog1";
            // 
            // uitlenen_import_btn_browse
            // 
            this.uitlenen_import_btn_browse.Location = new System.Drawing.Point(305, 43);
            this.uitlenen_import_btn_browse.Name = "uitlenen_import_btn_browse";
            this.uitlenen_import_btn_browse.Size = new System.Drawing.Size(75, 23);
            this.uitlenen_import_btn_browse.TabIndex = 0;
            this.uitlenen_import_btn_browse.Text = "Browse...";
            this.uitlenen_import_btn_browse.UseVisualStyleBackColor = true;
            this.uitlenen_import_btn_browse.Click += new System.EventHandler(this.uitlenen_import_btn_browse_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 20);
            this.textBox1.TabIndex = 1;
            // 
            // uitlenen_import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 373);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.uitlenen_import_btn_browse);
            this.Name = "uitlenen_import";
            this.Text = "Uitlenen Importeren CSV";
            this.Load += new System.EventHandler(this.uitlenen_import_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog uitlenen_import_csv;
        private System.Windows.Forms.Button uitlenen_import_btn_browse;
        private System.Windows.Forms.TextBox textBox1;
    }
}
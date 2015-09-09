namespace Helpdesk_Registratie_Tool_Purmerend.Incidenten
{
    partial class call_overzicht
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(call_overzicht));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.call_meldingen_btn_toevoegen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 175);
            this.dataGridView1.TabIndex = 0;
            // 
            // call_meldingen_btn_toevoegen
            // 
            this.call_meldingen_btn_toevoegen.Location = new System.Drawing.Point(12, 12);
            this.call_meldingen_btn_toevoegen.Name = "call_meldingen_btn_toevoegen";
            this.call_meldingen_btn_toevoegen.Size = new System.Drawing.Size(93, 23);
            this.call_meldingen_btn_toevoegen.TabIndex = 1;
            this.call_meldingen_btn_toevoegen.Text = "Call Toevoegen";
            this.call_meldingen_btn_toevoegen.UseVisualStyleBackColor = true;
            // 
            // call_overzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 503);
            this.Controls.Add(this.call_meldingen_btn_toevoegen);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "call_overzicht";
            this.Text = "Call Meldingen - Overzicht";
            this.Load += new System.EventHandler(this.call_overzicht_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button call_meldingen_btn_toevoegen;
    }
}
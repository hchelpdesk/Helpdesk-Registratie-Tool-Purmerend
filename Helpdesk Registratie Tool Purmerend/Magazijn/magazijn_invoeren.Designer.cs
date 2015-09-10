namespace Helpdesk_Registratie_Tool_Purmerend.Magazijn
{
    partial class magazijn_invoeren
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(magazijn_invoeren));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.magazijn_invoer_combobx_categorie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.magazijn_invoer_combobx_subcat = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.magazijn_invoer_combobx_subcat);
            this.groupBox1.Controls.Add(this.magazijn_invoer_combobx_categorie);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 374);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Invoeren";
            // 
            // magazijn_invoer_combobx_categorie
            // 
            this.magazijn_invoer_combobx_categorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.magazijn_invoer_combobx_categorie.DropDownWidth = 140;
            this.magazijn_invoer_combobx_categorie.FormattingEnabled = true;
            this.magazijn_invoer_combobx_categorie.Location = new System.Drawing.Point(10, 36);
            this.magazijn_invoer_combobx_categorie.Name = "magazijn_invoer_combobx_categorie";
            this.magazijn_invoer_combobx_categorie.Size = new System.Drawing.Size(139, 21);
            this.magazijn_invoer_combobx_categorie.TabIndex = 1;
            this.magazijn_invoer_combobx_categorie.ValueMember = "ID";
            this.magazijn_invoer_combobx_categorie.SelectedIndexChanged += new System.EventHandler(this.magazijn_invoer_combobx_categorie_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categorie";
            // 
            // magazijn_invoer_combobx_subcat
            // 
            this.magazijn_invoer_combobx_subcat.FormattingEnabled = true;
            this.magazijn_invoer_combobx_subcat.Location = new System.Drawing.Point(155, 36);
            this.magazijn_invoer_combobx_subcat.Name = "magazijn_invoer_combobx_subcat";
            this.magazijn_invoer_combobx_subcat.Size = new System.Drawing.Size(140, 21);
            this.magazijn_invoer_combobx_subcat.TabIndex = 2;
            this.magazijn_invoer_combobx_subcat.Visible = false;
            this.magazijn_invoer_combobx_subcat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // magazijn_invoeren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 481);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "magazijn_invoeren";
            this.Text = "Magazijn Invoer";
            this.Load += new System.EventHandler(this.magazijn_invoeren_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox magazijn_invoer_combobx_categorie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox magazijn_invoer_combobx_subcat;
    }
}
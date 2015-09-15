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
            this.magazijn_invoer_grpbox_productinvoer = new System.Windows.Forms.GroupBox();
            this.magazijn_invoer_lbl_fabrikant = new System.Windows.Forms.Label();
            this.magazijn_invoer_lbl_product = new System.Windows.Forms.Label();
            this.magazijn_invoer_combobx_subcategorie = new System.Windows.Forms.ComboBox();
            this.magazijn_invoer_combobx_categorie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.magazijn_invoer_txtbox_product = new System.Windows.Forms.TextBox();
            this.magazijn_invoer_txtbox_fabrikant = new System.Windows.Forms.TextBox();
            this.magazijn_invoer_lbl_ = new System.Windows.Forms.Label();
            this.magazijn_invoer_grpbox_productinvoer.SuspendLayout();
            this.SuspendLayout();
            // 
            // magazijn_invoer_grpbox_productinvoer
            // 
            this.magazijn_invoer_grpbox_productinvoer.Controls.Add(this.magazijn_invoer_lbl_);
            this.magazijn_invoer_grpbox_productinvoer.Controls.Add(this.magazijn_invoer_txtbox_fabrikant);
            this.magazijn_invoer_grpbox_productinvoer.Controls.Add(this.magazijn_invoer_txtbox_product);
            this.magazijn_invoer_grpbox_productinvoer.Controls.Add(this.magazijn_invoer_lbl_fabrikant);
            this.magazijn_invoer_grpbox_productinvoer.Controls.Add(this.magazijn_invoer_lbl_product);
            this.magazijn_invoer_grpbox_productinvoer.Controls.Add(this.magazijn_invoer_combobx_subcategorie);
            this.magazijn_invoer_grpbox_productinvoer.Controls.Add(this.magazijn_invoer_combobx_categorie);
            this.magazijn_invoer_grpbox_productinvoer.Controls.Add(this.label1);
            this.magazijn_invoer_grpbox_productinvoer.Location = new System.Drawing.Point(13, 13);
            this.magazijn_invoer_grpbox_productinvoer.Name = "magazijn_invoer_grpbox_productinvoer";
            this.magazijn_invoer_grpbox_productinvoer.Size = new System.Drawing.Size(612, 374);
            this.magazijn_invoer_grpbox_productinvoer.TabIndex = 0;
            this.magazijn_invoer_grpbox_productinvoer.TabStop = false;
            this.magazijn_invoer_grpbox_productinvoer.Text = "Product Invoeren";
            // 
            // magazijn_invoer_lbl_fabrikant
            // 
            this.magazijn_invoer_lbl_fabrikant.AutoSize = true;
            this.magazijn_invoer_lbl_fabrikant.Location = new System.Drawing.Point(150, 81);
            this.magazijn_invoer_lbl_fabrikant.Name = "magazijn_invoer_lbl_fabrikant";
            this.magazijn_invoer_lbl_fabrikant.Size = new System.Drawing.Size(51, 13);
            this.magazijn_invoer_lbl_fabrikant.TabIndex = 5;
            this.magazijn_invoer_lbl_fabrikant.Text = "Fabrikant";
            // 
            // magazijn_invoer_lbl_product
            // 
            this.magazijn_invoer_lbl_product.AutoSize = true;
            this.magazijn_invoer_lbl_product.Location = new System.Drawing.Point(4, 81);
            this.magazijn_invoer_lbl_product.Name = "magazijn_invoer_lbl_product";
            this.magazijn_invoer_lbl_product.Size = new System.Drawing.Size(44, 13);
            this.magazijn_invoer_lbl_product.TabIndex = 3;
            this.magazijn_invoer_lbl_product.Text = "Product";
            // 
            // magazijn_invoer_combobx_subcategorie
            // 
            this.magazijn_invoer_combobx_subcategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.magazijn_invoer_combobx_subcategorie.FormattingEnabled = true;
            this.magazijn_invoer_combobx_subcategorie.Location = new System.Drawing.Point(155, 36);
            this.magazijn_invoer_combobx_subcategorie.Name = "magazijn_invoer_combobx_subcategorie";
            this.magazijn_invoer_combobx_subcategorie.Size = new System.Drawing.Size(140, 21);
            this.magazijn_invoer_combobx_subcategorie.TabIndex = 2;
            this.magazijn_invoer_combobx_subcategorie.Visible = false;
            // 
            // magazijn_invoer_combobx_categorie
            // 
            this.magazijn_invoer_combobx_categorie.DisplayMember = "ID";
            this.magazijn_invoer_combobx_categorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.magazijn_invoer_combobx_categorie.DropDownWidth = 140;
            this.magazijn_invoer_combobx_categorie.FormattingEnabled = true;
            this.magazijn_invoer_combobx_categorie.Location = new System.Drawing.Point(6, 36);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(631, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // magazijn_invoer_txtbox_product
            // 
            this.magazijn_invoer_txtbox_product.Location = new System.Drawing.Point(7, 98);
            this.magazijn_invoer_txtbox_product.Name = "magazijn_invoer_txtbox_product";
            this.magazijn_invoer_txtbox_product.Size = new System.Drawing.Size(138, 20);
            this.magazijn_invoer_txtbox_product.TabIndex = 6;
            // 
            // magazijn_invoer_txtbox_fabrikant
            // 
            this.magazijn_invoer_txtbox_fabrikant.Location = new System.Drawing.Point(152, 97);
            this.magazijn_invoer_txtbox_fabrikant.Name = "magazijn_invoer_txtbox_fabrikant";
            this.magazijn_invoer_txtbox_fabrikant.Size = new System.Drawing.Size(143, 20);
            this.magazijn_invoer_txtbox_fabrikant.TabIndex = 7;
            // 
            // magazijn_invoer_lbl_
            // 
            this.magazijn_invoer_lbl_.AutoSize = true;
            this.magazijn_invoer_lbl_.Location = new System.Drawing.Point(6, 125);
            this.magazijn_invoer_lbl_.Name = "magazijn_invoer_lbl_";
            this.magazijn_invoer_lbl_.Size = new System.Drawing.Size(35, 13);
            this.magazijn_invoer_lbl_.TabIndex = 8;
            this.magazijn_invoer_lbl_.Text = "label3";
            // 
            // magazijn_invoeren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 481);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.magazijn_invoer_grpbox_productinvoer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "magazijn_invoeren";
            this.Text = "Magazijn Invoer";
            this.Load += new System.EventHandler(this.magazijn_invoeren_Load);
            this.magazijn_invoer_grpbox_productinvoer.ResumeLayout(false);
            this.magazijn_invoer_grpbox_productinvoer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox magazijn_invoer_grpbox_productinvoer;
        private System.Windows.Forms.ComboBox magazijn_invoer_combobx_categorie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox magazijn_invoer_combobx_subcategorie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label magazijn_invoer_lbl_fabrikant;
        private System.Windows.Forms.Label magazijn_invoer_lbl_product;
        private System.Windows.Forms.Label magazijn_invoer_lbl_;
        private System.Windows.Forms.TextBox magazijn_invoer_txtbox_fabrikant;
        private System.Windows.Forms.TextBox magazijn_invoer_txtbox_product;
    }
}
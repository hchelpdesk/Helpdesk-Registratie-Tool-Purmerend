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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.magazijn_invoer_combobx_subcategorie = new System.Windows.Forms.ComboBox();
            this.magazijn_invoer_combobx_categorie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.magazijn_invoer_combobx_subcategorie);
            this.groupBox1.Controls.Add(this.magazijn_invoer_combobx_categorie);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 374);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Invoeren";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(152, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fabrikant";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Tag = "Hardeschijf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sub categorie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "label6";
            // 
            // magazijn_invoeren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 481);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "magazijn_invoeren";
            this.Text = "Magazijn Invoer";
            this.Load += new System.EventHandler(this.magazijn_invoeren_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox magazijn_invoer_combobx_categorie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox magazijn_invoer_combobx_subcategorie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
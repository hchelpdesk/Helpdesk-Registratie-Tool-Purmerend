namespace Helpdesk_Registratie_Tool_Purmerend.Uitlenen
{
    partial class uitlenen_toevoegen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uitlenen_toevoegen));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uitlenen_toevoegen_fullname = new System.Windows.Forms.ComboBox();
            this.klas_lbl = new System.Windows.Forms.Label();
            this.uitlenen_toevoegen_btn_add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.uitlenen_toevoegen_ingeleverd = new System.Windows.Forms.TextBox();
            this.uitlenen_toevoegen_product = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Klas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product";
            // 
            // uitlenen_toevoegen_fullname
            // 
            this.uitlenen_toevoegen_fullname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.uitlenen_toevoegen_fullname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uitlenen_toevoegen_fullname.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uitlenen_toevoegen_fullname.FormattingEnabled = true;
            this.uitlenen_toevoegen_fullname.Items.AddRange(new object[] {
            "Selecteer de naam"});
            this.uitlenen_toevoegen_fullname.Location = new System.Drawing.Point(80, 36);
            this.uitlenen_toevoegen_fullname.MaxDropDownItems = 10;
            this.uitlenen_toevoegen_fullname.Name = "uitlenen_toevoegen_fullname";
            this.uitlenen_toevoegen_fullname.Size = new System.Drawing.Size(169, 21);
            this.uitlenen_toevoegen_fullname.TabIndex = 3;
            this.uitlenen_toevoegen_fullname.SelectedIndexChanged += new System.EventHandler(this.uitlenen_toevoegen_fullname_SelectedIndexChanged);
            // 
            // klas_lbl
            // 
            this.klas_lbl.AutoSize = true;
            this.klas_lbl.Location = new System.Drawing.Point(82, 67);
            this.klas_lbl.Name = "klas_lbl";
            this.klas_lbl.Size = new System.Drawing.Size(10, 13);
            this.klas_lbl.TabIndex = 6;
            this.klas_lbl.Text = " ";
            // 
            // uitlenen_toevoegen_btn_add
            // 
            this.uitlenen_toevoegen_btn_add.Location = new System.Drawing.Point(182, 154);
            this.uitlenen_toevoegen_btn_add.Name = "uitlenen_toevoegen_btn_add";
            this.uitlenen_toevoegen_btn_add.Size = new System.Drawing.Size(75, 23);
            this.uitlenen_toevoegen_btn_add.TabIndex = 8;
            this.uitlenen_toevoegen_btn_add.Text = "Toevoegen";
            this.uitlenen_toevoegen_btn_add.UseVisualStyleBackColor = true;
            this.uitlenen_toevoegen_btn_add.Click += new System.EventHandler(this.uitlenen_toevoegen_btn_add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(13, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ingeleverd:";
            // 
            // uitlenen_toevoegen_ingeleverd
            // 
            this.uitlenen_toevoegen_ingeleverd.Location = new System.Drawing.Point(80, 121);
            this.uitlenen_toevoegen_ingeleverd.Name = "uitlenen_toevoegen_ingeleverd";
            this.uitlenen_toevoegen_ingeleverd.Size = new System.Drawing.Size(169, 20);
            this.uitlenen_toevoegen_ingeleverd.TabIndex = 10;
            // 
            // uitlenen_toevoegen_product
            // 
            this.uitlenen_toevoegen_product.Location = new System.Drawing.Point(80, 93);
            this.uitlenen_toevoegen_product.Name = "uitlenen_toevoegen_product";
            this.uitlenen_toevoegen_product.Size = new System.Drawing.Size(169, 20);
            this.uitlenen_toevoegen_product.TabIndex = 11;
            // 
            // uitlenen_toevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 189);
            this.Controls.Add(this.uitlenen_toevoegen_product);
            this.Controls.Add(this.uitlenen_toevoegen_ingeleverd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uitlenen_toevoegen_btn_add);
            this.Controls.Add(this.klas_lbl);
            this.Controls.Add(this.uitlenen_toevoegen_fullname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "uitlenen_toevoegen";
            this.Text = "Uitlenen Toevoegen";
            this.Load += new System.EventHandler(this.uitlenen_toevoegen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox uitlenen_toevoegen_fullname;
        private System.Windows.Forms.Label klas_lbl;
        private System.Windows.Forms.Button uitlenen_toevoegen_btn_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uitlenen_toevoegen_ingeleverd;
        private System.Windows.Forms.TextBox uitlenen_toevoegen_product;
    }
}
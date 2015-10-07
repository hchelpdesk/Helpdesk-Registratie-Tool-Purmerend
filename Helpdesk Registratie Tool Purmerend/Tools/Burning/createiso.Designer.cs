namespace Helpdesk_Registratie_Tool_Purmerend.Tools.Burning
{
    partial class createiso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createiso));
            this.createiso_combobx_sourcedrive = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Progression_lbl = new System.Windows.Forms.Label();
            this.createiso_status_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createiso_combobx_sourcedrive
            // 
            this.createiso_combobx_sourcedrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.createiso_combobx_sourcedrive.FormattingEnabled = true;
            this.createiso_combobx_sourcedrive.Location = new System.Drawing.Point(12, 41);
            this.createiso_combobx_sourcedrive.Name = "createiso_combobx_sourcedrive";
            this.createiso_combobx_sourcedrive.Size = new System.Drawing.Size(117, 21);
            this.createiso_combobx_sourcedrive.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select CD/DVD Writer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Place to Save the ISO";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(345, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(345, 97);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Progression_lbl
            // 
            this.Progression_lbl.AutoSize = true;
            this.Progression_lbl.Location = new System.Drawing.Point(12, 106);
            this.Progression_lbl.Name = "Progression_lbl";
            this.Progression_lbl.Size = new System.Drawing.Size(62, 13);
            this.Progression_lbl.TabIndex = 7;
            this.Progression_lbl.Text = "Progression";
            // 
            // createiso_status_lbl
            // 
            this.createiso_status_lbl.AutoSize = true;
            this.createiso_status_lbl.Location = new System.Drawing.Point(15, 136);
            this.createiso_status_lbl.Name = "createiso_status_lbl";
            this.createiso_status_lbl.Size = new System.Drawing.Size(37, 13);
            this.createiso_status_lbl.TabIndex = 8;
            this.createiso_status_lbl.Text = "Status";
            // 
            // createiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 168);
            this.Controls.Add(this.createiso_status_lbl);
            this.Controls.Add(this.Progression_lbl);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.createiso_combobx_sourcedrive);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "createiso";
            this.Text = "Maak een ISO van CD/DVD";
            this.Load += new System.EventHandler(this.createiso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox createiso_combobx_sourcedrive;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Progression_lbl;
        private System.Windows.Forms.Label createiso_status_lbl;
    }
}
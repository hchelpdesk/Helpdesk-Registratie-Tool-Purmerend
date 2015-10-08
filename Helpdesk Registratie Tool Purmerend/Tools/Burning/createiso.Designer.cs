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
            this.createiso_selectwriter = new System.Windows.Forms.Label();
            this.createiso_lbl_savepath = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.createiso_rogression_lbl = new System.Windows.Forms.Label();
            this.createiso_status_lbl = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // createiso_combobx_sourcedrive
            // 
            this.createiso_combobx_sourcedrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.createiso_combobx_sourcedrive.FormattingEnabled = true;
            this.createiso_combobx_sourcedrive.Location = new System.Drawing.Point(12, 41);
            this.createiso_combobx_sourcedrive.Name = "createiso_combobx_sourcedrive";
            this.createiso_combobx_sourcedrive.Size = new System.Drawing.Size(178, 21);
            this.createiso_combobx_sourcedrive.TabIndex = 0;
            this.createiso_combobx_sourcedrive.SelectedIndexChanged += new System.EventHandler(this.createiso_combobx_sourcedrive_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(213, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(395, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // createiso_selectwriter
            // 
            this.createiso_selectwriter.AutoSize = true;
            this.createiso_selectwriter.Location = new System.Drawing.Point(12, 22);
            this.createiso_selectwriter.Name = "createiso_selectwriter";
            this.createiso_selectwriter.Size = new System.Drawing.Size(114, 13);
            this.createiso_selectwriter.TabIndex = 3;
            this.createiso_selectwriter.Text = "Select CD/DVD Writer";
            // 
            // createiso_lbl_savepath
            // 
            this.createiso_lbl_savepath.AutoSize = true;
            this.createiso_lbl_savepath.Location = new System.Drawing.Point(213, 22);
            this.createiso_lbl_savepath.Name = "createiso_lbl_savepath";
            this.createiso_lbl_savepath.Size = new System.Drawing.Size(146, 13);
            this.createiso_lbl_savepath.TabIndex = 4;
            this.createiso_lbl_savepath.Text = "Select Place to Save the ISO";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(395, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(314, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // createiso_rogression_lbl
            // 
            this.createiso_rogression_lbl.AutoSize = true;
            this.createiso_rogression_lbl.Location = new System.Drawing.Point(9, 106);
            this.createiso_rogression_lbl.Name = "createiso_rogression_lbl";
            this.createiso_rogression_lbl.Size = new System.Drawing.Size(62, 13);
            this.createiso_rogression_lbl.TabIndex = 7;
            this.createiso_rogression_lbl.Text = "Progression";
            // 
            // createiso_status_lbl
            // 
            this.createiso_status_lbl.AutoSize = true;
            this.createiso_status_lbl.Location = new System.Drawing.Point(9, 159);
            this.createiso_status_lbl.Name = "createiso_status_lbl";
            this.createiso_status_lbl.Size = new System.Drawing.Size(37, 13);
            this.createiso_status_lbl.TabIndex = 8;
            this.createiso_status_lbl.Text = "Status";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 123);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(377, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 9;
            // 
            // createiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 199);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.createiso_status_lbl);
            this.Controls.Add(this.createiso_rogression_lbl);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.createiso_lbl_savepath);
            this.Controls.Add(this.createiso_selectwriter);
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
        private System.Windows.Forms.Label createiso_selectwriter;
        private System.Windows.Forms.Label createiso_lbl_savepath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label createiso_rogression_lbl;
        private System.Windows.Forms.Label createiso_status_lbl;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
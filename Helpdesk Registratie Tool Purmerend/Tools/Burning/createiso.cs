using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Iso9660;


namespace Helpdesk_Registratie_Tool_Purmerend.Tools.Burning
{
    public partial class createiso : Form
    {
        Iso9660.Iso9660 cISO;

        public createiso()
        {
            InitializeComponent();
        }
        public void iso_maker(string file, string source)
        {
            int ret = cISO.MakeIsoFromCD(source, file);

            switch (ret)
            {
                case -1:
                    createiso_lbl_savepath.Text = @"Status: " + @"Error! Selected an invalid station ";
                    break;
                case -2:
                    createiso_lbl_savepath.Text = @"Status: " + @"ERROR! Source is not an CD / DVD.";
                    break;
                case -3:
                    createiso_lbl_savepath.Text = @"Status: " + @"ERROR! Not enough space to create the iso file.";
                    break;
                case -4:
                    createiso_lbl_savepath.Text = @"Status: " + @"ERROR! a FAT32 file system cannot store a file > then 4096 MB";
                    break;
                case 1:
                    createiso_status_lbl.Text = @"Status: " + @"Creating the iso File";
                    break;
            }
        }
        private void createiso_Load(object sender, EventArgs e)
        {
            //Nouvelle instance
            cISO = new Iso9660.Iso9660();

            cISO.OnFinish += new Iso9660.Iso9660EventHandler(cISO_OnFinish);
            cISO.OnMessage += new Iso9660.Iso9660EventHandler(cISO_OnMessage);
            cISO.OnProgress += new Iso9660.Iso9660EventHandler(cISO_OnProgress);

            foreach (DriveInfo CurrentDrive in DriveInfo.GetDrives())
            {
                // Vérification qu'on a bien affaire à un lecteur cd/dvd
                if (CurrentDrive.DriveType == DriveType.CDRom)
                {
                    // Vérification si il y a un cd-rom dedans
                    if (CurrentDrive.IsReady == true)
                    {
                        this.createiso_combobx_sourcedrive.Items.AddRange(new object[] { CurrentDrive.Name });
                    }
                }
            }
        }
        delegate void DelegMessage(string value);
        delegate void DelegFinish(string s, TimeSpan t);
        delegate void DelegProgress(long value);

        private void cISO_OnProgress(Iso9660.EventIso9660 e)
        {
            if (this.InvokeRequired)
            {
                DelegProgress del = new DelegProgress(SetProgress);
                this.Invoke(del, e.WrittenSize);
            }
        }

        private void cISO_OnFinish(Iso9660.EventIso9660 e)
        {
            if (this.InvokeRequired)
            {
                DelegFinish del = new DelegFinish(SetFinish);
                this.Invoke(del, new object[] { @"Creating iso finished.", e.TotalElapsedTime });
            }
        }

        private void cISO_OnMessage(Iso9660.EventIso9660 e)
        {
            if (this.InvokeRequired)
            {
                DelegMessage del = new DelegMessage(SetMessage);
                this.Invoke(del, e.ErrorMessage);
            }
        }

        private void SetProgress(long value)
        {
            UInt64 totalsize = Convert.ToUInt64(cISO.SizeOfCD.ToString());
            UInt64 test = totalsize;
            UInt64 newsizeinKB = totalsize / 1024;
            UInt64 newsizeinMB = newsizeinKB / 1024;
            UInt64 newsizeinGB = newsizeinMB / 1024;

            UInt64 currentsize = Convert.ToUInt64(value.ToString());
            UInt64 currentsizeinKB = currentsize / 1024;
            UInt64 currentsizeinMB = currentsizeinKB / 1024;
            UInt64 currentsizeinGB = currentsizeinMB / 1024;

            createiso_rogression_lbl.Text = @"Progression: " + currentsizeinMB + @"/" + newsizeinMB + "MB";
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = (100 * (int)currentsizeinMB) / (int)newsizeinMB;
            
            progressBar1.Step = 1;
            progressBar1.PerformStep();
           
        }

        private void SetMessage(string value)
        {
            createiso_status_lbl.Text = @"Status: " + value;
        }

        private void SetFinish(string s, TimeSpan t)
        {
            createiso_status_lbl.Text = @"Status: " + s + "Total Time Elapsed: " + t.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Volume label ophalen van het gekozen station.
            foreach (DriveInfo CurrentDrive in DriveInfo.GetDrives())
            {
                // Vérification qu'on a bien affaire à un lecteur cd/dvd
                if (CurrentDrive.DriveType == DriveType.CDRom)
                {
                    string volumelabel = CurrentDrive.VolumeLabel;
                    //SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "Disk Image | *.iso";
                    saveFileDialog1.Title = "Waar wil je de ISO opslaan?";
                    saveFileDialog1.FileName = volumelabel;
                    saveFileDialog1.ShowDialog();
                    textBox1.Text = saveFileDialog1.FileName;

                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text != "" && comboBox1.Text != "")
            if (String.IsNullOrEmpty(textBox1.Text) == false && String.IsNullOrEmpty(createiso_combobx_sourcedrive.Text) == false)
            {
                iso_maker(textBox1.Text, createiso_combobx_sourcedrive.Text);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Arret de la création
            cISO.Stop();
            createiso_status_lbl.Text = @"Status User pressed the stop button.";
        }

        private void createiso_combobx_sourcedrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            button1.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string pathfile = saveFileDialog1.InitialDirectory.ToString();
            MessageBox.Show(pathfile);
        }
    }
}
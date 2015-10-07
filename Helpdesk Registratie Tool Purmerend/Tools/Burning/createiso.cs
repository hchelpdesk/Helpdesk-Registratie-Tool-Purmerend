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
                    label2.Text = @"Status: " + @"ERREUR! Handle du lecteur invalide";
                    break;
                case -2:
                    label2.Text = @"Status: " + @"ERROR! Source is not an CD / DVD.";
                    break;
                case -3:
                    label2.Text = @"Status: " + @"ERROR! Not enough space to create the iso file.";
                    break;
                case -4:
                    label2.Text = @"Status: " + @"ERROR! a FAT32 file system cannot store a file > then 4096 MB";
                    break;
                case 1:
                    label2.Text = @"Status: " + @"Creating the iso File";
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
                this.Invoke(del, new object[] { @"Creating iso succeeded succefully.", e.TotalElapsedTime });
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
            Progression_lbl.Text = @"Progression: " + value.ToString() + @"/" + cISO.SizeOfCD.ToString();
        }

        private void SetMessage(string value)
        {
            createiso_status_lbl.Text = @"Status: " + value;
        }

        private void SetFinish(string s, TimeSpan t)
        {
            label2.Text = @"Status: " + s + "  Total Time Elapsed: " + t.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Disc Image |*.iso ";
            saveFileDialog1.Title = "Save an Disc Image File";
            saveFileDialog1.ShowDialog();
            textBox1.Text = saveFileDialog1.FileName;

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
        }
    }
}

// To Do List voor gehele project 

/* Uitlenen Overzicht - Teruggebracht knop
   - Controle inbouwen of tijddatumingeleverd leeg is of niet
     als deze niet leeg is msgbox laten zien dat product al
     ingeleverd is.
*/
using Helpdesk_Registratie_Tool_Purmerend.Incidenten;
using Helpdesk_Registratie_Tool_Purmerend.Klanten;
using Helpdesk_Registratie_Tool_Purmerend.Magazijn;
using Helpdesk_Registratie_Tool_Purmerend.Uitlenen;
using Helpdesk_Registratie_Tool_Purmerend.Backups;
using System;
using System.Windows.Forms;


namespace Helpdesk_Registratie_Tool_Purmerend
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }
        private Form cust_add;
        private void toevoegenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if ((cust_add == null) || (cust_add.IsDisposed))
            {
                cust_add = new cust_add();
                cust_add.MdiParent = this;
            }
            cust_add.Show();
        }
        private Form cust_overzicht;
        private void overzichtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((cust_overzicht == null) || (cust_overzicht.IsDisposed))
            {
                cust_overzicht = new cust_overzicht();
                cust_overzicht.MdiParent = this;
            }
            cust_overzicht.Show();
        }
        private Form uitlenen_overzicht;
        private void overzichtToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if ((uitlenen_overzicht == null) || (uitlenen_overzicht.IsDisposed))
            {
                uitlenen_overzicht = new uitlenen_overzicht();
                uitlenen_overzicht.MdiParent = this;
            }
            uitlenen_overzicht.Show();
        }
        private void aF4fsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private Form cust_import;
        private void importerenCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((cust_import == null) || (cust_import.IsDisposed))
            {
                cust_import = new cust_import();
                cust_import.MdiParent = this;
                cust_import.Focus();
            }
            cust_import.Show();
        }
        private Form call_add;
        private void toevoegenToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if ((call_add == null) || (call_add.IsDisposed))
            {
                call_add = new call_add();
                call_add.MdiParent = this;
                call_add.Focus();
            }
            call_add.Show();
        }
        private Form magazijn_invoeren;
        private void toevoegenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((magazijn_invoeren == null) || (magazijn_invoeren.IsDisposed))
            {
                magazijn_invoeren = new magazijn_invoeren();
                magazijn_invoeren.MdiParent = this;
                magazijn_invoeren.Focus();
            }
            magazijn_invoeren.Show();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
        private Form sqlbackup;
        private void mSSQLBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((sqlbackup == null) || (sqlbackup.IsDisposed))
            {
                sqlbackup = new sqlbackup();
                sqlbackup.MdiParent = this;
                sqlbackup.Focus();
            }
            sqlbackup.Show();

        }
    }

}




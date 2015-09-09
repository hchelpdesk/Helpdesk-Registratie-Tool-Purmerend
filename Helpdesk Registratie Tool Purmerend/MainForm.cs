// To Do List voor gehele project 

/* Uitlenen Overzicht - Teruggebracht knop
   - Controle inbouwen of tijddatumingeleverd leeg is of niet
     als deze niet leeg is msgbox laten zien dat product al
     ingeleverd is.
*/
using Helpdesk_Registratie_Tool_Purmerend.Incidenten;
using Helpdesk_Registratie_Tool_Purmerend.Klanten;
using Helpdesk_Registratie_Tool_Purmerend.Uitlenen;
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

        private void toevoegenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            cust_add newMDIChild = new cust_add();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void overzichtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cust_overzicht NewMDIChild = new cust_overzicht();
            // set the parent form of the child window
            NewMDIChild.MdiParent = this;
            // Display new form
            NewMDIChild.Show();
        }

        private void overzichtToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            uitlenen_overzicht NewMDIChild = new uitlenen_overzicht();
            NewMDIChild.MdiParent = this;
            NewMDIChild.Show();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void aF4fsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void overzichtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void importerenCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cust_import NewMDIChild = new cust_import();
            NewMDIChild.MdiParent = this;
            NewMDIChild.Show();
        }

        private void toevoegenToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            call_add NewMDIChild = new call_add();
            NewMDIChild.MdiParent = this;
            NewMDIChild.Show();
        }
    }
}


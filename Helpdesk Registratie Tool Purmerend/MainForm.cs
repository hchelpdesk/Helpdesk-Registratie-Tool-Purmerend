﻿// To Do List voor gehele project 

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
using Helpdesk_Registratie_Tool_Purmerend.Beheer;
using Helpdesk_Registratie_Tool_Purmerend.Tools.Burning;
using Helpdesk_Registratie_Tool_Purmerend.Tools.Telnet;
using System;
using System.Windows.Forms;
using System.Drawing;

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
            cust_add.Activate();
            cust_add.Focus();
        }
        private Form cust_overzicht;
        private void overzichtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((cust_overzicht == null) || (cust_overzicht.IsDisposed))
            {
                cust_overzicht = new cust_overzicht();
                cust_overzicht.MdiParent = this;
            }
            //cust_overzicht.Location = new Point(0, 350);
            cust_overzicht.Show();
            cust_overzicht.Activate();
            cust_overzicht.Focus();
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
            uitlenen_overzicht.Activate();
            uitlenen_overzicht.Focus();
        }
        private void aF4fsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private Form cust_import;
        
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
            call_add.Activate();
            call_add.Focus();
        }
        private Form magazijn_toevoegen;
        private void toevoegenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((magazijn_toevoegen == null) || (magazijn_toevoegen.IsDisposed))
            {
                magazijn_toevoegen = new magazijn_toevoegen();
                magazijn_toevoegen.MdiParent = this;
                magazijn_toevoegen.Focus();
            }
            magazijn_toevoegen.Show();
            magazijn_toevoegen.Activate();
            magazijn_toevoegen.Focus();

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
            cust_overzicht.Activate();
            cust_overzicht.Focus();

        }

        private void importerenUitCSVToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((cust_import == null) || (cust_import.IsDisposed))
            {
                cust_import = new cust_import();
                cust_import.MdiParent = this;
                cust_import.Focus();
            }
            cust_import.Show();
            cust_import.Activate();
            cust_import.Focus();
        }
        private Form beheer_inlog_form;
        private void inloggenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((beheer_inlog_form == null) || (beheer_inlog_form.IsDisposed))
            {
                beheer_inlog_form = new beheer_login_form();
                beheer_inlog_form.MdiParent = this;
                Focus();
            }
            //beheer_inlogform.Show();
            cust_overzicht.Activate();
            cust_overzicht.Focus();
        }
        private Form magazijn_overzicht;
        private void overzichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((magazijn_overzicht == null) || (magazijn_overzicht.IsDisposed))
            {
                magazijn_overzicht = new magazijn_overzicht();
                magazijn_overzicht.MdiParent = this;
                Focus();
            }
            magazijn_overzicht.Show();
            magazijn_overzicht.Activate();
            magazijn_overzicht.Focus();
        }
        private Form call_overzicht;
        private void overzichtToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if ((call_overzicht == null) || (call_overzicht.IsDisposed))
            {
                call_overzicht = new call_overzicht();
                call_overzicht.MdiParent = this;
                Focus();
            }
            call_overzicht.Show();
            call_overzicht.Activate();
            call_overzicht.Focus();
        }
        private Form createiso;
        private void createISOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((createiso == null) || (createiso.IsDisposed))
            {
                createiso = new createiso();
                createiso.MdiParent = this;
                Focus();
            }
            createiso.Show();
            createiso.Activate();
            createiso.Focus();
        }
        private Form burniso;
        private void burnISOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((burniso == null) || (burniso.IsDisposed))
            {
                burniso = new burniso();
                burniso.MdiParent = this;
                Focus();
            }
            burniso.Show();
            burniso.Activate();
            burniso.Focus();
        }
        private Form telnet;
        private void telnetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((telnet == null) || (telnet.IsDisposed))
            {
                telnet = new telnet();
                telnet.MdiParent = this;
                Focus();
            }
            telnet.Show();
            telnet.Activate();
            telnet.Focus();
        }
    }

}




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpdesk_Registratie_Tool_Purmerend.Magazijn
{
    public partial class magazijn_toevoegen : Form
    {
       
        public magazijn_toevoegen()
        {
            InitializeComponent();
        }
        private void magazijn_toevoegen_enkelproductoevoegen_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible = false;
        }

        private void magazijn_toevoevoegen_btn_productoevoegen_Click(object sender, EventArgs e)
        {

        }

    }
}

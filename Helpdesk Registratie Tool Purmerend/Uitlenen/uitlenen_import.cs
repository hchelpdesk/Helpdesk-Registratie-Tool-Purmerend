using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpdesk_Registratie_Tool_Purmerend.Uitlenen
{
    public partial class uitlenen_import : Form
    {
        public uitlenen_import()
        {
            InitializeComponent();
        }

        private void uitlenen_import_btn_browse_Click(object sender, EventArgs e)
        {
            uitlenen_import_csv.ShowDialog();

        }

        private void uitlenen_import_Load(object sender, EventArgs e)
        {

        }
    }
}

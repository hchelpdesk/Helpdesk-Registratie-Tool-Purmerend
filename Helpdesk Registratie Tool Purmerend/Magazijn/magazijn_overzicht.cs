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
    public partial class magazijn_overzicht : Form
    {
        public magazijn_overzicht()
        {
            InitializeComponent();
        }

        private void magazijn_overzicht_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'magazijnProductsDataSet.magazijn_products' table. You can move, or remove it, as needed.
            this.magazijn_productsTableAdapter.Fill(this.magazijnProductsDataSet.magazijn_products);

        }
    }
}

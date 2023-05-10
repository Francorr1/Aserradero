using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aserradero
{
    public partial class frmErrorConexion : Form
    {

        clsHerramientasInterfaz herramientasInterfaz = new clsHerramientasInterfaz();

        public frmErrorConexion()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

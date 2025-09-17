using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appkodak
{
    public partial class FrmHerramientasdeProductos : Form
    {
        public FrmHerramientasdeProductos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDatosCompletos_Click(object sender, EventArgs e)
        {
            FrmProducto frmProducto = new FrmProducto();
            frmProducto.ShowDialog();
        }

        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            FrmCargarProducto frmCargarProducto = new FrmCargarProducto();
            frmCargarProducto.ShowDialog();
        }
    }
}

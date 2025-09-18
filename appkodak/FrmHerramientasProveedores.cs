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
    public partial class FrmHerramientasProveedores : Form
    {
        public FrmHerramientasProveedores()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargarProveedores_Click(object sender, EventArgs e)
        {
            FrmCargaProveedores frmCargaProveedores = new FrmCargaProveedores();
            frmCargaProveedores.ShowDialog();
        }
    }
}

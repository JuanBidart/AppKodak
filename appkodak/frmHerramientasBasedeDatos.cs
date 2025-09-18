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
    public partial class frmHerramientasBasedeDatos : Form
    {
        public frmHerramientasBasedeDatos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDatosCOnexion_Click(object sender, EventArgs e)
        {
            FrmDatosConexionBasedeDatos frmDatosConexion = new FrmDatosConexionBasedeDatos();
            frmDatosConexion.ShowDialog();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            FrmBackResBD frmBackup = new FrmBackResBD();
            frmBackup.ShowDialog();
        }

        private void btnEjecutaConsultas_Click(object sender, EventArgs e)
        {
            FrmEjecutarSentenciaSql frmEjecutarSentenciaSql = new FrmEjecutarSentenciaSql();
            frmEjecutarSentenciaSql.ShowDialog();
        }
    }
}

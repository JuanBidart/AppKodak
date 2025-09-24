using Negocio;
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
    public partial class FrmCargarProducto : Form
    {
        public FrmCargarProducto()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGUardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDescripcion.Text) | String.IsNullOrEmpty(txtRecargo.Text))
            {
                MessageBox.Show("Descripcion y Recargo son campos obligatorio", "Datos Requeridos");
                return;
            }
            else
            {
                try
                {

                }
                catch (Exception)
                {

                    throw;
                }
            }

        }

        private void txtRecargo_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtRecargo.Text))
            {
                bool esNumero = Herramientas.ValidarNumeros(txtRecargo.Text);
                int largo = txtRecargo.Text.Length -1;
                switch (esNumero)
                {
                    case true: 
                        break;
                    case false: string textonuevo = txtRecargo.Text.Remove(largo);
                        txtRecargo.Text = textonuevo;
                        txtRecargo.SelectionStart = txtRecargo.Text.Length;

                        break;
                    default:
                }
                
            }
        }
    }
}
    




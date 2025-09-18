using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appkodak
{
    public partial class FrmCargaProveedores : Form
    {
        public FrmCargaProveedores()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text)|| string.IsNullOrEmpty(txtIva.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    ConexionProveedores ConexionProveedores = new ConexionProveedores();
                    Tproveedor tproveedor = new Tproveedor();
                    tproveedor.Nombre = txtNombre.Text;
                    tproveedor.Ciudad = txtCiudad.Text;
                    tproveedor.Direccion = txtDireccion.Text;
                    tproveedor.Email = txtEmail.Text;
                    tproveedor.Telefono1 = txtTelefonoP.Text;
                    tproveedor.Telefono2 = txtTelefonoSec.Text;
                    tproveedor.PaginaWeb = txtWeb.Text;
                    tproveedor.Iva = Convert.ToDecimal(txtIva.Text);


                    ConexionProveedores.InsertarAsync(tproveedor);

                    MessageBox.Show("Proveedor guardado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarTextBoxes(this);

                }
                catch (Exception ex)
                {

                    new Exception("Error al guardar el proveedor", ex);
                }
            }
        }
        // Pseudocódigo:
        // 1. Recorrer todos los controles del formulario de manera recursiva.
        // 2. Si el control es un TextBox, limpiar su texto.
        // 3. Usar un método auxiliar para recorrer los controles hijos.

        private void LimpiarTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox txt)
                {
                    txt.Text = string.Empty;
                }
                // Recursivamente limpiar los controles hijos
                LimpiarTextBoxes(c);
            }
        }

       private void txtIva_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números, el punto decimal y la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                errorProvider1.SetError(txtIva, "Ingrese un valor numérico válido para IVA.");
                
                e.Handled = true;

            }
            else { errorProvider1.SetError(txtIva, ""); }
            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                
                e.Handled = true;
            }
        }

    }


}

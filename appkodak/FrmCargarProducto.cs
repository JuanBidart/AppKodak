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
using Dominio;


namespace appkodak
{
    public partial class FrmCargarProducto : Form
    {
        List<Tproveedor>? listaProveedores = null;
        public FrmCargarProducto()
        {
            
            
            InitializeComponent();
            
        }

        // Método que obtiene los datos: Haz que retorne un Task<List<Tproveedor>>
        private async Task ObtenerListaProveedoresAsync()
        {
            var conexionProveedores = new ConexionProveedores();
            // Esperamos la finalización de la consulta antes de continuar
            listaProveedores = await conexionProveedores.ObtenerTodosAsync();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async Task InsertarProducto()
        {
            ConexionProducto conexionProducto = new ConexionProducto();

            await conexionProducto.InsertarAsync(new Tproductos
            {
                Cod = txtCodigo.Text,
                Nombre = txtDescripcion.Text,
                Recargo = Convert.ToDecimal(txtRecargo.Text),
                Fecha = Convert.ToDateTime(txtFecha.Text),
                Stock = Convert.ToInt32(txtStock.Text),
                Iva = Convert.ToDecimal(txtIva.Text),
                Marca = txtMarca.Text,
                Observacion = txtObservacion.Text,
                Activo = true
            });

        }

        
        private async void btnGUardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDescripcion.Text) || String.IsNullOrEmpty(txtRecargo.Text) || String.IsNullOrEmpty(cbxProveedor.Text))
            {
                MiMensaje.Show("Descripcion, Proveedor y Recargo son campos obligatorio", "Datos Requeridos",MiMensaje.MbxIcon.Exclamacion);
                return;
            }
            else
            {
                try
                {
                   await InsertarProducto();
                    MiMensaje.Show("Producto guardado con exito","ok",MiMensaje.MbxIcon.Info,new[] { MiMensaje.MbxButton.Ok },3000);
                    
                }
                catch (Exception ex)
                {
                    MiMensaje.Show(ex.ToString(), "Error", MiMensaje.MbxIcon.Error);
                }
            }
        }

        private void txtRecargo_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtRecargo.Text))
            {
                bool esNumero = Herramientas.EsNumero(txtRecargo.Text);
                if (!esNumero)
                {
                    MiMensaje.Show("El recargo debe ser un valor numerico", "Error en el dato", MiMensaje.MbxIcon.Error, new[] { MiMensaje.MbxButton.Ok });
                    
                    txtRecargo.Focus();
                    txtRecargo.SelectAll();
                }
            }

        }

        // Evento Load: Usa 'async' y 'await'
        private async void FrmCargarProducto_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToShortDateString();
            txtFecha.Enabled = false;
            this.TopLevel = true;
            

            // 1. Ejecuta la carga de datos y espera a que termine
            await ObtenerListaProveedoresAsync();

            // 2. Ahora, listaProveedores ya tendrá los datos (o será null si hubo un error)
            if (listaProveedores != null && listaProveedores.Any()) // También verifica que no esté vacío
            {
                List<string> nombresProveedores = listaProveedores.OrderBy(p => p.Nombre).Select(p => p.Nombre).ToList();
                cbxProveedor.DataSource = nombresProveedores;
            }
            else
            {
                // Opcional: Maneja el caso en que no se carguen los proveedores
                MiMensaje.Show("No se pudieron cargar los proveedores.", "Error", MiMensaje.MbxIcon.Error);
            }
            txtCodigo.Select();
            txtCodigo.Focus();
        }

    }
    
}





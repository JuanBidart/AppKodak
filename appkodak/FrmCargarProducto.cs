using Negocio;
using System;
using System.Collections.Generic;
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

        // --- MÉTODOS AUXILIARES NECESARIOS PARA EL GUARDADO TRANSACCIONAL ---

        private Tproductos MapearProductoDesdeControles()
        {
            // Mapeo de datos desde los campos del formulario a la entidad Tproductos
            return new Tproductos
            {
                Cod = txtCodigo.Text,
                Nombre = txtDescripcion.Text,
                // Manejar la conversión de manera segura (con TryParse)
                Recargo = decimal.TryParse(txtRecargo.Text, out decimal recargo) ? recargo : 0m,
                Fecha = DateTime.TryParse(txtFecha.Text, out DateTime fecha) ? fecha : DateTime.Now,
                Stock = int.TryParse(txtStock.Text, out int stock) ? stock : 0,
                Iva = decimal.TryParse(txtIva.Text, out decimal iva) ? iva : 0m,
                Marca = txtMarca.Text,
                Observacion = txtObservacion.Text,
                Activo = true
            };
        }

        private TproductoProveedor MapearProductoProveedorDesdeControles(int idProducto, int idProveedor)
        {
            // Mapeo de datos para TproductoProveedor
            return new TproductoProveedor
            {
                IdProducto = (long)idProducto, // Usamos el ID recién creado
                IdProveedor = (long)idProveedor,

                // Estos campos deben obtenerse de la interfaz o tener valores por defecto
                PrecioCosto = decimal.TryParse(txtCosto.Text, out decimal precioCosto) ? precioCosto : (decimal?)null,
                FechaActualizacion = DateTime.Now,
                EsPrincipal = chxSi.Checked,
                CodigoProveedor = txtCodProductoProveedor.Text,
                PlazoEntregaDias = null,
                Moq = null,
                Moneda = null,
                Activo = true
            };
        }

        private int ObtenerIdProveedorSeleccionado()
        {
            if (cbxProveedor.SelectedItem != null && listaProveedores != null)
            {
                // Busca en la lista de proveedores (cargada en el Load) el ID correspondiente al nombre seleccionado.
                string nombreSeleccionado = cbxProveedor.SelectedItem.ToString();
                var proveedor = listaProveedores.FirstOrDefault(p => p.Nombre == nombreSeleccionado);

                // Si encontramos el proveedor, devolvemos su ID
                if (proveedor != null)
                {
                    return (int)proveedor.Id; // Id es de tipo long, lo convertimos a int
                }
            }
            return 0;
        }

        // --- EVENTOS DEL FORMULARIO ---

        private async Task ObtenerListaProveedoresAsync()
        {
            var conexionProveedores = new ConexionProveedores();
            try
            {
                listaProveedores = await conexionProveedores.ObtenerTodosAsync();
            }
            catch (Exception ex)
            {
                MiMensaje.Show($"Error al cargar proveedores: {ex.Message}", "Error", MiMensaje.MbxIcon.Error);
                listaProveedores = new List<Tproveedor>(); // Asegura que no sea null
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnGUardar_Click(object sender, EventArgs e)
        {
            // === 1. VALIDACIÓN INICIAL ===
            if (String.IsNullOrEmpty(txtDescripcion.Text) || String.IsNullOrEmpty(txtRecargo.Text) || String.IsNullOrEmpty(cbxProveedor.Text))
            {
                MiMensaje.Show("Descripcion, Proveedor y Recargo son campos obligatorios", "Datos Requeridos", MiMensaje.MbxIcon.Exclamacion);
                return;
            }

            // === 2. PREPARACIÓN DE RECURSOS Y OBTENCIÓN DE ID ===
            int idProveedor = ObtenerIdProveedorSeleccionado();

            if (idProveedor <= 0)
            {
                MiMensaje.Show("No se pudo obtener el ID del proveedor seleccionado. Intente de nuevo.", "Error", MiMensaje.MbxIcon.Error);
                return;
            }

            // Instancias de la capa Negocio
            ConexionGeneral conexionGeneral = new ConexionGeneral();
            ConexionProducto repoProducto = new ConexionProducto();
            ConexionProductoProveedor repoProdProv = new ConexionProductoProveedor();

            try
            {
                // === 3. EJECUTAR TRANSACCIÓN ===
                await conexionGeneral.EjecutarTransaccionAsync(async (conexion, transaccion) =>
                {
                    // --- A. PREPARAR Y INSERTAR PRODUCTO ---
                    Tproductos producto = MapearProductoDesdeControles();

                    // Insertar producto y obtener su ID
                    int idProducto = await repoProducto.InsertarProductoConTransaccionAsync(producto, conexion, transaccion);

                    if (idProducto <= 0)
                        throw new Exception("Error al obtener el ID del producto insertado.");

                    // --- B. PREPARAR E INSERTAR PRODUCTO-PROVEEDOR ---
                    TproductoProveedor prodProv = MapearProductoProveedorDesdeControles(idProducto, idProveedor);

                    // Insertar la relación producto-proveedor
                    await repoProdProv.InsertarProductoProveedorConTransaccionAsync(prodProv, conexion, transaccion);

                    // Si llegamos aquí, ambas operaciones fueron exitosas
                    // La transacción se confirmará automáticamente
                });

                // === 4. ÉXITO (Si la transacción se confirmó) ===
                MiMensaje.Show("Producto guardado con éxito", "Éxito", MiMensaje.MbxIcon.Info, new[] { MiMensaje.MbxButton.Ok }, 3000);

                // Opcional: Limpiar el formulario después del guardado exitoso
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                // === 5. FALLO (Rollback automático) ===
                MiMensaje.Show($"Error durante la transacción: {ex.Message}", "Error de Guardado", MiMensaje.MbxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            txtCodigo.Clear();
            txtDescripcion.Clear();
            txtRecargo.Clear();
            txtStock.Clear();
            txtIva.Clear();
            txtMarca.Clear();
            txtObservacion.Clear();
            txtCosto.Clear();
            txtCodProductoProveedor.Clear();
            cbxProveedor.SelectedIndex = -1;
            txtCodigo.Focus();
        }

        private void txtRecargo_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtRecargo.Text))
            {
                bool esNumero = Herramientas.EsNumero(txtRecargo.Text);
                if (!esNumero)
                {
                    MiMensaje.Show("El recargo debe ser un valor numérico", "Error en el dato", MiMensaje.MbxIcon.Error, new[] { MiMensaje.MbxButton.Ok });
                    txtRecargo.Focus();
                    txtRecargo.SelectAll();
                }
            }
        }

        private async void FrmCargarProducto_Load(object sender, EventArgs e)
        {
            chxSi.Checked = true;
            txtFecha.Text = DateTime.Now.ToShortDateString();
            txtFecha.Enabled = false;
            this.TopLevel = true;
            txtIva.Text = "0"; // Valor por defecto del IVA
            txtRecargo.Text = "0"; // Valor por defecto del Recargo

            await ObtenerListaProveedoresAsync();

            if (listaProveedores != null && listaProveedores.Any())
            {
                List<string> nombresProveedores = listaProveedores.OrderBy(p => p.Nombre).Select(p => p.Nombre).ToList();
                cbxProveedor.DataSource = nombresProveedores;
            }
            else
            {
                MiMensaje.Show("No se pudieron cargar los proveedores.", "Error", MiMensaje.MbxIcon.Error);
            }

            txtCodigo.Select();
            txtCodigo.Focus();
        }
        private void CalcularPrecioFinal()
        {
            if (decimal.TryParse(txtCosto.Text, out decimal costo) &&
                decimal.TryParse(txtRecargo.Text, out decimal recargo) &&
                decimal.TryParse(txtIva.Text, out decimal iva))
            {
                decimal precioConRecargo = costo + (costo * recargo / 100);
                decimal precioFinal = precioConRecargo + (precioConRecargo * iva / 100);
                txtPrecioFInal.Text = precioFinal.ToString("C2");
            }
            else
            {
                txtPrecioFInal.Text = string.Empty; // Limpia el campo si no se pueden calcular
            }
        }
        private void txtCosto_Leave(object sender, EventArgs e)
        {
            string costoText = txtCosto.Text.Trim();
            if (!string.IsNullOrEmpty(costoText))
            {
                if (!decimal.TryParse(costoText, out decimal costo) || costo < 0)
                {
                    MiMensaje.Show("El costo debe ser un valor numérico positivo.", "Error en el dato", MiMensaje.MbxIcon.Error, new[] { MiMensaje.MbxButton.Ok });
                    txtCosto.Focus();
                    txtCosto.SelectAll();
                }
               CalcularPrecioFinal();
            }
        }

        private void txtRecargo_TextChanged(object sender, EventArgs e)
        {
            string recargoText = txtRecargo.Text.Trim();
            if (!string.IsNullOrEmpty(txtCosto.Text))
            {
                if (!decimal.TryParse(recargoText, out decimal costo) || costo < 0)
                {
                    MiMensaje.Show("El costo debe ser un valor numérico positivo.", "Error en el dato", MiMensaje.MbxIcon.Error, new[] { MiMensaje.MbxButton.Ok });
                    txtCosto.Focus();
                    txtCosto.SelectAll();
                }
                CalcularPrecioFinal();
            }
        }

        private void txtIva_TextChanged(object sender, EventArgs e)
        {
            string ivaText = txtIva.Text.Trim();

            if (string.IsNullOrEmpty(ivaText))
            {
               CalcularPrecioFinal();
                return;
            }
            
            if (!string.IsNullOrEmpty(txtCosto.Text))
            {
                if (!decimal.TryParse(ivaText, out decimal costo) || costo < 0)
                {
                    MiMensaje.Show("El costo debe ser un valor numérico positivo.", "Error en el dato", MiMensaje.MbxIcon.Error, new[] { MiMensaje.MbxButton.Ok });
                    txtCosto.Focus();
                    txtCosto.SelectAll();
                }
                CalcularPrecioFinal();

            }
        }
    }
}
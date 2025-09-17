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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            ConexionProducto conexionProducto = new ConexionProducto();
            dgvProductos.DataSource = conexionProducto.ObtenerTodosAsync();

        }

        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            FrmCargarProducto cargarProducto = new FrmCargarProducto();
            cargarProducto.ShowDialog();
        }
    }
}

using Dominio;
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
    public partial class FrmListasdePrecio_revendedorProfesional : Form
    {
        List<TlistaPrecio> listas = null;

        public FrmListasdePrecio_revendedorProfesional()
        {
            InitializeComponent();
        }

        private async void FrmListasdePrecio_revendedorProfesional_Load(object sender, EventArgs e)
        {
            ConexionListas conexionListas = new ConexionListas();
            listas = await conexionListas.ObtenerListasAsync();
            dgvListas.DataSource = listas;
        }

        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLista.Text) && string.IsNullOrEmpty(txtPorcentaje.Text))
            {
                MiMensaje.Show("Los campos lista y porcentaje son obligatorios","Datos Incompletos",MiMensaje.MbxIcon.Error,new[] { MiMensaje.MbxButton.Ok});
                txtLista.Focus();
                txtLista.SelectAll();
            }
            else
            {

            }
        }
    }
}

using Dominio;
using Microsoft.VisualBasic.ApplicationServices;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appkodak
{
    public partial class FormPrincipal2 : Form
    {
        public FormPrincipal2()
        {
            InitializeComponent();
            this.BackColor = colorApp.Fondo;

        }
        public void setdefaultcolors()
        {
            panel1.BackColor = colorApp.Fondo;
        }
        private Form? activeForm = null;

        private void abrirFormularioHijo(Form formulariohijo)
        {
            if (activeForm != null && activeForm.GetType() == formulariohijo.GetType())
            {
                return;
            }

            if (activeForm != null)
            {
                panelVentana.Controls.Remove(activeForm); // Solo quita el formulario anterior
                activeForm.Close();
                activeForm = null;
            }

            activeForm = formulariohijo;
            formulariohijo.TopLevel = false;
            formulariohijo.Dock = DockStyle.Fill;
            formulariohijo.FormBorderStyle = FormBorderStyle.None;
            panelVentana.Controls.Add(formulariohijo);
            panelVentana.Tag = formulariohijo;
            formulariohijo.BringToFront();
            formulariohijo.FormClosed += (s, e) => activeForm = null;
            formulariohijo.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var colorForm = new Colorselectionr();
            colorForm.FormClosed += (s, args) => setdefaultcolors();
            abrirFormularioHijo(colorForm);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmHerramientasdeProductos frmHerramientasProductos = new FrmHerramientasdeProductos();
            abrirFormularioHijo(frmHerramientasProductos);
        }


        private void btnBasedeDatos_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmHerramientasBasedeDatos());
        }

        private void FormPrincipal2_Load(object sender, EventArgs e)
        {
            timer100ms.Start();
            timer100ms.Tick += TimerPrincipal_Tick;
            lblDia.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy").ToUpper();

        }

        private void Timer1min_Tick(object? sender, EventArgs e)
        {

        }

        private void TimerPrincipal_Tick(object? sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt").ToUpper();
            DateTime Timeapp = DateTime.ParseExact(lblDia.Text, "dddd, dd 'DE' MMMM 'DE' yyyy", new CultureInfo("Es-ar"));

            if (DateTime.Now.Day != Timeapp.Day)
            {

                lblDia.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy").ToUpper();
            }
        }

        private async void btnProbarConexion_Click(object sender, EventArgs e)
        {
            try
            {
                ConexionGeneral conexion = new ConexionGeneral();
                if (conexion != null)
                {
                    MessageBox.Show("Conexión exitosa a la base de datos.", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al conectar a la base de datos.");
                }

                var estadoConexion = await conexion.Estado();
                if (estadoConexion.conexion != null && estadoConexion.conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Dispose();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void bbtnProveedores_Click(object sender, EventArgs e)
        {
            FrmHerramientasProveedores frmHerramientasProveedores = new FrmHerramientasProveedores();
            abrirFormularioHijo(frmHerramientasProveedores);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cerrando la aplicación", "Salir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
            ConexionGeneral conexionGeneral = new ConexionGeneral();
            conexionGeneral.Dispose();
            this.Close();
        }
    }
}

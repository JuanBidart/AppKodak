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
            Task Inicio = Task.Run(() => { MiMensaje.Show("Iniciando la aplicación...", "Espere", MiMensaje.MbxIcon.Info, null, 2000); });
            Inicio.Wait();
            InitializeComponent();
            this.BackColor = colorApp.Fondo;
            ObtenerDolar();

        }

        public async void ObtenerDolar()
        {
            try
            {
                ConexionApiDolar datosDolar = await ConexionApiDolar.CreateAsync();
                lblCompraOficial.Text = datosDolar.compraOficial;
                lblVentaOficial.Text = datosDolar.ventaOficial;
                lblUltimaActualizacionOficial.Text = datosDolar.fechaOficial;
                lblCompreBlue.Text = datosDolar.compraBlue;
                lblVentaBlue.Text = datosDolar.ventaBlue;
                lblUltimaActualizacionBlue.Text = datosDolar.fechaBlue;

            }
            catch (Exception ex)
            {
                lblCompraOficial.Text = "$0";
                lblVentaOficial.Text = "$0";
                lblUltimaActualizacionOficial.Text = "Error Conexion";
                lblCompreBlue.Text = "$0";
                lblVentaBlue.Text = "$0";
                lblUltimaActualizacionBlue.Text = "Error Conexion";
            }
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
            if (DateTime.Now.Hour > 8 && DateTime.Now.Hour < 14)
            {
                if (DateTime.Now.Minute == 0 && DateTime.Now.Second == 30 || DateTime.Now.Minute == 30 && DateTime.Now.Second == 30)
                {
                    ObtenerDolar();
                }
            }

        }

        

        private void bbtnProveedores_Click(object sender, EventArgs e)
        {
            FrmHerramientasProveedores frmHerramientasProveedores = new FrmHerramientasProveedores();
            abrirFormularioHijo(frmHerramientasProveedores);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MiMensaje.Show("Cerrando la aplicación", "Salir", MiMensaje.MbxIcon.Info, null, 2000);

            Dispose();
            ConexionGeneral conexionGeneral = new ConexionGeneral();
            conexionGeneral.Dispose();
            this.Close();
        }

        private async void btnProbarConexion_Click_1(object sender, EventArgs e)
        {
            try
            {
                ConexionGeneral conexion = new ConexionGeneral();
                if (conexion != null)
                {
                    MiMensaje.Show("Probando conexión a la base de datos...", "Espere", MiMensaje.MbxIcon.Info, null, 2000);
                    MiMensaje.Show("Conexión exitosa a la base de datos.", "Ok", MiMensaje.MbxIcon.Info, null, 3000);

                }
                else
                {
                    MiMensaje.Show("Error al conectar a la base de datos.", "Error", MiMensaje.MbxIcon.Error, null, 3000);


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
    }
}

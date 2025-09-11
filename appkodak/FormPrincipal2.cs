using Microsoft.VisualBasic.ApplicationServices;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            CLientes cLientes = new CLientes();
            cLientes.ShowDialog();
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            try
            {
                ConexionGeneral conexion = new ConexionGeneral();
                if (conexion != null)
                {
                    pbxNotificacion.Load(@".\Icons8\ok.jpg");
                    MessageBox.Show("Conexión exitosa a la base de datos.", conexion.estado().FullState.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);



                }
                else
                {
                    pbxNotificacion.Load("./Icons8/no.jpg");
                    MessageBox.Show("Error al conectar a la base de datos.");

                }

                if (conexion.estado().FullState == System.Data.ConnectionState.Open)
                {
                    conexion.cerrarConexion();
                }
            }
            catch (Exception)
            {

                throw;
            }



        }

        private void btnBasedeDatos_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmHerramientasBasedeDatos());
        }  
    }
}

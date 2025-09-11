using Negocio;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appkodak
{
    public partial class FrmDatosConexionBasedeDatos : Form
    {
        public string? host { get; set; }
        public string? usuario { get; set; }
        public string? password { get; set; }
        public string? database { get; set; }

        public FrmDatosConexionBasedeDatos()
        {
            InitializeComponent();

            

        }
        private void cargarPropiedades()
        {
           ConexionDatos config = new ConexionDatos();

            if (config != null)
            {
                host = config.host;
                usuario = config.username;
                password = config.password;
                database = config.database;
            }

            // Actualizamos los TextBox aquí mismo
            txtHostActual.Text = host;
            txtUsernameActual.Text = usuario;
            txtpaswordActual.Text = password;
            txtDatabaseActual.Text = database;
        }
        private void btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDatosConexionBasedeDatos_Load(object sender, EventArgs e)
        {
            cargarPropiedades();
        }

        private void btnProbarNuevaConexion_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { txtHost, txtUsername, txtPassword, txtDatabase };
            foreach (var textBox in textBoxes)
            {
                if (textBox.Text == string.Empty)
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
            try
            {
                ConexionGeneral conexionGeneral = new ConexionGeneral($"Host={txtHost.Text};Username={txtUsername.Text};Password={txtPassword.Text};Database={txtDatabase.Text}");
                conexionGeneral.abrirConexion();
                lblestadonuevo.Text = "¡¡¡ Conexión exitosa !!!";
                lblestadonuevo.ForeColor = Color.LightSeaGreen;
                conexionGeneral.cerrarConexion();

            }



            catch (Exception ex)
            {
                //MessageBox.Show("Error al conectar a la base de datos: " + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblestadonuevo.Text = "Error " + ex.Message.ToString();
                lblestadonuevo.ForeColor = Color.Red;
                return;

            }




        }

        private async void btnGuardarDatos_Click(object sender, EventArgs e)
        {

            TextBox[] textBoxes = { txtHost, txtUsername, txtPassword, txtDatabase };
            foreach (var textBox in textBoxes)
            {
                if (textBox.Text == string.Empty)
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            try
            {
                ConexionDatos conexionDatos = new ConexionDatos();
                conexionDatos.guardarDatos(txtHost.Text, txtUsername.Text, txtPassword.Text, txtDatabase.Text);

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnProbarConExistente_Click(object sender, EventArgs e)
        {
            try
            {
                ConexionGeneral conexionGeneral = new ConexionGeneral($"Host={host};Username={usuario};Password={password};Database={database}");
                conexionGeneral.abrirConexion();
                lblestadonuevo.Text = "¡¡¡ Conexión exitosa !!!";
                lblestadonuevo.ForeColor = Color.LightSeaGreen;
                conexionGeneral.cerrarConexion();

            }
            catch (Exception ex)
            {
                lblestadonuevo.Text = "Error " + ex.Message.ToString();
                lblestadonuevo.ForeColor = Color.Red;
                return;
            }
            
        }

       
    }
}

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

        private async void btnProbarNuevaConexion_Click(object sender, EventArgs e)
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
                this.Cursor = Cursors.WaitCursor;
               
                bool prueba = false;
                using (ConexionGeneral conexionGeneral = new ConexionGeneral($"Host={txtHost.Text};Username={txtUsername.Text};Password={txtPassword.Text};Database={txtDatabase.Text}"))
                {
                    prueba = await conexionGeneral.ProbarConexionAsync();

                    if (prueba)
                    {
                        lblestadonuevo.Text = "¡¡¡ Conexión exitosa !!!";
                        lblestadonuevo.ForeColor = Color.LightSeaGreen;
                        this.Cursor = Cursors.Default;
                    }
                    else
                    {
                        var estado = await conexionGeneral.Estado();
                        lblestadonuevo.Text = estado.errorMensaje ?? "Error desconocido";
                        lblestadonuevo.ForeColor = Color.Red;
                        this.Cursor = Cursors.Default;
                    }
                }
             
            }
            catch (Exception ex)
            {
                lblestadonuevo.Text = "Error " + ex.Message;
                lblestadonuevo.ForeColor = Color.Red;
                this.Cursor = Cursors.Default;
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
                MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                throw new Exception("Error al guardar los datos de conexión.");
            }
        }

        private async void btnProbarConExistente_Click(object sender, EventArgs e)
        {
            try
            {
                bool prueba = false;
                // La clase ConexionGeneral es IDisposable, por lo que es mejor usar 'using'.
                using (ConexionGeneral conexionGeneral = new ConexionGeneral($"Host={host};Username={usuario};Password={password};Database={database}"))
                {
                    // Ahora esperamos de forma asíncrona, sin bloquear el hilo de la UI.
                    prueba = await conexionGeneral.ProbarConexionAsync();

                    if (prueba)
                    {
                        lblestadonuevo.Text = "¡¡¡ Conexión exitosa !!!";
                        lblestadonuevo.ForeColor = Color.LightSeaGreen;
                    }
                    else
                    {
                        lblestadonuevo.Text = "Error en la conexión";
                        lblestadonuevo.ForeColor = Color.Red;
                    }
                } // 'using' se encarga de llamar a Dispose() automáticamente al salir.
            }
            catch (Exception ex)
            {
                lblestadonuevo.Text = "Error " + ex.Message;
                lblestadonuevo.ForeColor = Color.Red;
            }
        }


    }
}

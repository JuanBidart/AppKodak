namespace appkodak
{
    partial class FormPrincipal2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnBasedeDatos = new Button();
            btnProbarConexion = new Button();
            btnClientes = new Button();
            button1 = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panelVentana = new Panel();
            pbxNotificacion = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelVentana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxNotificacion).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 40);
            panel1.Controls.Add(btnBasedeDatos);
            panel1.Controls.Add(btnProbarConexion);
            panel1.Controls.Add(btnClientes);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(359, 666);
            panel1.TabIndex = 0;
            // 
            // btnBasedeDatos
            // 
            btnBasedeDatos.Dock = DockStyle.Top;
            btnBasedeDatos.FlatAppearance.BorderSize = 0;
            btnBasedeDatos.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnBasedeDatos.FlatStyle = FlatStyle.Flat;
            btnBasedeDatos.Font = new Font("Dubai", 14.2499981F);
            btnBasedeDatos.ForeColor = Color.LightSeaGreen;
            btnBasedeDatos.Image = Properties.Resources.icons8_menú_50;
            btnBasedeDatos.ImageAlign = ContentAlignment.MiddleRight;
            btnBasedeDatos.Location = new Point(0, 291);
            btnBasedeDatos.Name = "btnBasedeDatos";
            btnBasedeDatos.Size = new Size(359, 67);
            btnBasedeDatos.TabIndex = 4;
            btnBasedeDatos.Text = "Base de Datos";
            btnBasedeDatos.UseVisualStyleBackColor = true;
            btnBasedeDatos.Click += btnBasedeDatos_Click;
            // 
            // btnProbarConexion
            // 
            btnProbarConexion.Dock = DockStyle.Top;
            btnProbarConexion.FlatAppearance.BorderSize = 0;
            btnProbarConexion.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnProbarConexion.FlatStyle = FlatStyle.Flat;
            btnProbarConexion.Font = new Font("Dubai", 14.2499981F);
            btnProbarConexion.ForeColor = Color.LightSeaGreen;
            btnProbarConexion.Location = new Point(0, 224);
            btnProbarConexion.Name = "btnProbarConexion";
            btnProbarConexion.Size = new Size(359, 67);
            btnProbarConexion.TabIndex = 3;
            btnProbarConexion.Text = "Probar Conexion Data Bases";
            btnProbarConexion.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnProbarConexion.UseVisualStyleBackColor = true;
            btnProbarConexion.Click += btnProbarConexion_Click;
            // 
            // btnClientes
            // 
            btnClientes.Dock = DockStyle.Top;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Dubai", 14.2499981F);
            btnClientes.ForeColor = Color.LightSeaGreen;
            btnClientes.Location = new Point(0, 157);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(359, 67);
            btnClientes.TabIndex = 2;
            btnClientes.Text = "Clientes";
            btnClientes.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Dubai", 14.2499981F);
            button1.ForeColor = Color.LightSeaGreen;
            button1.Location = new Point(0, 90);
            button1.Name = "button1";
            button1.Size = new Size(359, 67);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(359, 90);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Capa_2;
            pictureBox1.Location = new Point(121, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelVentana
            // 
            panelVentana.Controls.Add(pbxNotificacion);
            panelVentana.Dock = DockStyle.Fill;
            panelVentana.Location = new Point(359, 0);
            panelVentana.Name = "panelVentana";
            panelVentana.Size = new Size(772, 666);
            panelVentana.TabIndex = 1;
            // 
            // pbxNotificacion
            // 
            pbxNotificacion.BackColor = SystemColors.Control;
            pbxNotificacion.Location = new Point(233, 173);
            pbxNotificacion.Name = "pbxNotificacion";
            pbxNotificacion.Size = new Size(326, 225);
            pbxNotificacion.SizeMode = PictureBoxSizeMode.Zoom;
            pbxNotificacion.TabIndex = 0;
            pbxNotificacion.TabStop = false;
            // 
            // FormPrincipal2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 666);
            Controls.Add(panelVentana);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormPrincipal2";
            Text = "FormPrincipal2";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelVentana.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxNotificacion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Panel panelVentana;
        private PictureBox pictureBox1;
        private Button btnClientes;
        private PictureBox pbxNotificacion;
        private Button btnProbarConexion;
        private Button btnBasedeDatos;
    }
}
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btnBasedeDatos = new Button();
            btnProbarConexion = new Button();
            btnClientes = new Button();
            button1 = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panelVentana = new Panel();
            lblHora = new Label();
            pbxNotificacion = new PictureBox();
            timer100ms = new System.Windows.Forms.Timer(components);
            timer1min = new System.Windows.Forms.Timer(components);
            lblDia = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelVentana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxNotificacion).BeginInit();
            tableLayoutPanel1.SuspendLayout();
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
            panelVentana.BackColor = Color.FromArgb(60, 60, 60);
            panelVentana.Controls.Add(tableLayoutPanel1);
            panelVentana.Controls.Add(pbxNotificacion);
            panelVentana.Dock = DockStyle.Fill;
            panelVentana.Location = new Point(359, 0);
            panelVentana.Name = "panelVentana";
            panelVentana.Size = new Size(772, 666);
            panelVentana.TabIndex = 1;
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.None;
            lblHora.AutoSize = true;
            lblHora.FlatStyle = FlatStyle.Flat;
            lblHora.Font = new Font("Dubai", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHora.ForeColor = Color.Transparent;
            lblHora.Location = new Point(138, 210);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(84, 49);
            lblHora.TabIndex = 3;
            lblHora.Text = "Hora";
            lblHora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbxNotificacion
            // 
            pbxNotificacion.BackColor = Color.Transparent;
            pbxNotificacion.Location = new Point(681, 587);
            pbxNotificacion.Name = "pbxNotificacion";
            pbxNotificacion.Size = new Size(79, 67);
            pbxNotificacion.SizeMode = PictureBoxSizeMode.Zoom;
            pbxNotificacion.TabIndex = 0;
            pbxNotificacion.TabStop = false;
            // 
            // lblDia
            // 
            lblDia.Anchor = AnchorStyles.None;
            lblDia.AutoSize = true;
            lblDia.FlatStyle = FlatStyle.Flat;
            lblDia.Font = new Font("Dubai", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDia.ForeColor = Color.Transparent;
            lblDia.Location = new Point(133, 116);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(94, 49);
            lblDia.TabIndex = 2;
            lblDia.Text = "Fecha";
            lblDia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Dubai", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(38, 6);
            label1.Name = "label1";
            label1.Size = new Size(284, 81);
            label1.TabIndex = 1;
            label1.Text = "Bienvenidos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblHora, 0, 2);
            tableLayoutPanel1.Controls.Add(lblDia, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Location = new Point(217, 90);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(360, 376);
            tableLayoutPanel1.TabIndex = 4;
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
            Load += FormPrincipal2_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelVentana.ResumeLayout(false);
            panelVentana.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxNotificacion).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private Label lblHora;
        private System.Windows.Forms.Timer timer100ms;
        private System.Windows.Forms.Timer timer1min;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblDia;
        private Label label1;
    }
}
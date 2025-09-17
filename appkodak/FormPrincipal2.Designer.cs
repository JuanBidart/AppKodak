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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal2));
            panel1 = new Panel();
            btnSalir = new Button();
            btnProbarConexion = new Button();
            bbtnProveedores = new Button();
            btnBasedeDatos = new Button();
            btnClientes = new Button();
            button1 = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panelVentana = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblHora = new Label();
            lblDia = new Label();
            label1 = new Label();
            timer100ms = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelVentana.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 40);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnProbarConexion);
            panel1.Controls.Add(bbtnProveedores);
            panel1.Controls.Add(btnBasedeDatos);
            panel1.Controls.Add(btnClientes);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(359, 711);
            panel1.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(180, 80, 30);
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, 80, 30);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Dubai", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.FromArgb(32, 179, 179);
            btnSalir.Location = new Point(70, 655);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(205, 44);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir del Sistema";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnProbarConexion
            // 
            btnProbarConexion.Dock = DockStyle.Top;
            btnProbarConexion.FlatAppearance.BorderSize = 0;
            btnProbarConexion.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnProbarConexion.FlatStyle = FlatStyle.Flat;
            btnProbarConexion.Font = new Font("Dubai", 14.2499981F);
            btnProbarConexion.ForeColor = Color.LightSeaGreen;
            btnProbarConexion.Location = new Point(0, 463);
            btnProbarConexion.Name = "btnProbarConexion";
            btnProbarConexion.Size = new Size(359, 67);
            btnProbarConexion.TabIndex = 6;
            btnProbarConexion.Text = "Probar Conexion Data Bases";
            btnProbarConexion.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnProbarConexion.UseVisualStyleBackColor = true;
            btnProbarConexion.Click += btnProbarConexion_Click;
            // 
            // bbtnProveedores
            // 
            bbtnProveedores.BackgroundImageLayout = ImageLayout.None;
            bbtnProveedores.Dock = DockStyle.Top;
            bbtnProveedores.FlatAppearance.BorderSize = 0;
            bbtnProveedores.FlatAppearance.MouseOverBackColor = Color.DimGray;
            bbtnProveedores.FlatStyle = FlatStyle.Flat;
            bbtnProveedores.Font = new Font("Dubai", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bbtnProveedores.ForeColor = Color.LightSeaGreen;
            bbtnProveedores.Image = (Image)resources.GetObject("bbtnProveedores.Image");
            bbtnProveedores.Location = new Point(0, 387);
            bbtnProveedores.Name = "bbtnProveedores";
            bbtnProveedores.Size = new Size(359, 76);
            bbtnProveedores.TabIndex = 5;
            bbtnProveedores.Text = "Proveedores";
            bbtnProveedores.TextImageRelation = TextImageRelation.ImageBeforeText;
            bbtnProveedores.UseVisualStyleBackColor = true;
            bbtnProveedores.Click += bbtnProveedores_Click;
            // 
            // btnBasedeDatos
            // 
            btnBasedeDatos.BackgroundImageLayout = ImageLayout.None;
            btnBasedeDatos.Dock = DockStyle.Top;
            btnBasedeDatos.FlatAppearance.BorderSize = 0;
            btnBasedeDatos.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnBasedeDatos.FlatStyle = FlatStyle.Flat;
            btnBasedeDatos.Font = new Font("Dubai", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBasedeDatos.ForeColor = Color.LightSeaGreen;
            btnBasedeDatos.Image = (Image)resources.GetObject("btnBasedeDatos.Image");
            btnBasedeDatos.Location = new Point(0, 283);
            btnBasedeDatos.Name = "btnBasedeDatos";
            btnBasedeDatos.Size = new Size(359, 104);
            btnBasedeDatos.TabIndex = 4;
            btnBasedeDatos.Text = "Base de Datos";
            btnBasedeDatos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBasedeDatos.UseVisualStyleBackColor = true;
            btnBasedeDatos.Click += btnBasedeDatos_Click;
            // 
            // btnClientes
            // 
            btnClientes.Dock = DockStyle.Top;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Dubai", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = Color.LightSeaGreen;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.Location = new Point(0, 173);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(359, 110);
            btnClientes.TabIndex = 2;
            btnClientes.Text = "Productos";
            btnClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
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
            button1.Location = new Point(0, 106);
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
            panel2.Size = new Size(359, 106);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Capa_2;
            pictureBox1.Location = new Point(125, 12);
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
            panelVentana.Dock = DockStyle.Fill;
            panelVentana.Location = new Point(359, 0);
            panelVentana.Name = "panelVentana";
            panelVentana.Size = new Size(772, 711);
            panelVentana.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblHora, 0, 5);
            tableLayoutPanel1.Controls.Add(lblDia, 0, 4);
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 77F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutPanel1.Size = new Size(772, 711);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.None;
            lblHora.AutoSize = true;
            lblHora.FlatStyle = FlatStyle.Flat;
            lblHora.Font = new Font("Dubai", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHora.ForeColor = Color.Transparent;
            lblHora.Location = new Point(352, 660);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(68, 40);
            lblHora.TabIndex = 3;
            lblHora.Text = "Hora";
            lblHora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDia
            // 
            lblDia.Anchor = AnchorStyles.None;
            lblDia.AutoSize = true;
            lblDia.FlatStyle = FlatStyle.Flat;
            lblDia.Font = new Font("Dubai", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDia.ForeColor = Color.Transparent;
            lblDia.Location = new Point(347, 590);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(78, 40);
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
            label1.Location = new Point(244, 317);
            label1.Name = "label1";
            label1.Size = new Size(284, 81);
            label1.TabIndex = 1;
            label1.Text = "Bienvenidos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer100ms
            // 
            timer100ms.Interval = 1000;
            // 
            // FormPrincipal2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 711);
            Controls.Add(panelVentana);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPrincipal2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrincipal2";
            Load += FormPrincipal2_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelVentana.ResumeLayout(false);
            panelVentana.PerformLayout();
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
        private Button btnBasedeDatos;
        private Label lblHora;
        private System.Windows.Forms.Timer timer100ms;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblDia;
        private Label label1;
        private Button bbtnProveedores;
        private Button btnProbarConexion;
        private Button btnSalir;
    }
}
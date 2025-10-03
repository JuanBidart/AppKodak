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
            btnProbarConexion = new Button();
            button2 = new Button();
            btnSalir = new Button();
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
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            lblUltimaActualizacionOficial = new Label();
            label5 = new Label();
            lblVentaOficial = new Label();
            lblCompraOficial = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            lblUltimaActualizacionBlue = new Label();
            lblCompreBlue = new Label();
            lblVentaBlue = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            timer100ms = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelVentana.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 40);
            panel1.Controls.Add(btnProbarConexion);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnSalir);
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
            // btnProbarConexion
            // 
            btnProbarConexion.Dock = DockStyle.Top;
            btnProbarConexion.FlatAppearance.BorderSize = 0;
            btnProbarConexion.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnProbarConexion.FlatStyle = FlatStyle.Flat;
            btnProbarConexion.Font = new Font("Dubai", 14.2499981F);
            btnProbarConexion.ForeColor = Color.LightSeaGreen;
            btnProbarConexion.Location = new Point(0, 573);
            btnProbarConexion.Name = "btnProbarConexion";
            btnProbarConexion.Size = new Size(359, 67);
            btnProbarConexion.TabIndex = 9;
            btnProbarConexion.Text = "Probar Conexion Data Bases";
            btnProbarConexion.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnProbarConexion.UseVisualStyleBackColor = true;
            btnProbarConexion.Click += btnProbarConexion_Click_1;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Dubai", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.LightSeaGreen;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(0, 463);
            button2.Name = "button2";
            button2.Size = new Size(359, 110);
            button2.TabIndex = 8;
            button2.Text = "Configuraciones";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
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
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.3589745F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.905983F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 37.77778F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
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
            lblHora.Location = new Point(352, 659);
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
            lblDia.Location = new Point(347, 596);
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
            label1.Location = new Point(244, 256);
            label1.Name = "label1";
            label1.Size = new Size(284, 81);
            label1.TabIndex = 1;
            label1.Text = "Bienvenidos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel3, 0, 0);
            tableLayoutPanel2.Controls.Add(panel4, 1, 0);
            tableLayoutPanel2.Location = new Point(3, 367);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(766, 152);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(40, 40, 40);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblUltimaActualizacionOficial);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(lblVentaOficial);
            panel3.Controls.Add(lblCompraOficial);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(377, 146);
            panel3.TabIndex = 4;
            // 
            // lblUltimaActualizacionOficial
            // 
            lblUltimaActualizacionOficial.Anchor = AnchorStyles.None;
            lblUltimaActualizacionOficial.AutoSize = true;
            lblUltimaActualizacionOficial.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUltimaActualizacionOficial.ForeColor = Color.FromArgb(180, 80, 30);
            lblUltimaActualizacionOficial.Location = new Point(177, 107);
            lblUltimaActualizacionOficial.Name = "lblUltimaActualizacionOficial";
            lblUltimaActualizacionOficial.Size = new Size(18, 27);
            lblUltimaActualizacionOficial.TabIndex = 6;
            lblUltimaActualizacionOficial.Text = "..";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(180, 80, 30);
            label5.Location = new Point(24, 107);
            label5.Name = "label5";
            label5.Size = new Size(147, 27);
            label5.TabIndex = 5;
            label5.Text = "Ultima actualizacion:";
            // 
            // lblVentaOficial
            // 
            lblVentaOficial.Anchor = AnchorStyles.None;
            lblVentaOficial.AutoSize = true;
            lblVentaOficial.Font = new Font("Dubai Medium", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVentaOficial.ForeColor = Color.LightSeaGreen;
            lblVentaOficial.Location = new Point(253, 68);
            lblVentaOficial.Name = "lblVentaOficial";
            lblVentaOficial.Size = new Size(25, 32);
            lblVentaOficial.TabIndex = 4;
            lblVentaOficial.Text = "$";
            // 
            // lblCompraOficial
            // 
            lblCompraOficial.Anchor = AnchorStyles.None;
            lblCompraOficial.AutoSize = true;
            lblCompraOficial.Font = new Font("Dubai Medium", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCompraOficial.ForeColor = Color.LightSeaGreen;
            lblCompraOficial.Location = new Point(34, 66);
            lblCompraOficial.Name = "lblCompraOficial";
            lblCompraOficial.Size = new Size(25, 32);
            lblCompraOficial.TabIndex = 3;
            lblCompraOficial.Text = "$";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Dubai Medium", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(250, 38);
            label4.Name = "label4";
            label4.Size = new Size(71, 32);
            label4.TabIndex = 2;
            label4.Text = "Venta:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Dubai Medium", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(34, 38);
            label3.Name = "label3";
            label3.Size = new Size(87, 32);
            label3.TabIndex = 1;
            label3.Text = "Compra:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Dubai", 15.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(129, 3);
            label2.Name = "label2";
            label2.Size = new Size(129, 36);
            label2.TabIndex = 0;
            label2.Text = "Dolar Oficial ";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(40, 40, 40);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblUltimaActualizacionBlue);
            panel4.Controls.Add(lblCompreBlue);
            panel4.Controls.Add(lblVentaBlue);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label11);
            panel4.Location = new Point(386, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(377, 146);
            panel4.TabIndex = 5;
            // 
            // lblUltimaActualizacionBlue
            // 
            lblUltimaActualizacionBlue.Anchor = AnchorStyles.None;
            lblUltimaActualizacionBlue.AutoSize = true;
            lblUltimaActualizacionBlue.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUltimaActualizacionBlue.ForeColor = Color.FromArgb(180, 80, 30);
            lblUltimaActualizacionBlue.Location = new Point(179, 107);
            lblUltimaActualizacionBlue.Name = "lblUltimaActualizacionBlue";
            lblUltimaActualizacionBlue.Size = new Size(18, 27);
            lblUltimaActualizacionBlue.TabIndex = 12;
            lblUltimaActualizacionBlue.Text = "..";
            // 
            // lblCompreBlue
            // 
            lblCompreBlue.Anchor = AnchorStyles.None;
            lblCompreBlue.AutoSize = true;
            lblCompreBlue.Font = new Font("Dubai Medium", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCompreBlue.ForeColor = Color.LightSeaGreen;
            lblCompreBlue.Location = new Point(17, 68);
            lblCompreBlue.Name = "lblCompreBlue";
            lblCompreBlue.Size = new Size(25, 32);
            lblCompreBlue.TabIndex = 13;
            lblCompreBlue.Text = "$";
            // 
            // lblVentaBlue
            // 
            lblVentaBlue.Anchor = AnchorStyles.None;
            lblVentaBlue.AutoSize = true;
            lblVentaBlue.Font = new Font("Dubai Medium", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVentaBlue.ForeColor = Color.LightSeaGreen;
            lblVentaBlue.Location = new Point(283, 68);
            lblVentaBlue.Name = "lblVentaBlue";
            lblVentaBlue.Size = new Size(25, 32);
            lblVentaBlue.TabIndex = 10;
            lblVentaBlue.Text = "$";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(180, 80, 30);
            label7.Location = new Point(26, 107);
            label7.Name = "label7";
            label7.Size = new Size(147, 27);
            label7.TabIndex = 11;
            label7.Text = "Ultima actualizacion:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Dubai Medium", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Transparent;
            label9.Location = new Point(283, 38);
            label9.Name = "label9";
            label9.Size = new Size(71, 32);
            label9.TabIndex = 9;
            label9.Text = "Venta:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Dubai Medium", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Transparent;
            label10.Location = new Point(17, 38);
            label10.Name = "label10";
            label10.Size = new Size(87, 32);
            label10.TabIndex = 8;
            label10.Text = "Compra:";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Dubai", 15.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Transparent;
            label11.Location = new Point(136, 3);
            label11.Name = "label11";
            label11.Size = new Size(107, 36);
            label11.TabIndex = 7;
            label11.Text = "Dolar Blue";
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
            tableLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private Button btnSalir;
        private Button btnProbarConexion;
        private Button button2;
        private Panel panel3;
        private Label lblVentaOficial;
        private Label lblCompraOficial;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblUltimaActualizacionOficial;
        private Label label5;
        private Label lblCompreBlue;
        private Label lblUltimaActualizacionBlue;
        private Label label7;
        private Label lblVentaBlue;
        private Label label9;
        private Label label10;
        private Label label11;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel4;
    }
}
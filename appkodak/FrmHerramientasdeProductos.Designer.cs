namespace appkodak
{
    partial class FrmHerramientasdeProductos
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
            label1 = new Label();
            lblTitulo = new Label();
            btnCerrar = new Button();
            btnCargarProducto = new Button();
            btnDatosCompletos = new Button();
            btnVerLista = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(btnCerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 32);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(40, 40, 40);
            label1.Location = new Point(293, 9);
            label1.Name = "label1";
            label1.Size = new Size(151, 15);
            label1.TabIndex = 2;
            label1.Text = "Herramientas de Productos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(562, -25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(170, 15);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Herramientas de Base de Datos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCerrar
            // 
            btnCerrar.Dock = DockStyle.Right;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.Transparent;
            btnCerrar.Location = new Point(719, 0);
            btnCerrar.Margin = new Padding(10, 3, 3, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(37, 32);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnCargarProducto
            // 
            btnCargarProducto.FlatAppearance.BorderColor = Color.FromArgb(179, 82, 32);
            btnCargarProducto.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnCargarProducto.FlatStyle = FlatStyle.Flat;
            btnCargarProducto.Font = new Font("Dubai", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargarProducto.ForeColor = Color.Transparent;
            btnCargarProducto.Location = new Point(384, 77);
            btnCargarProducto.Name = "btnCargarProducto";
            btnCargarProducto.Size = new Size(359, 216);
            btnCargarProducto.TabIndex = 5;
            btnCargarProducto.Text = "Cargar Producto";
            btnCargarProducto.UseVisualStyleBackColor = true;
            btnCargarProducto.Click += btnCargarProducto_Click;
            // 
            // btnDatosCompletos
            // 
            btnDatosCompletos.FlatAppearance.BorderColor = Color.FromArgb(179, 82, 32);
            btnDatosCompletos.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnDatosCompletos.FlatStyle = FlatStyle.Flat;
            btnDatosCompletos.Font = new Font("Dubai", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDatosCompletos.ForeColor = Color.Transparent;
            btnDatosCompletos.Location = new Point(14, 77);
            btnDatosCompletos.Name = "btnDatosCompletos";
            btnDatosCompletos.Size = new Size(359, 216);
            btnDatosCompletos.TabIndex = 4;
            btnDatosCompletos.Text = "Datos Completos Producto";
            btnDatosCompletos.UseVisualStyleBackColor = true;
            btnDatosCompletos.Click += btnDatosCompletos_Click;
            // 
            // btnVerLista
            // 
            btnVerLista.FlatAppearance.BorderColor = Color.FromArgb(179, 82, 32);
            btnVerLista.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnVerLista.FlatStyle = FlatStyle.Flat;
            btnVerLista.Font = new Font("Dubai", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerLista.ForeColor = Color.Transparent;
            btnVerLista.Location = new Point(14, 299);
            btnVerLista.Name = "btnVerLista";
            btnVerLista.Size = new Size(359, 216);
            btnVerLista.TabIndex = 6;
            btnVerLista.Text = "Ver Lista Productos";
            btnVerLista.UseVisualStyleBackColor = true;
            // 
            // FrmHerramientasdeProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(756, 627);
            Controls.Add(btnVerLista);
            Controls.Add(btnCargarProducto);
            Controls.Add(btnDatosCompletos);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHerramientasdeProductos";
            Text = "FrmHerramientasdeProductos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitulo;
        private Button btnCerrar;
        private Button btnCargarProducto;
        private Button btnDatosCompletos;
        private Button btnVerLista;
        private Label label1;
    }
}
namespace appkodak
{
    partial class FrmCargaProveedores
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
            lblNuevoProveedor = new Label();
            groupBox1 = new GroupBox();
            txtIva = new TextBox();
            label1 = new Label();
            txtWeb = new TextBox();
            label8 = new Label();
            txtTelefonoSec = new TextBox();
            label7 = new Label();
            txtTelefonoP = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            txtDireccion = new TextBox();
            txtCiudad = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            btnGuardar = new Button();
            btnSalir = new Button();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblNuevoProveedor
            // 
            lblNuevoProveedor.Anchor = AnchorStyles.None;
            lblNuevoProveedor.AutoSize = true;
            lblNuevoProveedor.Font = new Font("Dubai Medium", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNuevoProveedor.ForeColor = Color.LightSeaGreen;
            lblNuevoProveedor.Location = new Point(182, 9);
            lblNuevoProveedor.Name = "lblNuevoProveedor";
            lblNuevoProveedor.Size = new Size(287, 57);
            lblNuevoProveedor.TabIndex = 12;
            lblNuevoProveedor.Text = "Nuevo Proveedor";
            lblNuevoProveedor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtIva);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtWeb);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtTelefonoSec);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtTelefonoP);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(txtCiudad);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(41, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(570, 501);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Proveedor";
            // 
            // txtIva
            // 
            txtIva.BorderStyle = BorderStyle.None;
            txtIva.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIva.ForeColor = Color.LightSeaGreen;
            txtIva.Location = new Point(210, 429);
            txtIva.Name = "txtIva";
            txtIva.PlaceholderText = "Alicuota del Iva";
            txtIva.Size = new Size(302, 33);
            txtIva.TabIndex = 15;
            txtIva.KeyPress += txtIva_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Dubai", 15.75F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(164, 429);
            label1.Name = "label1";
            label1.Size = new Size(43, 36);
            label1.TabIndex = 14;
            label1.Text = "Iva:";
            // 
            // txtWeb
            // 
            txtWeb.BorderStyle = BorderStyle.None;
            txtWeb.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtWeb.ForeColor = Color.LightSeaGreen;
            txtWeb.Location = new Point(210, 380);
            txtWeb.Name = "txtWeb";
            txtWeb.PlaceholderText = "Pagina Web del proveedor";
            txtWeb.Size = new Size(302, 33);
            txtWeb.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Dubai", 15.75F);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(85, 380);
            label8.Name = "label8";
            label8.Size = new Size(122, 36);
            label8.TabIndex = 12;
            label8.Text = "Pagina Web:";
            // 
            // txtTelefonoSec
            // 
            txtTelefonoSec.BorderStyle = BorderStyle.None;
            txtTelefonoSec.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefonoSec.ForeColor = Color.LightSeaGreen;
            txtTelefonoSec.Location = new Point(210, 327);
            txtTelefonoSec.Name = "txtTelefonoSec";
            txtTelefonoSec.PlaceholderText = "Telefono2";
            txtTelefonoSec.Size = new Size(302, 33);
            txtTelefonoSec.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Dubai", 15.75F);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(8, 324);
            label7.Name = "label7";
            label7.Size = new Size(199, 36);
            label7.TabIndex = 10;
            label7.Text = "Teléfono Secundario:";
            // 
            // txtTelefonoP
            // 
            txtTelefonoP.BorderStyle = BorderStyle.None;
            txtTelefonoP.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefonoP.ForeColor = Color.LightSeaGreen;
            txtTelefonoP.Location = new Point(210, 274);
            txtTelefonoP.Name = "txtTelefonoP";
            txtTelefonoP.PlaceholderText = "Numero de teléfono";
            txtTelefonoP.Size = new Size(302, 33);
            txtTelefonoP.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Dubai", 15.75F);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(30, 274);
            label6.Name = "label6";
            label6.Size = new Size(177, 36);
            label6.TabIndex = 8;
            label6.Text = "Teléfono Principal:";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.LightSeaGreen;
            txtEmail.Location = new Point(210, 221);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "E-mail del proveedor";
            txtEmail.Size = new Size(302, 33);
            txtEmail.TabIndex = 7;
            // 
            // txtDireccion
            // 
            txtDireccion.BorderStyle = BorderStyle.None;
            txtDireccion.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDireccion.ForeColor = Color.LightSeaGreen;
            txtDireccion.Location = new Point(210, 168);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Dirección";
            txtDireccion.Size = new Size(302, 33);
            txtDireccion.TabIndex = 6;
            // 
            // txtCiudad
            // 
            txtCiudad.BorderStyle = BorderStyle.None;
            txtCiudad.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCiudad.ForeColor = Color.LightSeaGreen;
            txtCiudad.Location = new Point(210, 115);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.PlaceholderText = "Ciudad del Proveedor";
            txtCiudad.Size = new Size(302, 33);
            txtCiudad.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.ForeColor = Color.LightSeaGreen;
            txtNombre.Location = new Point(210, 62);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Razón Social";
            txtNombre.Size = new Size(302, 33);
            txtNombre.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Dubai", 15.75F);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(141, 220);
            label4.Name = "label4";
            label4.Size = new Size(66, 36);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Dubai", 15.75F);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(106, 167);
            label3.Name = "label3";
            label3.Size = new Size(101, 36);
            label3.TabIndex = 2;
            label3.Text = "Dirección:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Dubai", 15.75F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(128, 114);
            label2.Name = "label2";
            label2.Size = new Size(79, 36);
            label2.TabIndex = 1;
            label2.Text = "Ciudad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Dubai", 15.75F);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(117, 61);
            label5.Name = "label5";
            label5.Size = new Size(90, 36);
            label5.TabIndex = 0;
            label5.Text = "Nombre:";
            // 
            // btnGuardar
            // 
            btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(180, 80, 30);
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Dubai", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(41, 588);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(266, 81);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(180, 80, 30);
            btnSalir.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Dubai", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(345, 588);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(266, 81);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmCargaProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(647, 697);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardar);
            Controls.Add(groupBox1);
            Controls.Add(lblNuevoProveedor);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmCargaProveedores";
            Text = "FrmCargaProveedores";
            Load += FrmCargaProveedores_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNuevoProveedor;
        private GroupBox groupBox1;
        private TextBox txtWeb;
        private Label label8;
        private TextBox txtTelefonoSec;
        private Label label7;
        private TextBox txtTelefonoP;
        private Label label6;
        private TextBox txtEmail;
        private TextBox txtDireccion;
        private TextBox txtCiudad;
        private TextBox txtNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private TextBox txtIva;
        private Label label1;
        private Button btnGuardar;
        private Button btnSalir;
        private ErrorProvider errorProvider1;
    }
}
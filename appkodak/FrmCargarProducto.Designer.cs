namespace appkodak
{
    partial class FrmCargarProducto
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
            btnGUardar = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label14 = new Label();
            txtPrecioFInal = new TextBox();
            txtCodProductoProveedor = new TextBox();
            label13 = new Label();
            chxSi = new CheckBox();
            label12 = new Label();
            label11 = new Label();
            txtCosto = new TextBox();
            label10 = new Label();
            cbxProveedor = new ComboBox();
            txtObservacion = new TextBox();
            label9 = new Label();
            txtMarca = new TextBox();
            label8 = new Label();
            txtIva = new TextBox();
            label7 = new Label();
            txtStock = new TextBox();
            label6 = new Label();
            txtFecha = new TextBox();
            txtRecargo = new TextBox();
            txtDescripcion = new TextBox();
            txtCodigo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            btnSalir = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGUardar
            // 
            btnGUardar.FlatAppearance.BorderColor = Color.DimGray;
            btnGUardar.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnGUardar.FlatStyle = FlatStyle.Flat;
            btnGUardar.Font = new Font("Dubai", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGUardar.ForeColor = Color.White;
            btnGUardar.Location = new Point(192, 511);
            btnGUardar.Name = "btnGUardar";
            btnGUardar.Size = new Size(266, 81);
            btnGUardar.TabIndex = 0;
            btnGUardar.Text = "Guardar";
            btnGUardar.UseVisualStyleBackColor = true;
            btnGUardar.Click += btnGUardar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Dubai Medium", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(395, 9);
            label1.Name = "label1";
            label1.Size = new Size(270, 57);
            label1.TabIndex = 11;
            label1.Text = "Nuevo Producto";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(txtPrecioFInal);
            groupBox1.Controls.Add(txtCodProductoProveedor);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(chxSi);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtCosto);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cbxProveedor);
            groupBox1.Controls.Add(txtObservacion);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtMarca);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtIva);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtFecha);
            groupBox1.Controls.Add(txtRecargo);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(180, 80, 30);
            groupBox1.Location = new Point(12, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1051, 443);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Producto Nuevo";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Dubai", 15.75F);
            label14.ForeColor = SystemColors.Control;
            label14.Location = new Point(340, 385);
            label14.Name = "label14";
            label14.Size = new Size(117, 36);
            label14.TabIndex = 24;
            label14.Text = "Precio Final";
            // 
            // txtPrecioFInal
            // 
            txtPrecioFInal.ForeColor = Color.FromArgb(180, 80, 30);
            txtPrecioFInal.Location = new Point(462, 383);
            txtPrecioFInal.Name = "txtPrecioFInal";
            txtPrecioFInal.PlaceholderText = "$0";
            txtPrecioFInal.Size = new Size(190, 40);
            txtPrecioFInal.TabIndex = 23;
            // 
            // txtCodProductoProveedor
            // 
            txtCodProductoProveedor.BorderStyle = BorderStyle.None;
            txtCodProductoProveedor.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodProductoProveedor.ForeColor = Color.LightSeaGreen;
            txtCodProductoProveedor.Location = new Point(715, 207);
            txtCodProductoProveedor.Name = "txtCodProductoProveedor";
            txtCodProductoProveedor.PlaceholderText = "Codigo del Producto del Proveedor";
            txtCodProductoProveedor.Size = new Size(304, 33);
            txtCodProductoProveedor.TabIndex = 6;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Dubai", 15.75F);
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(479, 204);
            label13.Name = "label13";
            label13.Size = new Size(233, 36);
            label13.TabIndex = 22;
            label13.Text = "Cod.Producto Proveedor:";
            // 
            // chxSi
            // 
            chxSi.AutoSize = true;
            chxSi.Location = new Point(715, 154);
            chxSi.Name = "chxSi";
            chxSi.Size = new Size(48, 36);
            chxSi.TabIndex = 5;
            chxSi.Text = "SI";
            chxSi.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Dubai", 15.75F);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(588, 152);
            label12.Name = "label12";
            label12.Size = new Size(120, 36);
            label12.TabIndex = 20;
            label12.Text = "Es Principal:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Dubai", 15.75F);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(599, 44);
            label11.Name = "label11";
            label11.Size = new Size(109, 36);
            label11.TabIndex = 19;
            label11.Text = "Proveedor:";
            // 
            // txtCosto
            // 
            txtCosto.BorderStyle = BorderStyle.None;
            txtCosto.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCosto.ForeColor = Color.LightSeaGreen;
            txtCosto.Location = new Point(715, 102);
            txtCosto.Name = "txtCosto";
            txtCosto.PlaceholderText = "Costo del producto";
            txtCosto.Size = new Size(304, 33);
            txtCosto.TabIndex = 3;
            txtCosto.Leave += txtCosto_Leave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Dubai", 15.75F);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(638, 101);
            label10.Name = "label10";
            label10.Size = new Size(70, 36);
            label10.TabIndex = 17;
            label10.Text = "Costo:";
            // 
            // cbxProveedor
            // 
            cbxProveedor.FormattingEnabled = true;
            cbxProveedor.Location = new Point(715, 44);
            cbxProveedor.Name = "cbxProveedor";
            cbxProveedor.Size = new Size(304, 40);
            cbxProveedor.TabIndex = 1;
            // 
            // txtObservacion
            // 
            txtObservacion.BorderStyle = BorderStyle.None;
            txtObservacion.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtObservacion.ForeColor = Color.LightSeaGreen;
            txtObservacion.Location = new Point(715, 315);
            txtObservacion.Name = "txtObservacion";
            txtObservacion.PlaceholderText = "Datos que complementan";
            txtObservacion.Size = new Size(304, 33);
            txtObservacion.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Dubai", 15.75F);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(581, 314);
            label9.Name = "label9";
            label9.Size = new Size(127, 36);
            label9.TabIndex = 14;
            label9.Text = "Observación:";
            // 
            // txtMarca
            // 
            txtMarca.BorderStyle = BorderStyle.None;
            txtMarca.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMarca.ForeColor = Color.LightSeaGreen;
            txtMarca.Location = new Point(715, 262);
            txtMarca.Name = "txtMarca";
            txtMarca.PlaceholderText = "Marca del producto";
            txtMarca.Size = new Size(304, 33);
            txtMarca.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Dubai", 15.75F);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(635, 261);
            label8.Name = "label8";
            label8.Size = new Size(73, 36);
            label8.TabIndex = 12;
            label8.Text = "Marca:";
            // 
            // txtIva
            // 
            txtIva.BorderStyle = BorderStyle.None;
            txtIva.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIva.ForeColor = Color.LightSeaGreen;
            txtIva.Location = new Point(142, 314);
            txtIva.Name = "txtIva";
            txtIva.PlaceholderText = "Iva";
            txtIva.Size = new Size(304, 33);
            txtIva.TabIndex = 9;
            txtIva.TextChanged += txtIva_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Dubai", 15.75F);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(97, 313);
            label7.Name = "label7";
            label7.Size = new Size(43, 36);
            label7.TabIndex = 10;
            label7.Text = "Iva:";
            // 
            // txtStock
            // 
            txtStock.BorderStyle = BorderStyle.None;
            txtStock.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStock.ForeColor = Color.LightSeaGreen;
            txtStock.Location = new Point(142, 261);
            txtStock.Name = "txtStock";
            txtStock.PlaceholderText = "Stock";
            txtStock.Size = new Size(304, 33);
            txtStock.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Dubai", 15.75F);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(71, 260);
            label6.Name = "label6";
            label6.Size = new Size(69, 36);
            label6.TabIndex = 8;
            label6.Text = "Stock:";
            // 
            // txtFecha
            // 
            txtFecha.BorderStyle = BorderStyle.None;
            txtFecha.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFecha.ForeColor = Color.LightSeaGreen;
            txtFecha.Location = new Point(142, 208);
            txtFecha.Name = "txtFecha";
            txtFecha.PlaceholderText = "Fecha de modificacion";
            txtFecha.Size = new Size(304, 33);
            txtFecha.TabIndex = 3;
            // 
            // txtRecargo
            // 
            txtRecargo.BorderStyle = BorderStyle.None;
            txtRecargo.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRecargo.ForeColor = Color.LightSeaGreen;
            txtRecargo.Location = new Point(142, 155);
            txtRecargo.Name = "txtRecargo";
            txtRecargo.PlaceholderText = "El Porcentaje de recargo";
            txtRecargo.Size = new Size(304, 33);
            txtRecargo.TabIndex = 4;
            txtRecargo.TextChanged += txtRecargo_TextChanged;
            txtRecargo.Leave += txtRecargo_Leave;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BorderStyle = BorderStyle.None;
            txtDescripcion.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.ForeColor = Color.LightSeaGreen;
            txtDescripcion.Location = new Point(142, 102);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Nombre o Descripcion del Producto";
            txtDescripcion.Size = new Size(304, 33);
            txtDescripcion.TabIndex = 2;
            // 
            // txtCodigo
            // 
            txtCodigo.BorderStyle = BorderStyle.None;
            txtCodigo.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigo.ForeColor = Color.LightSeaGreen;
            txtCodigo.Location = new Point(142, 49);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PlaceholderText = "Codigo Interno";
            txtCodigo.Size = new Size(304, 33);
            txtCodigo.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Dubai", 15.75F);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(74, 207);
            label4.Name = "label4";
            label4.Size = new Size(70, 36);
            label4.TabIndex = 3;
            label4.Text = "Fecha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Dubai", 15.75F);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(51, 154);
            label3.Name = "label3";
            label3.Size = new Size(89, 36);
            label3.TabIndex = 2;
            label3.Text = "Recargo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Dubai", 15.75F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(19, 101);
            label2.Name = "label2";
            label2.Size = new Size(121, 36);
            label2.TabIndex = 1;
            label2.Text = "Descripción:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Dubai", 15.75F);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(61, 48);
            label5.Name = "label5";
            label5.Size = new Size(79, 36);
            label5.TabIndex = 0;
            label5.Text = "Código:";
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderColor = Color.DimGray;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Dubai", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(629, 511);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(266, 81);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmCargarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1075, 640);
            Controls.Add(btnSalir);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnGUardar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmCargarProducto";
            Text = "Carga Producto";
            Load += FrmCargarProducto_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGUardar;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtFecha;
        private TextBox txtRecargo;
        private TextBox txtDescripcion;
        private TextBox txtCodigo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private TextBox txtMarca;
        private Label label8;
        private TextBox txtIva;
        private Label label7;
        private TextBox txtStock;
        private Label label6;
        private TextBox txtObservacion;
        private Label label9;
        private Button btnSalir;
        private Label label12;
        private Label label11;
        private TextBox txtCosto;
        private Label label10;
        private ComboBox cbxProveedor;
        private TextBox txtCodProductoProveedor;
        private Label label13;
        private CheckBox chxSi;
        private Label label14;
        private TextBox txtPrecioFInal;
    }
}
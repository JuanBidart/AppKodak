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
            textBox4 = new TextBox();
            label9 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            txtDatabase = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtHost = new TextBox();
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
            btnGUardar.Location = new Point(16, 550);
            btnGUardar.Name = "btnGUardar";
            btnGUardar.Size = new Size(266, 81);
            btnGUardar.TabIndex = 10;
            btnGUardar.Text = "Guardar";
            btnGUardar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Dubai Medium", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(165, 9);
            label1.Name = "label1";
            label1.Size = new Size(270, 57);
            label1.TabIndex = 11;
            label1.Text = "Nuevo Producto";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtDatabase);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(txtHost);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(554, 479);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Producto Nuevo";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.ForeColor = Color.LightSeaGreen;
            textBox4.Location = new Point(168, 420);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Datos que complementan";
            textBox4.Size = new Size(304, 33);
            textBox4.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Dubai", 15.75F);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(39, 419);
            label9.Name = "label9";
            label9.Size = new Size(127, 36);
            label9.TabIndex = 14;
            label9.Text = "Observación:";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.LightSeaGreen;
            textBox3.Location = new Point(168, 367);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Marca del producto";
            textBox3.Size = new Size(304, 33);
            textBox3.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Dubai", 15.75F);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(93, 366);
            label8.Name = "label8";
            label8.Size = new Size(73, 36);
            label8.TabIndex = 12;
            label8.Text = "Marca:";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.LightSeaGreen;
            textBox2.Location = new Point(168, 314);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Iva";
            textBox2.Size = new Size(304, 33);
            textBox2.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Dubai", 15.75F);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(123, 313);
            label7.Name = "label7";
            label7.Size = new Size(43, 36);
            label7.TabIndex = 10;
            label7.Text = "Iva:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.LightSeaGreen;
            textBox1.Location = new Point(168, 261);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Stock";
            textBox1.Size = new Size(304, 33);
            textBox1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Dubai", 15.75F);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(97, 260);
            label6.Name = "label6";
            label6.Size = new Size(69, 36);
            label6.TabIndex = 8;
            label6.Text = "Stock:";
            // 
            // txtDatabase
            // 
            txtDatabase.BorderStyle = BorderStyle.None;
            txtDatabase.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDatabase.ForeColor = Color.LightSeaGreen;
            txtDatabase.Location = new Point(168, 208);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.PlaceholderText = "Fecha de modificacion";
            txtDatabase.Size = new Size(304, 33);
            txtDatabase.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.LightSeaGreen;
            txtPassword.Location = new Point(168, 155);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "El Porcentaje de recargo";
            txtPassword.Size = new Size(304, 33);
            txtPassword.TabIndex = 6;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.LightSeaGreen;
            txtUsername.Location = new Point(168, 102);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Nombre o Descripcion del Producto";
            txtUsername.Size = new Size(304, 33);
            txtUsername.TabIndex = 5;
            // 
            // txtHost
            // 
            txtHost.BorderStyle = BorderStyle.None;
            txtHost.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHost.ForeColor = Color.LightSeaGreen;
            txtHost.Location = new Point(168, 49);
            txtHost.Name = "txtHost";
            txtHost.PlaceholderText = "Codigo Interno";
            txtHost.Size = new Size(304, 33);
            txtHost.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Dubai", 15.75F);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(100, 207);
            label4.Name = "label4";
            label4.Size = new Size(66, 36);
            label4.TabIndex = 3;
            label4.Text = "fecha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Dubai", 15.75F);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(77, 154);
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
            label2.Location = new Point(45, 101);
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
            label5.Location = new Point(87, 48);
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
            btnSalir.Location = new Point(300, 550);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(266, 81);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmCargarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(623, 652);
            Controls.Add(btnSalir);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnGUardar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmCargarProducto";
            Text = "Carga Producto";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGUardar;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtDatabase;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtHost;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private TextBox textBox3;
        private Label label8;
        private TextBox textBox2;
        private Label label7;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox4;
        private Label label9;
        private Button btnSalir;
    }
}
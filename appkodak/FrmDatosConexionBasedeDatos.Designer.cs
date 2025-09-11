namespace appkodak
{
    partial class FrmDatosConexionBasedeDatos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtHost = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtDatabase = new TextBox();
            btnProbarNuevaConexion = new Button();
            btnGuardarDatos = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnProbarConExistente = new Button();
            txtDatabaseActual = new TextBox();
            txtpaswordActual = new TextBox();
            txtUsernameActual = new TextBox();
            txtHostActual = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btn = new Button();
            lblestadonuevo = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Dubai", 15.75F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(52, 62);
            label1.Name = "label1";
            label1.Size = new Size(62, 36);
            label1.TabIndex = 0;
            label1.Text = "Host:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Dubai", 15.75F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(7, 121);
            label2.Name = "label2";
            label2.Size = new Size(107, 36);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Dubai", 15.75F);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(11, 180);
            label3.Name = "label3";
            label3.Size = new Size(103, 36);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Dubai", 15.75F);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(13, 239);
            label4.Name = "label4";
            label4.Size = new Size(101, 36);
            label4.TabIndex = 3;
            label4.Text = "Database:";
            // 
            // txtHost
            // 
            txtHost.BorderStyle = BorderStyle.None;
            txtHost.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHost.ForeColor = Color.LightSeaGreen;
            txtHost.Location = new Point(120, 62);
            txtHost.Name = "txtHost";
            txtHost.PlaceholderText = "Direccion de la base de datos";
            txtHost.Size = new Size(304, 33);
            txtHost.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.LightSeaGreen;
            txtUsername.Location = new Point(120, 124);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Usuario de la base de datos";
            txtUsername.Size = new Size(304, 33);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.LightSeaGreen;
            txtPassword.Location = new Point(120, 183);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Contraseña de la base de datos";
            txtPassword.Size = new Size(304, 33);
            txtPassword.TabIndex = 6;
            // 
            // txtDatabase
            // 
            txtDatabase.BorderStyle = BorderStyle.None;
            txtDatabase.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDatabase.ForeColor = Color.LightSeaGreen;
            txtDatabase.Location = new Point(120, 239);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.PlaceholderText = "Nombre de la base de datos";
            txtDatabase.Size = new Size(304, 33);
            txtDatabase.TabIndex = 7;
            // 
            // btnProbarNuevaConexion
            // 
            btnProbarNuevaConexion.FlatAppearance.BorderColor = Color.DimGray;
            btnProbarNuevaConexion.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnProbarNuevaConexion.FlatStyle = FlatStyle.Flat;
            btnProbarNuevaConexion.Font = new Font("Dubai", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProbarNuevaConexion.ForeColor = Color.White;
            btnProbarNuevaConexion.Location = new Point(22, 309);
            btnProbarNuevaConexion.Name = "btnProbarNuevaConexion";
            btnProbarNuevaConexion.Size = new Size(402, 46);
            btnProbarNuevaConexion.TabIndex = 8;
            btnProbarNuevaConexion.Text = "Probar Nueva Conexión";
            btnProbarNuevaConexion.UseVisualStyleBackColor = true;
            btnProbarNuevaConexion.Click += btnProbarNuevaConexion_Click;
            // 
            // btnGuardarDatos
            // 
            btnGuardarDatos.FlatAppearance.BorderColor = Color.DimGray;
            btnGuardarDatos.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnGuardarDatos.FlatStyle = FlatStyle.Flat;
            btnGuardarDatos.Font = new Font("Dubai", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardarDatos.ForeColor = Color.White;
            btnGuardarDatos.Location = new Point(33, 465);
            btnGuardarDatos.Name = "btnGuardarDatos";
            btnGuardarDatos.Size = new Size(402, 46);
            btnGuardarDatos.TabIndex = 9;
            btnGuardarDatos.Text = "Guardar nuevos datos de conexión";
            btnGuardarDatos.UseVisualStyleBackColor = true;
            btnGuardarDatos.Click += btnGuardarDatos_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnProbarNuevaConexion);
            groupBox1.Controls.Add(txtDatabase);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(txtHost);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(11, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(446, 382);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nueva Conexion";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnProbarConExistente);
            groupBox2.Controls.Add(txtDatabaseActual);
            groupBox2.Controls.Add(txtpaswordActual);
            groupBox2.Controls.Add(txtUsernameActual);
            groupBox2.Controls.Add(txtHostActual);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(493, 30);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(446, 382);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos Actuales";
            // 
            // btnProbarConExistente
            // 
            btnProbarConExistente.FlatAppearance.BorderColor = Color.DimGray;
            btnProbarConExistente.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnProbarConExistente.FlatStyle = FlatStyle.Flat;
            btnProbarConExistente.Font = new Font("Dubai", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProbarConExistente.ForeColor = Color.White;
            btnProbarConExistente.Location = new Point(22, 309);
            btnProbarConExistente.Name = "btnProbarConExistente";
            btnProbarConExistente.Size = new Size(402, 46);
            btnProbarConExistente.TabIndex = 9;
            btnProbarConExistente.Text = "Probar Conexión Existente";
            btnProbarConExistente.UseVisualStyleBackColor = true;
            btnProbarConExistente.Click += btnProbarConExistente_Click;
            // 
            // txtDatabaseActual
            // 
            txtDatabaseActual.BackColor = Color.FromArgb(40, 40, 40);
            txtDatabaseActual.BorderStyle = BorderStyle.None;
            txtDatabaseActual.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDatabaseActual.ForeColor = Color.LightSeaGreen;
            txtDatabaseActual.Location = new Point(120, 239);
            txtDatabaseActual.Name = "txtDatabaseActual";
            txtDatabaseActual.ReadOnly = true;
            txtDatabaseActual.Size = new Size(304, 33);
            txtDatabaseActual.TabIndex = 7;
            // 
            // txtpaswordActual
            // 
            txtpaswordActual.BackColor = Color.FromArgb(40, 40, 40);
            txtpaswordActual.BorderStyle = BorderStyle.None;
            txtpaswordActual.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpaswordActual.ForeColor = Color.LightSeaGreen;
            txtpaswordActual.Location = new Point(120, 183);
            txtpaswordActual.Name = "txtpaswordActual";
            txtpaswordActual.ReadOnly = true;
            txtpaswordActual.Size = new Size(304, 33);
            txtpaswordActual.TabIndex = 6;
            // 
            // txtUsernameActual
            // 
            txtUsernameActual.BackColor = Color.FromArgb(40, 40, 40);
            txtUsernameActual.BorderStyle = BorderStyle.None;
            txtUsernameActual.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsernameActual.ForeColor = Color.LightSeaGreen;
            txtUsernameActual.Location = new Point(120, 124);
            txtUsernameActual.Name = "txtUsernameActual";
            txtUsernameActual.ReadOnly = true;
            txtUsernameActual.Size = new Size(304, 33);
            txtUsernameActual.TabIndex = 5;
            // 
            // txtHostActual
            // 
            txtHostActual.BackColor = Color.FromArgb(40, 40, 40);
            txtHostActual.BorderStyle = BorderStyle.None;
            txtHostActual.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHostActual.ForeColor = Color.LightSeaGreen;
            txtHostActual.Location = new Point(120, 62);
            txtHostActual.Name = "txtHostActual";
            txtHostActual.ReadOnly = true;
            txtHostActual.Size = new Size(304, 33);
            txtHostActual.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Dubai", 15.75F);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(13, 239);
            label5.Name = "label5";
            label5.Size = new Size(101, 36);
            label5.TabIndex = 3;
            label5.Text = "Database:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Dubai", 15.75F);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(11, 180);
            label6.Name = "label6";
            label6.Size = new Size(103, 36);
            label6.TabIndex = 2;
            label6.Text = "Password:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Dubai", 15.75F);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(7, 121);
            label7.Name = "label7";
            label7.Size = new Size(107, 36);
            label7.TabIndex = 1;
            label7.Text = "Username:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Dubai", 15.75F);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(52, 62);
            label8.Name = "label8";
            label8.Size = new Size(62, 36);
            label8.TabIndex = 0;
            label8.Text = "Host:";
            // 
            // btn
            // 
            btn.FlatAppearance.BorderColor = Color.DimGray;
            btn.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font("Dubai", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn.ForeColor = Color.White;
            btn.Location = new Point(515, 465);
            btn.Name = "btn";
            btn.Size = new Size(402, 46);
            btn.TabIndex = 12;
            btn.Text = "No modificar los datos de conexión";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // lblestadonuevo
            // 
            lblestadonuevo.AutoEllipsis = true;
            lblestadonuevo.AutoSize = true;
            lblestadonuevo.Dock = DockStyle.Fill;
            lblestadonuevo.Font = new Font("Dubai", 15.75F);
            lblestadonuevo.ForeColor = SystemColors.Control;
            lblestadonuevo.Location = new Point(3, 0);
            lblestadonuevo.Name = "lblestadonuevo";
            lblestadonuevo.Size = new Size(867, 41);
            lblestadonuevo.TabIndex = 9;
            lblestadonuevo.Text = ".";
            lblestadonuevo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblestadonuevo, 0, 0);
            tableLayoutPanel1.Location = new Point(44, 418);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(873, 41);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // FrmDatosConexionBasedeDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(961, 545);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnGuardarDatos);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmDatosConexionBasedeDatos";
            Text = "Conexión Base de Datos";
            Load += FrmDatosConexionBasedeDatos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtHost;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtDatabase;
        private Button btnProbarNuevaConexion;
        private Button btnGuardarDatos;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtDatabaseActual;
        private TextBox txtpaswordActual;
        private TextBox txtUsernameActual;
        private TextBox txtHostActual;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnProbarConExistente;
        private Button btn;
        private Label lblestadonuevo;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
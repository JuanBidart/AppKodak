namespace appkodak
{
    partial class frmHerramientasBasedeDatos
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
            btnCerrar = new Button();
            panel1 = new Panel();
            btnDatosCOnexion = new Button();
            btnBackup = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Dock = DockStyle.Right;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.Transparent;
            btnCerrar.Location = new Point(722, 0);
            btnCerrar.Margin = new Padding(10, 3, 3, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(34, 32);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.Controls.Add(btnCerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 32);
            panel1.TabIndex = 1;
            // 
            // btnDatosCOnexion
            // 
            btnDatosCOnexion.FlatAppearance.BorderColor = Color.White;
            btnDatosCOnexion.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnDatosCOnexion.FlatStyle = FlatStyle.Flat;
            btnDatosCOnexion.Font = new Font("Dubai", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDatosCOnexion.ForeColor = Color.Transparent;
            btnDatosCOnexion.Location = new Point(12, 80);
            btnDatosCOnexion.Name = "btnDatosCOnexion";
            btnDatosCOnexion.Size = new Size(359, 216);
            btnDatosCOnexion.TabIndex = 2;
            btnDatosCOnexion.Text = "Cargar Datos de Conexión";
            btnDatosCOnexion.UseVisualStyleBackColor = true;
            btnDatosCOnexion.Click += btnDatosCOnexion_Click;
            // 
            // btnBackup
            // 
            btnBackup.FlatAppearance.BorderColor = Color.White;
            btnBackup.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnBackup.FlatStyle = FlatStyle.Flat;
            btnBackup.Font = new Font("Dubai", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackup.ForeColor = Color.Transparent;
            btnBackup.Location = new Point(385, 80);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(359, 216);
            btnBackup.TabIndex = 3;
            btnBackup.Text = "Backup/Restauración";
            btnBackup.UseVisualStyleBackColor = true;
            btnBackup.Click += btnBackup_Click;
            // 
            // frmHerramientasBasedeDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(756, 627);
            Controls.Add(btnBackup);
            Controls.Add(btnDatosCOnexion);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHerramientasBasedeDatos";
            Text = "frmHerramientasBasedeDatos";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnCerrar;
        private Panel panel1;
        private Button btnDatosCOnexion;
        private Button btnBackup;
    }
}
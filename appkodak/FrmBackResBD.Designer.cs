namespace appkodak
{
    partial class FrmBackResBD
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
            btnBackup = new Button();
            btnRestaurar = new Button();
            label1 = new Label();
            label2 = new Label();
            Opciones = new GroupBox();
            rbtnBackupCompleto = new RadioButton();
            rbtnSoloEsquema = new RadioButton();
            rbtnSoloDatos = new RadioButton();
            Opciones.SuspendLayout();
            SuspendLayout();
            // 
            // btnBackup
            // 
            btnBackup.FlatAppearance.BorderColor = Color.DimGray;
            btnBackup.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnBackup.FlatStyle = FlatStyle.Flat;
            btnBackup.Font = new Font("Dubai", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBackup.ForeColor = Color.White;
            btnBackup.Location = new Point(12, 272);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(266, 81);
            btnBackup.TabIndex = 9;
            btnBackup.Text = "Realizar Backup";
            btnBackup.UseVisualStyleBackColor = true;
            btnBackup.Click += btnBackup_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.FlatAppearance.BorderColor = Color.DimGray;
            btnRestaurar.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnRestaurar.FlatStyle = FlatStyle.Flat;
            btnRestaurar.Font = new Font("Dubai", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRestaurar.ForeColor = Color.White;
            btnRestaurar.Location = new Point(351, 95);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(266, 81);
            btnRestaurar.TabIndex = 10;
            btnRestaurar.Text = "Restaurar";
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // label1
            // 
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(60, 9);
            label1.Name = "label1";
            label1.Size = new Size(169, 108);
            label1.TabIndex = 11;
            label1.Text = "Realizar Backup De la base de datos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(384, 32);
            label2.Name = "label2";
            label2.Size = new Size(209, 32);
            label2.TabIndex = 12;
            label2.Text = "Restaurar Base de Datos";
            // 
            // Opciones
            // 
            Opciones.Controls.Add(rbtnBackupCompleto);
            Opciones.Controls.Add(rbtnSoloEsquema);
            Opciones.Controls.Add(rbtnSoloDatos);
            Opciones.FlatStyle = FlatStyle.Flat;
            Opciones.ForeColor = Color.LightSeaGreen;
            Opciones.Location = new Point(12, 85);
            Opciones.Name = "Opciones";
            Opciones.Size = new Size(267, 175);
            Opciones.TabIndex = 17;
            Opciones.TabStop = false;
            Opciones.Text = "Opciones de Backup";
            // 
            // rbtnBackupCompleto
            // 
            rbtnBackupCompleto.AutoSize = true;
            rbtnBackupCompleto.Cursor = Cursors.Hand;
            rbtnBackupCompleto.FlatAppearance.CheckedBackColor = Color.LightSeaGreen;
            rbtnBackupCompleto.FlatStyle = FlatStyle.Flat;
            rbtnBackupCompleto.ForeColor = Color.Transparent;
            rbtnBackupCompleto.Location = new Point(16, 121);
            rbtnBackupCompleto.Name = "rbtnBackupCompleto";
            rbtnBackupCompleto.Size = new Size(169, 36);
            rbtnBackupCompleto.TabIndex = 19;
            rbtnBackupCompleto.TabStop = true;
            rbtnBackupCompleto.Text = "Backup Completo";
            rbtnBackupCompleto.UseVisualStyleBackColor = true;
            rbtnBackupCompleto.CheckedChanged += rbtnBackupCompleto_CheckedChanged;
            // 
            // rbtnSoloEsquema
            // 
            rbtnSoloEsquema.AutoSize = true;
            rbtnSoloEsquema.Cursor = Cursors.Hand;
            rbtnSoloEsquema.FlatAppearance.CheckedBackColor = Color.LightSeaGreen;
            rbtnSoloEsquema.FlatStyle = FlatStyle.Flat;
            rbtnSoloEsquema.ForeColor = Color.Transparent;
            rbtnSoloEsquema.Location = new Point(16, 78);
            rbtnSoloEsquema.Name = "rbtnSoloEsquema";
            rbtnSoloEsquema.Size = new Size(141, 36);
            rbtnSoloEsquema.TabIndex = 18;
            rbtnSoloEsquema.TabStop = true;
            rbtnSoloEsquema.Text = "Solo Esquema";
            rbtnSoloEsquema.UseVisualStyleBackColor = true;
            rbtnSoloEsquema.CheckedChanged += rbtnBackupCompleto_CheckedChanged;
            // 
            // rbtnSoloDatos
            // 
            rbtnSoloDatos.AutoSize = true;
            rbtnSoloDatos.Cursor = Cursors.Hand;
            rbtnSoloDatos.FlatAppearance.CheckedBackColor = Color.LightSeaGreen;
            rbtnSoloDatos.FlatStyle = FlatStyle.Flat;
            rbtnSoloDatos.ForeColor = Color.Transparent;
            rbtnSoloDatos.Location = new Point(16, 35);
            rbtnSoloDatos.Name = "rbtnSoloDatos";
            rbtnSoloDatos.Size = new Size(117, 36);
            rbtnSoloDatos.TabIndex = 17;
            rbtnSoloDatos.TabStop = true;
            rbtnSoloDatos.Text = "Solo Datos";
            rbtnSoloDatos.UseVisualStyleBackColor = true;
            rbtnSoloDatos.CheckedChanged += rbtnBackupCompleto_CheckedChanged;
            // 
            // FrmBackResBD
            // 
            AutoScaleDimensions = new SizeF(10F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(644, 381);
            Controls.Add(Opciones);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRestaurar);
            Controls.Add(btnBackup);
            Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 6, 4, 6);
            Name = "FrmBackResBD";
            Text = "FrmBackResBD";
            Opciones.ResumeLayout(false);
            Opciones.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBackup;
        private Button btnRestaurar;
        private Label label1;
        private Label label2;
        private GroupBox Opciones;
        private RadioButton rbtnSoloDatos;
        private RadioButton rbtnBackupCompleto;
        private RadioButton rbtnSoloEsquema;
    }
}
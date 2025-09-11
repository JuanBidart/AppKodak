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
            label3 = new Label();
            txtEstado = new TextBox();
            SuspendLayout();
            // 
            // btnBackup
            // 
            btnBackup.FlatAppearance.BorderColor = Color.DimGray;
            btnBackup.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnBackup.FlatStyle = FlatStyle.Flat;
            btnBackup.Font = new Font("Dubai", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBackup.ForeColor = Color.White;
            btnBackup.Location = new Point(6, 95);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(266, 81);
            btnBackup.TabIndex = 9;
            btnBackup.Text = "Backup";
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
            btnRestaurar.Location = new Point(293, 95);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(266, 81);
            btnRestaurar.TabIndex = 10;
            btnRestaurar.Text = "Restaurar";
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(71, 18);
            label1.Name = "label1";
            label1.Size = new Size(137, 32);
            label1.TabIndex = 11;
            label1.Text = "Realizar Backup";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(322, 32);
            label2.Name = "label2";
            label2.Size = new Size(209, 32);
            label2.TabIndex = 12;
            label2.Text = "Restaurar Base de Datos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(55, 50);
            label3.Name = "label3";
            label3.Size = new Size(169, 32);
            label3.TabIndex = 13;
            label3.Text = "de la Base de Datos";
            // 
            // txtEstado
            // 
            txtEstado.BackColor = Color.FromArgb(40, 40, 40);
            txtEstado.BorderStyle = BorderStyle.None;
            txtEstado.ForeColor = Color.LightSeaGreen;
            txtEstado.Location = new Point(12, 182);
            txtEstado.Multiline = true;
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(260, 187);
            txtEstado.TabIndex = 14;
            // 
            // FrmBackResBD
            // 
            AutoScaleDimensions = new SizeF(10F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(585, 381);
            Controls.Add(txtEstado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRestaurar);
            Controls.Add(btnBackup);
            Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 6, 4, 6);
            Name = "FrmBackResBD";
            Text = "FrmBackResBD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBackup;
        private Button btnRestaurar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEstado;
    }
}
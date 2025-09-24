namespace appkodak
{
    partial class FrmListaProveedores
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label5 = new Label();
            dgvResultados = new DataGridView();
            txtConsulta = new TextBox();
            btnEjecutar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Dubai", 15.75F);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(33, 26);
            label5.Name = "label5";
            label5.Size = new Size(96, 36);
            label5.TabIndex = 5;
            label5.Text = "Consulta:";
            // 
            // dgvResultados
            // 
            dgvResultados.BackgroundColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(180, 80, 30);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(33, 121);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 180, 170);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvResultados.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvResultados.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.LightSeaGreen;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(180, 80, 30);
            dgvResultados.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvResultados.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            dgvResultados.RowTemplate.DefaultCellStyle.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvResultados.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dgvResultados.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(180, 80, 30);
            dgvResultados.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvResultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResultados.Size = new Size(453, 387);
            dgvResultados.TabIndex = 8;
            // 
            // txtConsulta
            // 
            txtConsulta.BorderStyle = BorderStyle.None;
            txtConsulta.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConsulta.ForeColor = Color.LightSeaGreen;
            txtConsulta.Location = new Point(33, 65);
            txtConsulta.Name = "txtConsulta";
            txtConsulta.PlaceholderText = "Ingresar Consulta SQL";
            txtConsulta.Size = new Size(627, 33);
            txtConsulta.TabIndex = 6;
            // 
            // btnEjecutar
            // 
            btnEjecutar.FlatAppearance.BorderColor = Color.FromArgb(180, 80, 30);
            btnEjecutar.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnEjecutar.FlatStyle = FlatStyle.Flat;
            btnEjecutar.Font = new Font("Dubai", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEjecutar.ForeColor = Color.White;
            btnEjecutar.Location = new Point(517, 427);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(266, 81);
            btnEjecutar.TabIndex = 7;
            btnEjecutar.Text = "Ejecutar";
            btnEjecutar.UseVisualStyleBackColor = true;
            // 
            // FrmListaProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(959, 542);
            Controls.Add(label5);
            Controls.Add(dgvResultados);
            Controls.Add(txtConsulta);
            Controls.Add(btnEjecutar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmListaProveedores";
            Text = "Lista Proveedores";
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private DataGridView dgvResultados;
        private TextBox txtConsulta;
        private Button btnEjecutar;
    }
}
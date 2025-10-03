namespace appkodak
{
    partial class FrmListasdePrecio_revendedorProfesional
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnAgregarNuevo = new Button();
            txtLista = new TextBox();
            dgvListas = new DataGridView();
            label5 = new Label();
            label1 = new Label();
            txtPorcentaje = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvListas).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarNuevo
            // 
            btnAgregarNuevo.FlatAppearance.BorderColor = Color.FromArgb(179, 82, 32);
            btnAgregarNuevo.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnAgregarNuevo.FlatStyle = FlatStyle.Flat;
            btnAgregarNuevo.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarNuevo.ForeColor = Color.Transparent;
            btnAgregarNuevo.Location = new Point(51, 330);
            btnAgregarNuevo.Name = "btnAgregarNuevo";
            btnAgregarNuevo.Size = new Size(210, 81);
            btnAgregarNuevo.TabIndex = 9;
            btnAgregarNuevo.Text = "Agregar Nuevo";
            btnAgregarNuevo.UseVisualStyleBackColor = true;
            btnAgregarNuevo.Click += btnAgregarNuevo_Click;
            // 
            // txtLista
            // 
            txtLista.Location = new Point(119, 87);
            txtLista.Name = "txtLista";
            txtLista.Size = new Size(189, 35);
            txtLista.TabIndex = 10;
            // 
            // dgvListas
            // 
            dgvListas.BackgroundColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(180, 80, 30);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvListas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvListas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListas.Location = new Point(365, 38);
            dgvListas.Name = "dgvListas";
            dgvListas.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(30, 180, 170);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvListas.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvListas.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.LightSeaGreen;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(180, 80, 30);
            dgvListas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvListas.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            dgvListas.RowTemplate.DefaultCellStyle.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvListas.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dgvListas.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(180, 80, 30);
            dgvListas.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvListas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListas.Size = new Size(311, 274);
            dgvListas.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Dubai", 15.75F);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(51, 86);
            label5.Name = "label5";
            label5.Size = new Size(62, 36);
            label5.TabIndex = 12;
            label5.Text = "Lista:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Dubai", 15.75F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(51, 165);
            label1.Name = "label1";
            label1.Size = new Size(113, 36);
            label1.TabIndex = 14;
            label1.Text = "Porcentaje:";
            // 
            // txtPorcentaje
            // 
            txtPorcentaje.Location = new Point(170, 166);
            txtPorcentaje.Name = "txtPorcentaje";
            txtPorcentaje.Size = new Size(138, 35);
            txtPorcentaje.TabIndex = 13;
            // 
            // FrmListasdePrecio_revendedorProfesional
            // 
            AutoScaleDimensions = new SizeF(8F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(727, 450);
            Controls.Add(label1);
            Controls.Add(txtPorcentaje);
            Controls.Add(label5);
            Controls.Add(dgvListas);
            Controls.Add(txtLista);
            Controls.Add(btnAgregarNuevo);
            Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 5, 3, 5);
            Name = "FrmListasdePrecio_revendedorProfesional";
            Text = "Configuracion de Listas";
            Load += FrmListasdePrecio_revendedorProfesional_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAgregarNuevo;
        private TextBox txtLista;
        private DataGridView dgvListas;
        private Label label5;
        private Label label1;
        private TextBox txtPorcentaje;
    }
}
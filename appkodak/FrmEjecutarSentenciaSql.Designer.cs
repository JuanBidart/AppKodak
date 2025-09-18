namespace appkodak
{
    partial class FrmEjecutarSentenciaSql
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

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
            btnLimpiar = new Button();
            btnEjecutar = new Button();
            txtConsulta = new TextBox();
            dgvResultados = new DataGridView();
            lblEstado = new Label();
            panel1 = new Panel();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(180, 80, 30);
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Dubai", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(703, 97);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(266, 81);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEjecutar
            // 
            btnEjecutar.FlatAppearance.BorderColor = Color.FromArgb(180, 80, 30);
            btnEjecutar.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnEjecutar.FlatStyle = FlatStyle.Flat;
            btnEjecutar.Font = new Font("Dubai", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEjecutar.ForeColor = Color.White;
            btnEjecutar.Location = new Point(249, 97);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(266, 81);
            btnEjecutar.TabIndex = 2;
            btnEjecutar.Text = "Ejecutar";
            btnEjecutar.UseVisualStyleBackColor = true;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // txtConsulta
            // 
            txtConsulta.BorderStyle = BorderStyle.None;
            txtConsulta.Font = new Font("Dubai", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConsulta.ForeColor = Color.LightSeaGreen;
            txtConsulta.Location = new Point(12, 50);
            txtConsulta.Name = "txtConsulta";
            txtConsulta.PlaceholderText = "Ingresar Consulta SQL";
            txtConsulta.Size = new Size(1154, 33);
            txtConsulta.TabIndex = 1;
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
            dgvResultados.Location = new Point(12, 191);
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
            dgvResultados.Size = new Size(1154, 307);
            dgvResultados.TabIndex = 4;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Dock = DockStyle.Right;
            lblEstado.Font = new Font("Dubai Medium", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEstado.ImageAlign = ContentAlignment.MiddleRight;
            lblEstado.Location = new Point(1095, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(68, 32);
            lblEstado.TabIndex = 0;
            lblEstado.Text = "label1";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblEstado);
            panel1.Location = new Point(12, 501);
            panel1.Name = "panel1";
            panel1.Size = new Size(1163, 40);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Dubai", 15.75F);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(12, 11);
            label5.Name = "label5";
            label5.Size = new Size(96, 36);
            label5.TabIndex = 0;
            label5.Text = "Consulta:";
            // 
            // FrmEjecutarSentenciaSql
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1178, 548);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(dgvResultados);
            Controls.Add(txtConsulta);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEjecutar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmEjecutarSentenciaSql";
            Text = "Ejecutar Sentencia";
            Load += FrmEjecutarSentenciaSql_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpiar;
        private Button btnEjecutar;
        private TextBox txtConsulta;   
        private DataGridView dgvResultados;
        private Label lblEstado;
        private Panel panel1;
        private Label label5;
    }
}
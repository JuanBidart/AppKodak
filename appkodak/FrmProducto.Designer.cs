namespace appkodak
{
    partial class FrmProducto
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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            cbxBuscar = new ComboBox();
            dgvProductos = new DataGridView();
            btnCargarProducto = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1261, 70);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Font = new Font("Dubai Medium", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(394, 9);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(459, 70);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Dubai Medium", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(7, 6);
            label1.Name = "label1";
            label1.Size = new Size(445, 57);
            label1.TabIndex = 0;
            label1.Text = "Configuracion de Productos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbxBuscar
            // 
            cbxBuscar.FormattingEnabled = true;
            cbxBuscar.Location = new Point(46, 112);
            cbxBuscar.Name = "cbxBuscar";
            cbxBuscar.Size = new Size(548, 23);
            cbxBuscar.TabIndex = 1;
            // 
            // dgvProductos
            // 
            dgvProductos.BackgroundColor = Color.FromArgb(60, 60, 60);
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.GridColor = Color.White;
            dgvProductos.Location = new Point(45, 175);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.Size = new Size(684, 306);
            dgvProductos.TabIndex = 2;
            // 
            // btnCargarProducto
            // 
            btnCargarProducto.FlatAppearance.BorderColor = Color.DimGray;
            btnCargarProducto.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnCargarProducto.FlatStyle = FlatStyle.Flat;
            btnCargarProducto.Font = new Font("Dubai", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCargarProducto.ForeColor = Color.White;
            btnCargarProducto.Location = new Point(58, 528);
            btnCargarProducto.Name = "btnCargarProducto";
            btnCargarProducto.Size = new Size(266, 81);
            btnCargarProducto.TabIndex = 11;
            btnCargarProducto.Text = "Cargar Producto";
            btnCargarProducto.UseVisualStyleBackColor = true;
            btnCargarProducto.Click += btnCargarProducto_Click;
            // 
            // FrmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1261, 635);
            Controls.Add(btnCargarProducto);
            Controls.Add(dgvProductos);
            Controls.Add(cbxBuscar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FrmProducto";
            Text = "FrmProducto";
            Load += FrmProducto_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private ComboBox cbxBuscar;
        private DataGridView dgvProductos;
        private Button btnCargarProducto;
    }
}
namespace appkodak
{
    partial class FormCargarProducto
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
            btnCargar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCargar
            // 
            btnCargar.FlatAppearance.BorderColor = Color.DimGray;
            btnCargar.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnCargar.FlatStyle = FlatStyle.Flat;
            btnCargar.Font = new Font("Dubai", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCargar.ForeColor = Color.White;
            btnCargar.Location = new Point(71, 431);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(266, 81);
            btnCargar.TabIndex = 10;
            btnCargar.Text = "Realizar Backup";
            btnCargar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Dubai Medium", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(321, 9);
            label1.Name = "label1";
            label1.Size = new Size(270, 57);
            label1.TabIndex = 11;
            label1.Text = "Nuevo Producto";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormCargarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(965, 540);
            Controls.Add(label1);
            Controls.Add(btnCargar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormCargarProducto";
            Text = "FormCargarProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCargar;
        private Label label1;
    }
}
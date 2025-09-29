using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public class MiMensaje : Form
{
    // ===================== ENUMS =====================
    public enum MbxIcon
    {
        Ninguno,
        Info,
        Advertencia,
        Error,
        Pregunta,
        Exclamacion
    }

    public enum MbxButton
    {
        Ok,
        Si,
        No,
        Listo,
        Cancelar,
        Salir,
        Cerrar,
        Guardar
    }

    // ===================== CAMPOS =====================
    private Label lblMessage;
    private PictureBox picIcon;
    private FlowLayoutPanel panelButtons;
    private System.Windows.Forms.Timer autoCloseTimer;

    public DialogResult Result { get; private set; } = DialogResult.None;

    // ===================== CONSTRUCTOR =====================
    public MiMensaje(
        string message,
        string caption = "Mensaje",
        MbxIcon icono = MbxIcon.Info,
        IEnumerable<MbxButton>? botones = null,
        int tiempoMs = 0)
    {
        // Configuración ventana
        this.Text = caption;
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.StartPosition = FormStartPosition.CenterScreen;
        this.BackColor = Color.FromArgb(40, 40, 40); // gris oscuro
        this.ForeColor = Color.White;
        this.ClientSize = new Size(400, 180);
        this.Font = new Font("Dubai", 14);
        this.MaximizeBox = false;
        this.MinimizeBox = false;

        // Label principal
        lblMessage = new Label()
        {
            Text = message,
            AutoSize = false,
            TextAlign = ContentAlignment.MiddleLeft,
            Dock = DockStyle.Fill
        };

        // Icono
        picIcon = new PictureBox()
        {
            Size = new Size(64, 64),
            SizeMode = PictureBoxSizeMode.StretchImage,
            Margin = new Padding(10)
        };

        // Asignar icono según enum
        switch (icono)
        {
            case MbxIcon.Error: picIcon.Image = Image.FromFile("./Icons8/msbxCerrar.png") ; break;
            case MbxIcon.Advertencia: picIcon.Image = Image.FromFile("./Icons8/msbxPrecaucion.png"); break;
            case MbxIcon.Info: picIcon.Image = Image.FromFile("./Icons8/msbxInformacion.png"); break;
            case MbxIcon.Pregunta: picIcon.Image = Image.FromFile("./Icons8/msbxPregunta.png"); break;
            case MbxIcon.Exclamacion: picIcon.Image = SystemIcons.Warning.ToBitmap(); break; // podés poner otro recurso
            case MbxIcon.Ninguno: picIcon.Image = null; break;
        }

        // Panel de botones
        panelButtons = new FlowLayoutPanel()
        {
            Dock = DockStyle.Bottom,
            FlowDirection = FlowDirection.RightToLeft,
            Height = 50,
            Padding = new Padding(5),
            BackColor = Color.FromArgb(32, 179, 171) // celeste verdoso
        };

        // Agregar botones
        if (botones != null)
        {
            foreach (var b in botones)
                AddButton(b);
        }

        // Layout principal
        var layout = new TableLayoutPanel()
        {
            Dock = DockStyle.Fill,
            ColumnCount = 2,
            RowCount = 1
        };


        layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80));
        layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

        picIcon.Anchor = AnchorStyles.None;

        layout.Controls.Add(picIcon, 0, 0);
        layout.Controls.Add(lblMessage, 1, 0);

        this.Controls.Add(layout);
        this.Controls.Add(panelButtons);

        // Timer para cierre automático
        if (tiempoMs > 0)
        {
            autoCloseTimer = new System.Windows.Forms.Timer();
            autoCloseTimer.Interval = tiempoMs;
            autoCloseTimer.Tick += (s, e) =>
            {
                autoCloseTimer.Stop();
                this.DialogResult = Result == DialogResult.None ? DialogResult.OK : Result;
                this.Close();
            };
            autoCloseTimer.Start();
        }
    }

    // ===================== MÉTODOS AUXILIARES =====================
    private void AddButton(MbxButton tipo)
    {
        string text = "";
        DialogResult dr = DialogResult.None;
        Color color = Color.FromArgb(32, 179, 171);

        switch (tipo)
        {
            case MbxButton.Ok: text = "OK"; dr = DialogResult.OK; color = Color.FromArgb(180, 80, 30); break;
            case MbxButton.Si: text = "Sí"; dr = DialogResult.Yes; break;
                case MbxButton.No: text = "No"; dr = DialogResult.No; break;
            case MbxButton.Listo: text = "Listo"; dr = DialogResult.OK; break;
            case MbxButton.Cancelar: text = "Cancelar"; dr = DialogResult.Cancel; color = Color.FromArgb(180, 80, 30); break;
            case MbxButton.Salir: text = "Salir"; dr = DialogResult.Abort; color = Color.FromArgb(180, 80, 30); break;
            case MbxButton.Cerrar: text = "Cerrar"; dr = DialogResult.Cancel; color = Color.FromArgb(180, 80, 30); break;
            case MbxButton.Guardar: text = "Guardar"; dr = DialogResult.Yes; break;
        }

        var btn = new Button()
        {
            Text = text,
            DialogResult = dr,
            BackColor = color,
            ForeColor = Color.White,
            FlatStyle = FlatStyle.Flat,
            Width = 90,
            Height = 35,
            Margin = new Padding(5)
        };
        btn.FlatAppearance.BorderSize = 0;
        btn.Click += (s, e) =>
        {
            this.Result = dr;
            this.DialogResult = dr;
            this.Close();
        };

        panelButtons.Controls.Add(btn);
    }

    // ===================== MÉTODO ESTÁTICO =====================
    public static DialogResult Show(
        string message,
        string caption = "Mensaje",
        MbxIcon icono = MbxIcon.Info,
        IEnumerable<MbxButton>? botones = null,
        int tiempoMs = 0)
    {
        using (var msg = new MiMensaje(message, caption, icono, botones, tiempoMs))
        {
            return msg.ShowDialog();
        }
    }
}

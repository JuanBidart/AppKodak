using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appkodak
{
    public partial class Colorselectionr : Form
    {
        public Colorselectionr()
        {
            InitializeComponent();
        }
        public Color color1 { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            color1 = colorDialog1.Color;
            colorApp.Fondo = color1;
            pictureBox1.BackColor = color1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}

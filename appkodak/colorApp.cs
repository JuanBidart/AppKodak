using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appkodak
{
   public static class colorApp
    {
    public static Color Fondo { get; set; }
        public static Color Letra { get; set; }
        public static Color Boton { get; set; }
        public static Color BotonLetra { get; set; }
        public static Color Barra { get; set; }
        public static Color BarraLetra { get; set; }
        public static Color BarraBoton { get; set; }
        public static Color BarraBotonLetra { get; set; }
        public static Color Panel { get; set; }
        public static Color PanelLetra { get; set; }
        public static Color PanelBoton { get; set; }
        public static Color PanelBotonLetra { get; set; }
        public static Color Menu { get; set; }
        public static Color MenuLetra { get; set; }
        public static Color MenuBoton { get; set; }
        public static Color MenuBotonLetra { get; set; }

        public static void SetDefaultColors()
        {
            Fondo = Color.White;
            Letra = Color.Black;
            Boton = Color.LightGray;
            BotonLetra = Color.Black;
            Barra = Color.DarkGray;
            BarraLetra = Color.White;
            BarraBoton = Color.Gray;
            BarraBotonLetra = Color.White;
            Panel = Color.LightGray;
            PanelLetra = Color.Black;
            PanelBoton = Color.Gray;
            PanelBotonLetra = Color.White;
            Menu = Color.DarkGray;
            MenuLetra = Color.White;
            MenuBoton = Color.Gray;
            MenuBotonLetra = Color.White;
        }

    }
}

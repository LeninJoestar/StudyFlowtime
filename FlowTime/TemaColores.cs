using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowTime
{
    public static class TemaColores
    {
        public static Color fondo;
        public static Color opciones;
        public static Color panel;

        //Color Defecto
        private static readonly Color fondoD = Color.FromArgb(25, 33, 36);
        private static readonly Color opcionesD = Color.FromArgb(38, 47, 49);
        private static readonly Color panelD = Color.FromArgb(51, 64, 66);

        //Color rojo
        private static readonly Color fondoR = Color.FromArgb(41, 7, 7);
        private static readonly Color opcionesR = Color.FromArgb(73, 39, 39);
        private static readonly Color panelR = Color.FromArgb(124, 65, 65);

        //Color azul
        private static readonly Color fondoA = Color.FromArgb(7, 13, 41);
        private static readonly Color opcionesA = Color.FromArgb(39, 49, 73);
        private static readonly Color panelA = Color.FromArgb(65, 85, 124);


        //Color verde
        private static readonly Color fondoV = Color.FromArgb(15, 41, 7);
        private static readonly Color opcionesV = Color.FromArgb(40, 73, 39);
        private static readonly Color panelV = Color.FromArgb(65, 124, 67);


        //Color Amarillo
        private static readonly Color fondoAM = Color.FromArgb(37, 41, 7);
        private static readonly Color opcionesAM = Color.FromArgb(70, 73, 39);
        private static readonly Color panelAM = Color.FromArgb(112, 124, 65);

        public static void Tema(string color)
        {
            switch (color)
            {
                case "D":
                    fondo = fondoD;
                    opciones = opcionesD;
                    panel = panelD;
                    break;
                case "R":
                    fondo = fondoR;
                    opciones = opcionesR;
                    panel = panelR;
                    break;
                case "A":
                    fondo = fondoA;
                    opciones = opcionesA;
                    panel = panelA;
                    break;
                case "V":
                    fondo = fondoV;
                    opciones = opcionesV;
                    panel = panelV;
                    break;
                case "AM":
                    fondo = fondoAM;
                    opciones = opcionesAM;
                    panel = panelAM;
                    break;
                default:
                    fondo = fondoD;
                    opciones = opcionesD;
                    panel = panelD;
                    break;
            }
        }
    }
}

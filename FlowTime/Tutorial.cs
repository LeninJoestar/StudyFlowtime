using FlowTime.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowTime
{
    public partial class Tutorial : Form
    {
        string color = Datos.ObtenerValor();
        private int usuarioId;
        private SqlConnection connection;

        public Tutorial(SqlConnection connection, int usuarioId)
        {
            InitializeComponent();
            this.connection = connection;
            this.usuarioId = usuarioId;
        }

        private void frmTutorial_Load(object sender, EventArgs e)
        {
            pbImagenes.Image = Resources._1;
            if (color != null)
            {
                TemaColores.Tema(color);
                this.BackColor = TemaColores.fondo;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int indiceImagenActual = 1;
        private const int totalImagenes = 22;

        // Array de imágenes
        private Image[] imagenes = {
            Resources._1, Resources._2, Resources._3, Resources._4,
            Resources._5, Resources._6, Resources._7, Resources._8,
            Resources._9, Resources._10, Resources._11, Resources._12,
            Resources._13, Resources._14, Resources._15, Resources._16,
            Resources._17, Resources._18, Resources._19, Resources._20,
            Resources._21, Resources._22
            };

        private void btnSig_Click(object sender, EventArgs e)
        {
            // Incrementar el índice de la imagen actual
            if (indiceImagenActual < totalImagenes)
            {
                indiceImagenActual++;
                pbImagenes.Image = imagenes[indiceImagenActual - 1];
            }

            // Deshabilitar botones si es necesario
            btnIzquierda.Enabled = indiceImagenActual > 1;
            btnDerecha.Enabled = indiceImagenActual < totalImagenes;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            // Decrementar el índice de la imagen actual
            if (indiceImagenActual > 1)
            {
                indiceImagenActual--;
                pbImagenes.Image = imagenes[indiceImagenActual - 1];
            }

            // Deshabilitar botones si es necesario
            btnIzquierda.Enabled = indiceImagenActual > 1;
            btnDerecha.Enabled = indiceImagenActual < totalImagenes;
        }

        private void Tutorial_Load(object sender, EventArgs e)
        {
            pbImagenes.Image = Resources._1;
            TemaColores.Tema(color);
            this.BackColor = TemaColores.fondo;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace FlowTime
{
    public partial class Descanso : Form
    {
        string color = Datos.ObtenerValor();

        private bool mensajeMostrado = false;
        private SpeechSynthesizer synthesizer;
        private int tiempoDescansoSegundos;
        private Timer cronometro;
        private int tiempoDescansoMinutos;
        private Inicio formularioPrincipal;

        public Descanso(int tiempoDescanso, Inicio formularioPrincipal)
        {
            InitializeComponent();
            this.tiempoDescansoSegundos = tiempoDescanso * 60; 
            this.formularioPrincipal = formularioPrincipal; 
            this.Load += FormularioDescanso_Load;
            synthesizer = new SpeechSynthesizer();
        }

        private void FormularioDescanso_Load(object sender, EventArgs e)
        {
            TemaColores.Tema(color);
            this.BackColor = TemaColores.panel;
            lblTiempoDescanso.Text = $"Tiempo descanso {tiempoDescansoSegundos / 60} minutos de descanso.";
        }


        private void LeerMensaje(string mensaje)
        {
           
            if (synthesizer != null && !synthesizer.State.Equals(SynthesizerState.Speaking))
            {
               
                synthesizer.SpeakAsync(mensaje);
            }
        }

        private void IniciarCronometro()
        {
            cronometro = new Timer();
            cronometro.Interval = 1000;
            cronometro.Tick += Cronometro_Tick;
            cronometro.Start();
        }


        private void Cronometro_Tick(object sender, EventArgs e)
        {
            tiempoDescansoSegundos--;

            if (tiempoDescansoSegundos <= 0)
            {

                cronometro.Stop(); 
                MostrarMensaje();

            }

            MostrarTiempoRestante();
        }

        private void MostrarTiempoRestante()
        {
            int minutosRestantes = tiempoDescansoSegundos / 60;
            int segundosRestantes = tiempoDescansoSegundos % 60;
            lblTiempoDescanso.Text = $"Tiempo restante: {minutosRestantes:00}:{segundosRestantes:00}";
        }

        private void MostrarMensaje()
        {
            var resultado = MessageBox.Show("¡Tiempo de descanso terminado! Es hora de regresar a tus actividades.",
                                      "Fin del descanso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (resultado == DialogResult.OK)
            {
                this.Close(); 
                formularioPrincipal.Show(); 
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            IniciarCronometro();
            btnAceptar.Enabled = false;
           
            string mensaje = "Es hora de tomar un descanso. Puedes aprovechar estos minutos para tomar agua, relajarte, o hacer" +
                " cualquier otra actividad para despejar tu mente, antes de regresar a tus labores .";

            
            LeerMensaje(mensaje);
        }

        private void Descanso_Load(object sender, EventArgs e)
        {

        }

        private void tmrDescanso_Tick(object sender, EventArgs e)
        {

        }
    }
}

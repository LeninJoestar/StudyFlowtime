using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Data.SqlClient;
using CircularProgressBar;

namespace FlowTime
{
    public partial class Inicio : Form
    {
        string color = Datos.ObtenerValor();

        private SpeechSynthesizer synthesizer;
        private Point lastPoint;
        private SqlConnection Connection;
        private int Usuario_id;
        private InterfazInicial formularioInicial;
        private bool iniciado = false;
        private Datos datos = new Datos();

        private bool cronometroActivo = false;
        private bool cronometroPausado = false;
        private bool enDescanso = false;
        private int tiempoDescansoSegundos;
        private int milisegundos = 0;
        private int segundos = 0;
        private int minutos = 0;

        public Inicio(SqlConnection connection, int usuarioId)
        {
            InitializeComponent();
            this.Connection = connection;
            this.Usuario_id = usuarioId;
         
            lblTimer.Text = $"00:00:00";
            synthesizer = new SpeechSynthesizer();
     
            pbCarga.Image = null;
        }

        public void SetUsuarioId(int usuarioId)
        {
            this.Usuario_id = usuarioId;
        }

        private void tmrCronometro_Tick(object sender, EventArgs e)
        {
            if (enDescanso)
            {
                // Reducir el tiempo de descanso
                if (tiempoDescansoSegundos > 0)
                {
                    tiempoDescansoSegundos--;
                    MostrarDescanso();
                }
                else
                {
                    // Terminar el descanso automáticamente
                    TerminarDescanso();
                }
            }
            else
            {
                milisegundos++;

                if (milisegundos >= 100)
                {
                    milisegundos = 0;
                    segundos++;
                }

                if (segundos >= 60)
                {
                    segundos = 0;
                    minutos++;
                }

                lblTimer.Text = $"{minutos:00}:{segundos:00}:{milisegundos:00}";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            SalidaFlow.Start();
        }

        private void MostrarDescanso()
        {
            int minutosRestantes = tiempoDescansoSegundos / 60;
            int segundosRestantes = tiempoDescansoSegundos % 60;
            lblTimer.Text = $"{minutosRestantes:00}:{segundosRestantes:00}";
            btnFlow.Text = "Iniciar";
        }

        private void btnTermiar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cronometroActivo)
                {
                    cronometroActivo = false;
                    cronometroPausado = false;
                    tmrCronometro.Stop();
                    int tiempoEstudioMinutos = minutos + (segundos / 60);

                    if (tiempoEstudioMinutos >= 1 && tiempoEstudioMinutos <= 3)
                    {
                        tiempoDescansoSegundos = 6 * 60;
                    }
                    else if (tiempoEstudioMinutos > 50 && tiempoEstudioMinutos <= 90)
                    {
                        tiempoDescansoSegundos = 15 * 60;
                    }
                    else if (tiempoEstudioMinutos > 90)
                    {
                        tiempoDescansoSegundos = 20 * 60;
                    }
                    else
                    {
                        tiempoDescansoSegundos = 1 * 60;
                    }

                    // Guardar el tiempo de estudio en la base de datos
                    string upsertQuery = @"IF EXISTS (SELECT 1 FROM TiempoFlowtime WHERE Fecha = @Fecha AND Usuario_id = @Usuario_id)
            BEGIN
                UPDATE TiempoFlowtime
                SET TiempoEstudioMinutos = TiempoEstudioMinutos + @TiempoEstudioMinutos,
                    TiempoDescansoMinutos = TiempoDescansoMinutos + @TiempoDescansoMinutos
                WHERE Fecha = @Fecha AND Usuario_id = @Usuario_id
            END
            ELSE
            BEGIN
                INSERT INTO TiempoFlowtime (Fecha, TiempoEstudioMinutos, TiempoDescansoMinutos, Usuario_id)
                VALUES (@Fecha, @TiempoEstudioMinutos, @TiempoDescansoMinutos, @Usuario_id)
            END";

                    using (SqlCommand upsertCommand = new SqlCommand(upsertQuery, Connection))
                    {
                        upsertCommand.Parameters.AddWithValue("@Fecha", DateTime.Now.Date);
                        upsertCommand.Parameters.AddWithValue("@TiempoEstudioMinutos", tiempoEstudioMinutos);
                        upsertCommand.Parameters.AddWithValue("@TiempoDescansoMinutos", tiempoDescansoSegundos / 60);
                        upsertCommand.Parameters.AddWithValue("@Usuario_id", Usuario_id);

                        upsertCommand.ExecuteNonQuery(); // Aquí se guarda el tiempo de estudio
                    }

                    ReiniciarCronometro();
                    enDescanso = true;
                    btnTermiar.Text = "Saltar Descanso";
                    MostrarDescanso();
                }
                else if (enDescanso)
                {
                    // Si estamos en descanso y el usuario quiere saltar el descanso
                    TerminarDescanso();
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                MessageBox.Show("Error al guardar el tiempo de estudio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void TerminarDescanso()
        {
            enDescanso = false;
            ReiniciarCronometro();
            btnTermiar.Text = "Terminar Estudio";
            btnFlow.Text = "Iniciar";
            tmrCronometro.Stop();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            TemaColores.Tema(color);
            this.BackColor = TemaColores.fondo;
            panel1.BackColor = TemaColores.opciones;
            panel2.BackColor = TemaColores.opciones;
            plNotas.BackColor = TemaColores.panel;
            btnAgNota.BackColor = TemaColores.panel;
            btnElNota.BackColor = TemaColores.panel;
            listBoxNotas.BackColor = TemaColores.panel;
            btnFlow.FlatAppearance.BorderSize = 0;
            btnTermiar.FlatAppearance.BorderSize = 0;
            btnNotas.FlatAppearance.BorderSize = 0;
            btnAgNota.FlatAppearance.BorderSize = 0;
            btnElNota.FlatAppearance.BorderSize = 0;
            synthesizer = new SpeechSynthesizer();
            this.Opacity = 0.0;
            plNotas.Visible = false;
            MostrarNotasUsuario();
            EntradaFlow.Start();
        }

        private void EntradaFlow_Tick(object sender, EventArgs e)
        {
            int cont = 0;
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
                cont += 1;
            }
            if (cont == 100)
            {
                EntradaFlow.Stop();
            }
        }

        private void SalidaFlow_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                SalidaFlow.Stop();
                InterfazInicial formularioInicial = new InterfazInicial(Connection, Usuario_id);
                this.Close();
                formularioInicial.Show();
            }
        }

        private void LeerMensaje(string mensaje)
        {
            if (synthesizer != null && !synthesizer.State.Equals(SynthesizerState.Speaking))
            {
                synthesizer.SpeakAsync(mensaje);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            cronometroActivo = true;
            cronometroPausado = false;
            tmrCronometro.Start();
           
            pbCarga.Image = Properties.Resources.Load;
        }

        private void btnPausa_Click(object sender, EventArgs e)
        {
            cronometroActivo = false;
            cronometroPausado = true;
            tmrCronometro.Stop();
            
            pbCarga.Image = null;
        }

        private void btnDeten_Click(object sender, EventArgs e)
        {
            pbCarga.Image = null;

            if (cronometroActivo)
            {
                cronometroActivo = false;
                cronometroPausado = false;
                tmrCronometro.Stop();
            }

            TerminarDescanso();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (enDescanso)
            {
                TerminarDescanso();
            }
            else
            {
                cronometroActivo = true;
                tmrCronometro.Start();
              
                pbCarga.Image = Properties.Resources.Load;

                if (Connection.State != ConnectionState.Open)
                {
                    Connection.Open();
                }

                string updateQuery = "UPDATE Cronometro SET TiempoEstudioMinutos = TiempoEstudioMinutos + 1";
                SqlCommand updateCommand = new SqlCommand(updateQuery, Connection);
                updateCommand.ExecuteNonQuery();
            }
        }


        private void ReiniciarCronometro()
        {
            milisegundos = 0;
            segundos = 0;
            minutos = 0;
            lblTimer.Text = "00:00:00";
        }

        private void tmrDescanso_Tick(object sender, EventArgs e)
        {
        }

        private void MostrarTiempoRestante()
        {
            int minutosRestantes = tiempoDescansoSegundos / 60;
            int segundosRestantes = tiempoDescansoSegundos % 60;
            lblTimer.Text = $"{minutosRestantes:00}:{segundosRestantes:00}";
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            plNotas.Visible = !plNotas.Visible;
        }

        private void btnFlow_Click(object sender, EventArgs e)
        {
            iniciado = !iniciado;

            if (iniciado)
            {
                btnFlow.Text = "Pausar";
                tmrCronometro.Start();
                cronometroActivo = true;
            }
            else
            {
                btnFlow.Text = "Reanudar";
                tmrCronometro.Stop();
                cronometroActivo = false;
            }

            if (Connection.State != ConnectionState.Open)
            {
                Connection.Open();
            }

            string updateQuery = "UPDATE Cronometro SET TiempoEstudioMinutos = TiempoEstudioMinutos + 1";
            SqlCommand updateCommand = new SqlCommand(updateQuery, Connection);
            updateCommand.ExecuteNonQuery();
        }

        private void btnAgNota_Click(object sender, EventArgs e)
        {
            listBoxNotas.Items.Add(txtNota.Text);

            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
            Connection.Open();

            string insertQuery = "INSERT INTO Notario (Usuario_id, notas) VALUES (@Usuario_id, @nota)";
            using (SqlCommand command = new SqlCommand(insertQuery, Connection))
            {
                command.Parameters.AddWithValue("@Usuario_id", Usuario_id);
                command.Parameters.AddWithValue("@nota", txtNota.Text);
                txtNota.Clear();
                command.ExecuteNonQuery();
            }
            Connection.Close();
        }

        private void btnElNota_Click(object sender, EventArgs e)
        {

            try
            {
                string notaSeleccionada = listBoxNotas.SelectedItem.ToString();
                listBoxNotas.Items.Remove(notaSeleccionada);
                Connection.Close();
                Connection.Open();

                string deleteQuery = "DELETE FROM Notario WHERE notas = @nota AND Usuario_id = @Usuario_id";

                using (SqlCommand command = new SqlCommand(deleteQuery, Connection))
                {
                    command.Parameters.AddWithValue("@nota", notaSeleccionada);
                    command.Parameters.AddWithValue("@Usuario_id", Usuario_id);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("No se encontró la nota en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la nota: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.Close();
            }
        }

        private void MostrarNotasUsuario()
        {
            string query = "SELECT notas FROM Notario WHERE Usuario_id = @Usuario_id";
            try
            {
                Connection.Close();
                Connection.Open();

                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.AddWithValue("@Usuario_id", Usuario_id);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string nota = reader["notas"].ToString();
                    listBoxNotas.Items.Add(nota);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las notas del usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}



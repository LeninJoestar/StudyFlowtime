using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Data.SqlClient;

namespace FlowTime
{
    public partial class Pomodoro : Form
    {
        string color = Datos.ObtenerValor();

        private SqlConnection Connection;
        private int Usuario_id;
        private SpeechSynthesizer synthesizer;
        private int segundos = 0;
        private int minutos = 25;
        private int minutosLargo= 25;
        private int minutosCorto = 15;
        private bool esLargo = true;
        private bool iniciado = false;
        private bool esDescanso = false;

        public Pomodoro(SqlConnection connection, int usuarioId)
        {
            InitializeComponent();
            this.Connection = connection;
            this.Usuario_id = usuarioId;
            lblTimer2.Text = $"{minutos}:00";
            btnLargo.Enabled = false;
            btnSaltarDescanso.Enabled = false;
            pbCarga.Image = null;
        }

        public void SetUsuarioId(int usuarioId)
        {
            this.Usuario_id = usuarioId;
        }

        private void Pomodoro_Load(object sender, EventArgs e)
        {
            TemaColores.Tema(color);
            this.BackColor = TemaColores.fondo;
            panel1.BackColor = TemaColores.opciones;
            panel2.BackColor = TemaColores.opciones;
            plNotas.BackColor = TemaColores.panel;
            btnAgNota.BackColor = TemaColores.panel;
            btnElNota.BackColor = TemaColores.panel;
            listBoxNotas.BackColor = TemaColores.panel;
            btnPlay.FlatAppearance.BorderSize = 0;
            btnSaltarDescanso.FlatAppearance.BorderSize = 0;
            btnCorto.FlatAppearance.BorderSize = 0;
            btnLargo.FlatAppearance.BorderSize = 0;
            btnNotas.FlatAppearance.BorderSize = 0;
            btnAgNota.FlatAppearance.BorderSize = 0;
            btnElNota.FlatAppearance.BorderSize = 0;
            synthesizer = new SpeechSynthesizer();
            this.Opacity = 0.0;
            plNotas.Visible = false;
            MostrarNotasUsuario();
            EntradaPomo.Start();
        }

        private void tmrTemporizador_Tick(object sender, EventArgs e)
        {
            segundos--;

            lblTimer2.Text = $"{minutos:D2}:{segundos:D2}";

            if (minutos <= 0 && segundos <= 0)
            {
                btnSaltarDescanso.Enabled = true;
                if (!esDescanso)
                    establecerDescanso();
                else
                    establecerEstudio();
                
                tmrTemporizador.Stop();
                lblTimer2.Text = $"{minutos}:00";
                btnPlay.Text = "Reanudar";
                btnLargo.Enabled = true;
                btnCorto.Enabled = true;

                return;
            }

            if (segundos <= 0)
            {
                minutos--;
                segundos = 59;
            }

        }

        private void establecerDescanso()
        {
            // Registro del tiempo de estudio antes de pasar a descanso
            minutos = 5;
            segundos = 1;
            int tiempoEstudio = (25 * 60) - (minutos * 60 + segundos); // Calcular el tiempo de estudio en segundos
            InsertarTiempoPomodoro(DateTime.Now, tiempoEstudio / 60, 0); // Guardar el tiempo de estudio en minutos
            pbCarga.Image = null;
            esDescanso = true;
            iniciado = false;
            
            lblTimer2.Text = $"{minutos:D2}:00";
            //string mensaje = "Es hora de tomar un descanso. Puedes aprovechar estos minutos para tomar agua, relajarte, o hacer" +
            //" cualquier otra actividad para despejar tu mente, antes de regresar a tus labores .";
            //LeerMensaje(mensaje);

        }

        private void establecerEstudio()
        {
            // Registro del tiempo de descanso antes de pasar a estudio
            int tiempoDescanso = (5 * 60) - (minutos * 60 + segundos); // Calcular el tiempo de descanso en segundos
            InsertarTiempoPomodoro(DateTime.Now, 0, tiempoDescanso / 60); // Guardar el tiempo de descanso en minutos

            esDescanso = false;
            iniciado = false;
            minutos = esLargo ? minutosLargo : minutosCorto;
           
            segundos = 0;
            lblTimer2.Text = $"{minutos:D2}:00";

            segundos = 0;
            if (!iniciado)
            {
                btnSaltarDescanso.Enabled = false;
            }
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            SalidaPomo.Start();
        }

        private void LeerMensaje(string mensaje)
        {
            if (synthesizer != null && !synthesizer.State.Equals(SynthesizerState.Speaking))
            {
                synthesizer.SpeakAsync(mensaje);
            }
        }

        private void btnSaltarDescanso_Click(object sender, EventArgs e)
        {
            establecerEstudio();
            btnPlay.Text = "Iniciar";
            tmrTemporizador.Stop();
            btnLargo.Enabled = true;
            btnCorto.Enabled = true;
            //tmrTemporizador.Start();
        }

        private void EntradaPomo_Tick(object sender, EventArgs e)
        {
            int cont = 0;
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
                cont += 1;
            }
            if (cont == 100)
            {
                EntradaPomo.Stop();
            }
        }

        private void SalidaPomo_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                this.Hide();
                SalidaPomo.Stop();
                InterfazInicial principal = new InterfazInicial(Connection, Usuario_id);
                principal.Show();
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            tmrTemporizador.Start();
            
            pbCarga.Image = Properties.Resources.Load;
        }

    
        private void btnPausa_Click(object sender, EventArgs e)
        {
            //pbCarga.Image = null;
            //tmrTemporizador.Stop();
            //btnPlay.Enabled = true;
            //btnPausa.Enabled = false;
            //if (!esDescanso)
            //{
            //    int tiempoEstudio = (25 * 60) - (minutos * 60 + segundos); // Calcular el tiempo de estudio en segundos
            //    InsertarTiempoPomodoro(DateTime.Now, tiempoEstudio / 60, 0); // Guardar el tiempo de estudio en minutos
            //}
            //else
            //{
            //    int tiempoDescanso = (5 * 60) - (minutos * 60 + segundos); // Calcular el tiempo de descanso en segundos
            //    InsertarTiempoPomodoro(DateTime.Now, 0, tiempoDescanso / 60); // Guardar el tiempo de descanso en minutos
            //}
        }

        private void btnInicio_MouseEnter(object sender, EventArgs e)
        {
       
        }

        private void btnInicio_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnPlay_MouseEnter(object sender, EventArgs e)
        {
            btnPlay.Image = Properties.Resources.IconoPlayGris;
        }

        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            btnPlay.Image = Properties.Resources.IconoPlay;
        }

        private void btnPausa_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void btnPausa_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void InsertarTiempoPomodoro(DateTime fecha, int tiempoEstudio, int tiempoDescanso)
        {
            //string connectionString = @"Data Source=LUGASMONITOR\TBD_LENINI;Initial Catalog=FlowTime;Integrated Security=True;";
            string selectQuery = "SELECT COUNT(*) FROM TiempoPomodoro WHERE Fecha = @Fecha AND Usuario_id = @Usuario_id";
            string updateQuery = "UPDATE TiempoPomodoro SET TiempoEstudioMinutos = TiempoEstudioMinutos + @TiempoEstudio, TiempoDescansoMinutos = TiempoDescansoMinutos + @TiempoDescanso WHERE Fecha = @Fecha AND Usuario_id = @Usuario_id";
            string insertQuery = "INSERT INTO TiempoPomodoro (Fecha, TiempoEstudioMinutos, TiempoDescansoMinutos, Usuario_id) VALUES (@Fecha, @TiempoEstudio, @TiempoDescanso, @Usuario_id)";

            try
            {
                Connection.Close();
                Connection.Open();

                SqlCommand selectCommand = new SqlCommand(selectQuery, Connection);
                selectCommand.Parameters.AddWithValue("@Fecha", fecha.Date);
                selectCommand.Parameters.AddWithValue("@Usuario_id", Usuario_id);

                int count = (int)selectCommand.ExecuteScalar();

                if (count > 0)
                {
                    SqlCommand updateCommand = new SqlCommand(updateQuery, Connection);
                    updateCommand.Parameters.AddWithValue("@Fecha", fecha.Date);
                    updateCommand.Parameters.AddWithValue("@TiempoEstudio", tiempoEstudio);
                    updateCommand.Parameters.AddWithValue("@TiempoDescanso", tiempoDescanso);
                    updateCommand.Parameters.AddWithValue("@Usuario_id", Usuario_id);

                    updateCommand.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand insertCommand = new SqlCommand(insertQuery, Connection);
                    insertCommand.Parameters.AddWithValue("@Fecha", fecha.Date);
                    insertCommand.Parameters.AddWithValue("@TiempoEstudio", tiempoEstudio);
                    insertCommand.Parameters.AddWithValue("@TiempoDescanso", tiempoDescanso);
                    insertCommand.Parameters.AddWithValue("@Usuario_id", Usuario_id);

                    insertCommand.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar o actualizar datos en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            plNotas.Visible = !plNotas.Visible;
        }

        private void btnLargo_Click(object sender, EventArgs e)
        {
            
            esLargo = true;
            establecerEstudio();
            btnLargo.Enabled = false;
            btnCorto.Enabled=true; 
            



        }

        private void btnCorto_Click(object sender, EventArgs e)
        {
            
            esLargo = false;
            establecerEstudio();
            btnCorto.Enabled = false;
            btnLargo.Enabled =true;
           


        }

        private void btnPlay_Click_1(object sender, EventArgs e)
        {
            

            if (!iniciado)
            {
                iniciado = !iniciado;
                btnPlay.Text = "Pausar";
                btnLargo.Enabled=false;
                btnCorto.Enabled = false;
                tmrTemporizador.Start();
            }
            else
            {
                pbCarga.Image = null;
                tmrTemporizador.Stop();
                iniciado = !iniciado;
                btnPlay.Text = "Iniciar";

          
                if (!esDescanso)
                {
                    int tiempoEstudio = (25 * 60) - (minutos * 60 + segundos); // Calcular el tiempo de estudio en segundos
                    InsertarTiempoPomodoro(DateTime.Now, tiempoEstudio / 60, 0); // Guardar el tiempo de estudio en minutos
                }
                else
                {
                    int tiempoDescanso = (5 * 60) - (minutos * 60 + segundos); // Calcular el tiempo de descanso en segundos
                    InsertarTiempoPomodoro(DateTime.Now, 0, tiempoDescanso / 60); // Guardar el tiempo de descanso en minutos
                }
               
            }
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
            string notaSeleccionada = listBoxNotas.SelectedItem.ToString();
            listBoxNotas.Items.Remove(notaSeleccionada);

            try
            {
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

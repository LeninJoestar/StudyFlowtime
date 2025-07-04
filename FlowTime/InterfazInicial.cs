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
    public partial class InterfazInicial : Form
    {
        string color = Datos.ObtenerValor();

        bool flpOpcionesExpand = false;
        private SqlConnection Connection;
        private int Usuario_id;

        public InterfazInicial(SqlConnection connection, int usuarioId)
        {
            InitializeComponent();
            this.Connection = connection;
            this.Usuario_id = usuarioId;
        }

        public InterfazInicial()
        {
            InitializeComponent();

            this.Usuario_id = 0;
        }
        public void SetUsuarioId(int usuarioId)
        {
            this.Usuario_id = usuarioId;
        }

        private void InterfazInicial_Load(object sender, EventArgs e)
        {
            if(color != null)
            {
                TemaColores.Tema(color);
                this.BackColor = TemaColores.fondo;
                plOpciones.BackColor = TemaColores.opciones;
                plTemas.BackColor = TemaColores.panel;
            }
            plTemas.Visible = false;
            btnTutorial.Location = new Point(0, 199); 
            btnCerrarSesion.Location = new Point(0, 312);
            btnEmocional.FlatAppearance.BorderSize = 0;
            btnEstadisticas.FlatAppearance.BorderSize = 0;
            btnConfiguracion.FlatAppearance.BorderSize = 0;
            btnTutorial.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnFlowTime.FlatAppearance.BorderSize = 0;
            btnPomodoro.FlatAppearance.BorderSize = 0;
            plOpciones.Width = 0;
            this.Opacity = 0.0;
            Entrada.Start();
        }

        private void MostrarTemas()
        {
            if (plTemas.Visible == false)
            {
                plTemas.Visible = true;
            }
            else if (plTemas.Visible == true)
            {
                plTemas.Visible = false;
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Se hará una evaluación de ánimo antes de retirarte", "Cerrar Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                DateTime fechaCierreSesion = DateTime.Now;
                int usuarioId = ObtenerIdUsuarioActual();

                if (usuarioId != 0)
                {
                    // Abre la conexión si está cerrada
                    if (Connection.State == ConnectionState.Closed)
                    {
                        Connection.Open();
                    }

                    string updateQuery = "UPDATE RegistroSesiones SET FechaFin = @FechaFin WHERE Usuario_id = @Usuario_id AND FechaFin IS NULL";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, Connection))
                    {
                        updateCommand.Parameters.AddWithValue("@FechaFin", fechaCierreSesion);
                        updateCommand.Parameters.AddWithValue("@Usuario_id", usuarioId);
                        int rowsAffected = updateCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // MessageBox.Show("Sesión cerrada exitosamente.");
                            estadosDeAnimo estadosDeAnimo = new estadosDeAnimo(Connection, usuarioId);
                            estadosDeAnimo.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo cerrar sesión. No hay sesión activa.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el ID de usuario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cierra la conexión si está abierta
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }
        private int ObtenerIdUsuarioActual()
        {

            return Usuario_id;
        }

        private void btnEstadisticas_MouseEnter(object sender, EventArgs e)
        {
            btnEstadisticas.ForeColor = Color.Black;
        }

        private void btnEstadisticas_MouseLeave(object sender, EventArgs e)
        {
            btnEstadisticas.ForeColor = Color.White;
        }

        private void btnConfiguracion_MouseEnter(object sender, EventArgs e)
        {
            btnConfiguracion.ForeColor = Color.Black;
        }
        private void btnConfiguracion_MouseLeave(object sender, EventArgs e)
        {
            btnConfiguracion.ForeColor = Color.White;
        }

        private void btnTutorial_MouseEnter(object sender, EventArgs e)
        {
            btnTutorial.ForeColor = Color.Black;
        }

        private void btnTutorial_MouseLeave(object sender, EventArgs e)
        {
            btnTutorial.ForeColor = Color.White;
        }

        private void btnCerrarSesion_MouseEnter(object sender, EventArgs e)
        {
            btnCerrarSesion.ForeColor = Color.Black;
        }

        private void btnCerrarSesion_MouseLeave(object sender, EventArgs e)
        {
            btnCerrarSesion.ForeColor = Color.White;
        }
        private void btnEmocional_MouseEnter(object sender, EventArgs e)
        {
            btnEmocional.ForeColor = Color.Black;
        }

        private void btnEmocional_MouseLeave(object sender, EventArgs e)
        {
            btnEmocional.ForeColor = Color.White;
        }

        private void Entrada_Tick(object sender, EventArgs e)
        {
            int cont = 0;
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
                cont += 1;
            }
            if(cont == 100)
            {
                Entrada.Stop();
            }
        }

        private void btnPomodoro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pomodoro Pomodin = new Pomodoro(Connection, Usuario_id);
            Pomodin.Show();
        }

        private void Salida_Tick(object sender, EventArgs e, SqlConnection connection)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                this.Hide();
                Salida.Stop();
                Inicio flowtime = new Inicio(connection, Usuario_id);
                flowtime.Show();
            }
        }

        private void Salida2_Tick(object sender, EventArgs e, SqlConnection connection)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                this.Hide();
                Salida2.Stop();
                Pomodoro pomodoes = new Pomodoro(connection, Usuario_id);
                pomodoes.Show();
            }
        }

        private void btnOpciones_Click(object sender, EventArgs e)
        {
            tmrBarraOpcionesTransicion.Start();
        }

        private void tmrBarraOpcionesTransicion_Tick(object sender, EventArgs e)
        {
            if(flpOpcionesExpand)
            {
                plOpciones.Width -= 10;
                if(plOpciones.Width <= 0)
                {
                    flpOpcionesExpand = false;
                    tmrBarraOpcionesTransicion.Stop();
                }
            }
            else
            {
                plOpciones.Width += 10;
                if(plOpciones.Width >= 210)
                {
                    flpOpcionesExpand = true;
                    tmrBarraOpcionesTransicion.Stop();
                }
            }
        }

        private void SalidaEstadisticas_Tick(object sender, EventArgs e, SqlConnection connection)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                this.Hide();
                SalidaEstadisticas.Stop();
                Estadisticas stadistic = new Estadisticas(connection, Usuario_id);
                stadistic.Show();
            }
        }
        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Estadisticas estadisticas = new Estadisticas(Connection, Usuario_id);
            estadisticas.Show();
        }

        private void btnTutorial_Click(object sender, EventArgs e)
        {
            Tutorial leccion = new Tutorial(Connection, Usuario_id);
            leccion.Show();
        }

        private void btnEmocional_Click(object sender, EventArgs e)
        {
            calendarioAnimo animo = new calendarioAnimo(Connection, Usuario_id);
            animo.Show();
        }

        private void btnFlowTime_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio formularioPrincipal = new Inicio(Connection, Usuario_id);
            formularioPrincipal.Show();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            MostrarTemas();
        }

        private void btnVerde_MouseEnter(object sender, EventArgs e)
        {
            btnVerde.Image = Properties.Resources.CirculoBlanco;
        }
        private void btnVerde_MouseLeave(object sender, EventArgs e)
        {
            btnVerde.Image = Properties.Resources.CirculoVerde;
        }

        private void btnRojo_MouseEnter(object sender, EventArgs e)
        {
            btnRojo.Image = Properties.Resources.CirculoBlanco;
        }

        private void btnRojo_MouseLeave(object sender, EventArgs e)
        {
            btnRojo.Image = Properties.Resources.CirculoRojo;
        }

        private void btnAzul_MouseEnter(object sender, EventArgs e)
        {
            btnAzul.Image = Properties.Resources.CirculoBlanco;
        }

        private void btnAzul_MouseLeave(object sender, EventArgs e)
        {
            btnAzul.Image = Properties.Resources.CirculoAzul;
        }

        private void btnAmarillo_MouseEnter(object sender, EventArgs e)
        {
            btnAmarillo.Image = Properties.Resources.CirculoBlanco;
        }

        private void btnAmarillo_MouseLeave(object sender, EventArgs e)
        {
            btnAmarillo.Image = Properties.Resources.CirculoAmarillo;
        }
        private void btnDefecto_MouseEnter(object sender, EventArgs e)
        {
            btnDefecto.Image = Properties.Resources.CirculoBlanco;

        }

        private void btnDefecto_MouseLeave(object sender, EventArgs e)
        {
            btnDefecto.Image = Properties.Resources.CirculoDefecto;

        }

        private void btnVerde_Click(object sender, EventArgs e)
        {
            TemaColores.Tema("V");
            this.BackColor = TemaColores.fondo;
            plOpciones.BackColor = TemaColores.opciones;
            plTemas.BackColor = TemaColores.panel;
            string color = "V";
            Datos.GuardarValor(color);
        }

        private void btnRojo_Click(object sender, EventArgs e)
        {
            TemaColores.Tema("R");
            this.BackColor = TemaColores.fondo;
            plOpciones.BackColor = TemaColores.opciones;
            plTemas.BackColor = TemaColores.panel;
            string color = "R";
            Datos.GuardarValor(color);
        }

        private void btnAzul_Click(object sender, EventArgs e)
        {
            TemaColores.Tema("A");
            this.BackColor = TemaColores.fondo;
            plOpciones.BackColor = TemaColores.opciones;
            plTemas.BackColor = TemaColores.panel;
            string color = "A";
            Datos.GuardarValor(color);
        }

        private void btnAmarillo_Click(object sender, EventArgs e)
        {
            TemaColores.Tema("AM");
            this.BackColor = TemaColores.fondo;
            plOpciones.BackColor = TemaColores.opciones;
            plTemas.BackColor = TemaColores.panel;
            string color = "AM";
            Datos.GuardarValor(color);
        }

        private void btnDefecto_Click(object sender, EventArgs e)
        {
            TemaColores.Tema("D");
            this.BackColor = TemaColores.fondo;
            plOpciones.BackColor = TemaColores.opciones;
            plTemas.BackColor = TemaColores.panel;
            string color = "D";
            Datos.GuardarValor(color);
        }

        private void InterfazInicial_Click(object sender, EventArgs e)
        {
            if (plOpciones.Width == 210)
            {
                tmrBarraOpcionesTransicion.Start();
            }
        }
    }
}
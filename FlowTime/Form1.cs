using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace FlowTime
{
    public partial class frmInicioSesion : Form
    {

        public static int UsuarioId { get; private set; }
        private SqlConnection Connection;
        //private const string CadenaConexión = @"Data Source = LUGASMONITOR\TBD_LENINI; Initial Catalog = FlowTime; Integrated Security = True;";


        public frmInicioSesion(SqlConnection connection)
        {
            InitializeComponent();
            this.Connection = connection;
            gbregistrarse.TabStop = false;
            gbregistrarse.FlatStyle = FlatStyle.Flat;
            gbregistrarse.BackColor = this.BackColor;
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            // Definir el radio de los bordes redondeados
            int radius = 20;
            // Crear un GraphicsPath para el botón
            GraphicsPath buttonPath = new GraphicsPath();

            // Añadir un rectángulo con bordes redondeados en el lado izquierdo al GraphicsPath
            buttonPath.AddArc(0, 0, radius, radius, 180, 90); // Esquina superior izquierda
            buttonPath.AddLine(radius, 0, btnInicio.Width, 0); // Borde superior
            buttonPath.AddLine(btnInicio.Width, 0, btnInicio.Width, btnInicio.Height); // Borde derecho
            buttonPath.AddLine(btnInicio.Width, btnInicio.Height, radius, btnInicio.Height); // Borde inferior
            buttonPath.AddArc(0, btnInicio.Height - radius, radius, radius, 90, 90); // Esquina inferior izquierda
            buttonPath.CloseFigure();

            // Asignar la región del botón al GraphicsPath creado
            btnInicio.Region = new Region(buttonPath);
        }
        private void button2_Paint(object sender, PaintEventArgs e)
        {
            // Definir el radio de los bordes redondeados
            int radius = 20;
            // Crear un GraphicsPath para el botón
            GraphicsPath buttonPath = new GraphicsPath();

            // Añadir un rectángulo con bordes redondeados en el lado derecho al GraphicsPath
            buttonPath.AddLine(0, 0, btnregirtarse.Width - radius, 0); // Borde superior
            buttonPath.AddArc(btnregirtarse.Width - radius, 0, radius, radius, 270, 90); // Esquina superior derecha
            buttonPath.AddLine(btnregirtarse.Width, radius, btnregirtarse.Width, btnregirtarse.Height - radius); // Borde derecho
            buttonPath.AddArc(btnregirtarse.Width - radius, btnregirtarse.Height - radius, radius, radius, 0, 90); // Esquina inferior derecha
            buttonPath.AddLine(btnregirtarse.Width - radius, btnregirtarse.Height, 0, btnregirtarse.Height); // Borde inferior
            buttonPath.CloseFigure();

            // Asignar la región del botón al GraphicsPath creado
            btnregirtarse.Region = new Region(buttonPath);
        }

        private void gbregistrarse_Paint(object sender, PaintEventArgs e)
        {
            System.Windows.Forms.GroupBox groupBox = sender as System.Windows.Forms.GroupBox;
            ControlPaint.DrawBorder(e.Graphics, groupBox.ClientRectangle, Color.Transparent, ButtonBorderStyle.None);
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            try
            {
                string query = "SELECT Usuario_id FROM Usuarios WHERE NombreUsuario COLLATE Latin1_General_CS_AS = @Usuario AND Contrasena COLLATE Latin1_General_CS_AS = @Contraseña";
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.AddWithValue("@Usuario", nombreUsuario);
                command.Parameters.AddWithValue("@Contraseña", contraseña);
                int usuarioId = Convert.ToInt32(command.ExecuteScalar());

                if (usuarioId != 0)
                {
                    DateTime fechaInicioSesion = DateTime.Now;


                    string insertQuery = "INSERT INTO RegistroSesiones (Usuario_id, FechaInicio) VALUES (@Usuario_id, @FechaInicio)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, Connection);
                    insertCommand.Parameters.AddWithValue("@Usuario_id", usuarioId);
                    insertCommand.Parameters.AddWithValue("@FechaInicio", fechaInicioSesion);
                    UsuarioId = usuarioId;
                    insertCommand.ExecuteNonQuery();



                    this.Hide();
                    InterfazInicial formularioInicial = new InterfazInicial(Connection, usuarioId);
                    formularioInicial.Show();
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LimpiarCampos()
        {
            txtContrasenaNueva.Text = "";
            txtNombre.Text = "";
            txtUsuarioNuevo.Text = "";
        }

        private void pbMostrar_Click(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = '\0'; // Mostrar la contraseña
            pbMostrar.Visible = false; // Ocultar el PictureBox de mostrar
            pbOcultar.Visible = true; // Mostrar el PictureBox de ocultar
        }

        private void pbOcultar_Click(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = '*'; // Ocultar la contraseña
            pbMostrar.Visible = true; // Mostrar el PictureBox de mostrar
            pbOcultar.Visible = false; // Ocultar el PictureBox de ocultar
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = '*';
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
            // Asigna el evento Paint del botón
            btnregirtarse.Paint += new PaintEventHandler(button2_Paint);
            btnInicio.Paint += new PaintEventHandler(button1_Paint);
        }

        private void Desvanecido_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if(this.Opacity == 0)
            {
                Desvanecido.Stop();
                this.Hide();
                InterfazInicial formularioPrincipal = new InterfazInicial();
                formularioPrincipal.Show();
            }
        }

        private void btnregirtarse_Click(object sender, EventArgs e)
        {
            gbregistrarse.Visible = true;
            gbInicio.Visible = false;    


        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            gbregistrarse.Visible = false;
            gbInicio.Visible = true;
        }

        private void btnregirtarse_DragOver(object sender, DragEventArgs e)
        {
            btnregirtarse.BackColor = Color.FromArgb(51, 194, 178);
        }

        private void btnregirtarse_Paint(object sender, PaintEventArgs e)
        {
         
         
            }

        private void btnRegistrarNuevo_Click(object sender, EventArgs e)
        {
            string NombreCompleto = txtNombre.Text;
            string NombreUsuario = txtUsuarioNuevo.Text;
            string Contrasena = txtContrasenaNueva.Text;


            if (string.IsNullOrWhiteSpace(NombreCompleto) || string.IsNullOrWhiteSpace(NombreUsuario) || string.IsNullOrWhiteSpace(Contrasena))
            {
                MessageBox.Show("Llenado incompleto. Se deben llenar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
         

                    string query = "INSERT INTO Usuarios (NombreCompleto, NombreUsuario, Contrasena) VALUES (@NombreCompleto, @NombreUsuario, @Contrasena)";
                    SqlCommand command = new SqlCommand(query, Connection);

                    command.Parameters.AddWithValue("@NombreCompleto", NombreCompleto);
                    command.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
                    command.Parameters.AddWithValue("@Contrasena", Contrasena);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("¡Usuario registrado correctamente!");
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar nuevo usuario.");
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("¡Ups! Hubo un error al intentar agregar un nuevo usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

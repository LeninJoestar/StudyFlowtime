using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace FlowTime
{
    public partial class estadosDeAnimo : Form
    {
        string color = Datos.ObtenerValor();
        private int Usuario_id;

        //private const string CadenaConexión = @"Data Source =LUGASMONITOR\TBD_LENINI; Initial Catalog = flowtime; Integrated Security = True;";
        private List<Button> estadoDeAnimo;
        private Dictionary<string, Image> moodImages;
        private SqlConnection Connection;

        public estadosDeAnimo(SqlConnection connection, int usuarioId)
        {
            InitializeComponent();
            InitializeMoodButtons();
            InitializeMoodImages();
            this.Usuario_id = usuarioId;
            this.Connection = connection;
        }

        private void InitializeMoodButtons()
        {

            estadoDeAnimo = new List<Button>();

            foreach (Control control in flpEstados.Controls)
            {
                if (control is Button button)
                {
                    estadoDeAnimo.Add(button);
                    button.Click += MoodButton_Click;
                    button.BackColor = Color.LightGray;
                 
                    switch (button.Name)
                    {
                        case "btnFeliz":
                            button.Tag = "Feliz";
                            break;
                        case "btnTriste":
                            button.Tag = "Triste";
                            break;
                        case "btnEnojado":
                            button.Tag = "Enojado";
                            break;
                        case "btnNeutral":
                            button.Tag = "Neutral";
                            break;
                    }
                }
            }
        }

        private void InitializeMoodImages()
        {
            moodImages = new Dictionary<string, Image>
            {
                { "Feliz", Properties.Resources.feliz_3_},
                { "Triste", Properties.Resources.triste_2_ },
                { "Enojado", Properties.Resources.cara_enojada },
                { "Neutral", Properties.Resources.neutral_1_ }
            };
        }

        private void MoodButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton.BackColor == Color.LightGray)
            {
                clickedButton.BackColor = Color.LightBlue;
            }
            else
            {
                clickedButton.BackColor = Color.LightGray;
            }
        }


        private void estadosDeAnimo_Load(object sender, EventArgs e)
        {
            TemaColores.Tema(color);
            this.BackColor = TemaColores.fondo;
        }

        private string obtenerEstadosSeleccionados()
        {
            List<string> moods = new List<string>();

            foreach (Button button in estadoDeAnimo)
            {
                if (button.BackColor == Color.LightBlue)
                {
                    moods.Add(button.Tag.ToString());
                }
            }

            return string.Join(",", moods);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string selectedMoods = obtenerEstadosSeleccionados();

            if (string.IsNullOrEmpty(selectedMoods))
            {
                MessageBox.Show("Por favor, selecciona al menos un estado de ánimo.");
                return;
            }

            DateTime date = dtpFecha.Value.Date;
            Connection.Close();
            Connection.Open();

            string query = "INSERT INTO EstadosDeAnimo (Usuario_id, Estados, Fecha) VALUES (@Usuario_id, @Estados, @Fecha)";
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.AddWithValue("@Usuario_id", Usuario_id);
                command.Parameters.AddWithValue("@Estados", selectedMoods);
                command.Parameters.AddWithValue("@Fecha", date);

                command.ExecuteNonQuery();
            
    
            foreach (Button button in estadoDeAnimo)
            {
                button.BackColor = Color.LightGray;
            }
        
            foreach (Button button in estadoDeAnimo)
            {
                button.BackColor = Color.LightGray;
            }
            this.Close();
            frmInicioSesion inicio = new frmInicioSesion(Connection);
            inicio.Show();
        }
    }
}
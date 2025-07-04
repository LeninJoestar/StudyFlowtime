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
    public partial class calendarioAnimo : Form
    {
        string color = Datos.ObtenerValor();

        private int Usuario_Id;
        private SqlConnection Connection;

        public calendarioAnimo(SqlConnection connection, int usuarioId )
        {
            InitializeComponent();
            InitializeMoodImages();
            this.Usuario_Id = usuarioId;
            this.Connection = connection;
            LoadMoodData();
        }
        private Dictionary<string, Image> moodImages;


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

        private void LoadMoodData()
        {
            mcResumen.RemoveAllBoldedDates();

            Connection.Close();
            Connection.Open();
            string query = "SELECT Fecha FROM EstadosDeAnimo WHERE Usuario_id = @Usuario_id";
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.AddWithValue("@Usuario_id", Usuario_Id);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    DateTime date = reader.GetDateTime(0);
                    mcResumen.AddBoldedDate(date);
                }
                mcResumen.UpdateBoldedDates();
            
        }

   

        private void DisplayMoodImages(string estados)
        {
            flpEstadosSeleccionados.Controls.Clear();
            string[] moodList = estados.Split(',');

            foreach (string mood in moodList)
            {
                if (moodImages.ContainsKey(mood))
                {
                    PictureBox pictureBox = new PictureBox
                    {
                        Image = moodImages[mood],
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Width = 50,
                        Height = 50
                    };
                    flpEstadosSeleccionados.Controls.Add(pictureBox);
                }
            }
        }

        private void mcResumen_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start;
                Connection.Close();
                Connection.Open();
   
                string query = "SELECT Estados FROM EstadosDeAnimo WHERE Usuario_id = @Usuario_id AND Fecha = @Fecha";
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.AddWithValue("@Usuario_id", Usuario_Id);
                command.Parameters.AddWithValue("@Fecha", selectedDate);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string estados = reader.GetString(0);
                    DisplayMoodImages(estados);
                    txtEstadosSeleccionados.Text = $"Estados de ánimo para {selectedDate.ToShortDateString()}:";
                }
                else
                {
                    txtEstadosSeleccionados.Text = $"No hay estados de ánimo registrados";
                    flpEstadosSeleccionados.Controls.Clear();
                }
            
        }

        private void calendarioAnimo_Load(object sender, EventArgs e)
        {
            TemaColores.Tema(color);
            this.BackColor = TemaColores.fondo;
        }
    }
}

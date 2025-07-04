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
using System.Windows.Forms.DataVisualization.Charting;

namespace FlowTime
{
    public partial class Estadisticas : Form
    {
        string color = Datos.ObtenerValor();

        private int usuarioId;
        private SqlConnection connection;

        public Estadisticas(SqlConnection connection, int usuarioId)
        {
            InitializeComponent();
            this.connection = connection;
            this.usuarioId = usuarioId;
            InitChart();
            InitChartPomodoro();
            InitChartFlowtime();
        }

        private void InitChart()
        {
            Series inicioSeries = new Series("Inicio de sesión");
            Series finSeries = new Series("Fin de sesión");
            Series duracionSeries = new Series("Duración de sesión");


            inicioSeries.ChartType = SeriesChartType.Point;
            finSeries.ChartType = SeriesChartType.Point;
            duracionSeries.ChartType = SeriesChartType.Column;


            try
            {
                string connectionString = @"Data Source=LUGASMONITOR\TBD_LENINI;Initial Catalog=FlowTime;Integrated Security=True;";
                string query = "SELECT FechaInicio, FechaFin, DATEDIFF(MINUTE, FechaInicio, FechaFin) AS DuracionMinutos FROM RegistroSesiones WHERE Usuario_id = @Usuario_id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);


                    command.Parameters.AddWithValue("@Usuario_id", usuarioId);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        DateTime? fechaInicio = reader.IsDBNull(0) ? (DateTime?)null : reader.GetDateTime(0);

                        DateTime? fechaFin = reader.IsDBNull(1) ? (DateTime?)null : reader.GetDateTime(1);

                        int? duracion = reader.IsDBNull(2) ? (int?)null : reader.GetInt32(2);


                        if (fechaInicio != null)
                        {
                            chrtEstadisticas.Series["Inicio de sesión"].Points.AddXY(fechaInicio.Value.ToShortDateString(), 1);
                        }
                        if (fechaFin != null)
                        {
                            chrtEstadisticas.Series["Fin de sesión"].Points.AddXY(fechaFin.Value.ToShortDateString(), 1);
                        }
                        if (duracion != null && fechaInicio != null)
                        {
                            chrtEstadisticas.Series["Duración de sesión"].Points.AddXY(fechaInicio.Value.ToShortDateString(), duracion.Value);
                        }
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recuperar datos de la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitChartPomodoro()
        {
            string connectionString = @"Data Source=LUGASMONITOR\TBD_LENINI;Initial Catalog=FlowTime;Integrated Security=True;";
            string query = "SELECT Fecha, TiempoEstudioMinutos, TiempoDescansoMinutos FROM TiempoPomodoro WHERE Usuario_id = @Usuario_id";

            Series TiempoEstudiado = new Series("Tiempo estudiado acumulado");
            Series TiempoDescanso = new Series("Tiempo descanso acumulado");

            TiempoEstudiado.ChartType = SeriesChartType.Area;
            TiempoDescanso.ChartType = SeriesChartType.Area;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Usuario_id", usuarioId);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        DateTime fecha = reader.GetDateTime(0);
                        int tiempoEstudio = reader.GetInt32(1);
                        int tiempoDescanso = reader.GetInt32(2);

                        TiempoEstudiado.Points.AddXY(fecha.ToShortDateString(), tiempoEstudio);
                        TiempoDescanso.Points.AddXY(fecha.ToShortDateString(), tiempoDescanso);
                    }

                    reader.Close();
                }

                chrtPomodoro.Series.Clear();
                chrtPomodoro.Series.Add(TiempoEstudiado);
                chrtPomodoro.Series.Add(TiempoDescanso);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recuperar datos de la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitChartPomodoroMes()
        {
            string connectionString = @"Data Source=LUGASMONITOR\TBD_LENINI;Initial Catalog=FlowTime;Integrated Security=True;";
            string query = @"
        SELECT 
            YEAR(Fecha) AS Anio, 
            MONTH(Fecha) AS Mes, 
            SUM(TiempoEstudioMinutos) AS TiempoEstudio, 
            SUM(TiempoDescansoMinutos) AS TiempoDescanso 
        FROM 
            TiempoPomodoro 
        WHERE 
            Usuario_id = @Usuario_id 
            AND Fecha >= DATEADD(MONTH, -5, GETDATE())
        GROUP BY 
            YEAR(Fecha), 
            MONTH(Fecha)
        ORDER BY 
            Anio, 
            Mes";

            Series TiempoEstudiado = new Series("Tiempo estudiado acumulado");
            Series TiempoDescanso = new Series("Tiempo descanso acumulado");

            TiempoEstudiado.ChartType = SeriesChartType.StackedColumn;
            TiempoDescanso.ChartType = SeriesChartType.StackedColumn;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Usuario_id", usuarioId);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int anio = reader.GetInt32(0);
                        int mes = reader.GetInt32(1);
                        int tiempoEstudio = reader.GetInt32(2);
                        int tiempoDescanso = reader.GetInt32(3);

                        DateTime fecha = new DateTime(anio, mes, 1);

                        TiempoEstudiado.Points.AddXY(fecha.ToString("yyyy-MM"), tiempoEstudio);
                        TiempoDescanso.Points.AddXY(fecha.ToString("yyyy-MM"), tiempoDescanso);
                    }

                    reader.Close();
                }

                chrtPomodoroMes.Series.Clear();
                chrtPomodoroMes.Series.Add(TiempoEstudiado);
                chrtPomodoroMes.Series.Add(TiempoDescanso);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recuperar datos de la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitChartFlowtime()
        {
            string connectionString = @"Data Source=LUGASMONITOR\TBD_LENINI;Initial Catalog=FlowTime;Integrated Security=True;";
            string query = "SELECT Fecha, TiempoEstudioMinutos, TiempoDescansoMinutos FROM TiempoFlowtime WHERE Usuario_id = @Usuario_id";

            Series TiempoEstudiado = new Series("Tiempo estudiado acumulado");
            Series TiempoDescanso = new Series("Tiempo descanso acumulado");

            TiempoEstudiado.ChartType = SeriesChartType.Area;
            TiempoDescanso.ChartType = SeriesChartType.Area;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Usuario_id", usuarioId);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        DateTime fecha = reader.GetDateTime(0);
                        int tiempoEstudio = reader.GetInt32(1);
                        int tiempoDescanso = reader.GetInt32(2);

                        TiempoEstudiado.Points.AddXY(fecha.ToShortDateString(), tiempoEstudio);
                        TiempoDescanso.Points.AddXY(fecha.ToShortDateString(), tiempoDescanso);
                    }

                    reader.Close();
                }

                chrtFlowtime.Series.Clear();
                chrtFlowtime.Series.Add(TiempoEstudiado);
                chrtFlowtime.Series.Add(TiempoDescanso);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recuperar datos de la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitChartFlowtimeMes()
        {
            string connectionString = @"Data Source=LUGASMONITOR\TBD_LENINI;Initial Catalog=FlowTime;Integrated Security=True;";
            string query = @"
        SELECT 
            YEAR(Fecha) AS Anio, 
            MONTH(Fecha) AS Mes, 
            SUM(TiempoEstudioMinutos) AS TiempoEstudio, 
            SUM(TiempoDescansoMinutos) AS TiempoDescanso 
        FROM 
            TiempoFlowtime
        WHERE 
            Usuario_id = @Usuario_id 
            AND Fecha >= DATEADD(MONTH, -5, GETDATE())
        GROUP BY 
            YEAR(Fecha), 
            MONTH(Fecha)
        ORDER BY 
            Anio, 
            Mes";

            Series TiempoEstudiado = new Series("Tiempo estudiado acumulado");
            Series TiempoDescanso = new Series("Tiempo descanso acumulado");

            TiempoEstudiado.ChartType = SeriesChartType.StackedColumn;
            TiempoDescanso.ChartType = SeriesChartType.StackedColumn;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Usuario_id", usuarioId);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int anio = reader.GetInt32(0);
                        int mes = reader.GetInt32(1);
                        int tiempoEstudio = reader.GetInt32(2);
                        int tiempoDescanso = reader.GetInt32(3);

                        DateTime fecha = new DateTime(anio, mes, 1);

                        TiempoEstudiado.Points.AddXY(fecha.ToString("yyyy-MM"), tiempoEstudio);
                        TiempoDescanso.Points.AddXY(fecha.ToString("yyyy-MM"), tiempoDescanso);
                    }

                    reader.Close();
                }

                chrtFlowtimeMes.Series.Clear();
                chrtFlowtimeMes.Series.Add(TiempoEstudiado);
                chrtFlowtimeMes.Series.Add(TiempoDescanso);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recuperar datos de la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            {
                InterfazInicial formularioInicial = new InterfazInicial(connection, usuarioId);
                this.Close();
                formularioInicial.Show();
            }
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            TemaColores.Tema(color);
            InitChartPomodoroMes();
            InitChartFlowtimeMes();
            this.BackColor = TemaColores.fondo;
            chrtEstadisticas.BackColor = TemaColores.fondo;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowTime
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string CadenaConexión = @"Data Source=LUGASMONITOR\TBD_LENINI;Initial Catalog=FlowTime;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(CadenaConexión);

            try
            {
                connection.Open();
                Application.Run(new frmInicioSesion(connection));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la conexión: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

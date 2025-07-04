using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FlowTime
{
   
    internal class Datos
    {
        private string CadenaConexión = @"Data Source=LUGASMONITOR\TBD_LENINI;Initial Catalog=FlowTime;Integrated Security=True;";
        public bool ValidarCredenciales(string usuario, string contrasena)
        {
            bool credencialesValidas = false;

           
            string query = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @Usuario AND Contrasena = @Contrasena";

            using (SqlConnection conexion = new SqlConnection(CadenaConexión))
            {
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Usuario", usuario);
                    comando.Parameters.AddWithValue("@Contrasena", contrasena);

                    try
                    {
                        conexion.Open();
                        int count = (int)comando.ExecuteScalar();
                        if (count > 0)
                        {
                            
                            credencialesValidas = true;
                        }
                    }
                    catch (Exception ex)
                    {
                       
                        Console.WriteLine("Error al validar las credenciales: " + ex.Message);
                    }
                }
            }

            return credencialesValidas;
        }

        public void AltaUsuarios(string NombreCompleto, string NombreUsuario, string Contrasena)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(CadenaConexión))
                {
                    connection.Open();
                    string query = "INSERT INTO Usuarios (NombreCompleto, NombreUsuario, Contrasena) VALUES (@NombreCompleto, @NombreUsuario, @Contrasena)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NombreCompleto", NombreCompleto);
                    command.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
                    command.Parameters.AddWithValue("@Contrasena", Contrasena);
                    
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al dar de alta al nuevo usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string valorCompartido;

        public static void GuardarValor(string valor)
        {
            valorCompartido = valor;
        }

        public static string ObtenerValor()
        {
            return valorCompartido;
        }
    }
}

using Microsoft.Data.SqlClient;

namespace SwBiblioteca.Datos
{
    public class Conexion
    {
        private string cadenaConexion =
            "Server=DESKTOP-88U9IKU;Database=Biblioteca;Integrated Security=True;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}

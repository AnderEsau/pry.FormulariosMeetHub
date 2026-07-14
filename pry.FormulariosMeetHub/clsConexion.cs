using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace pry.FormulariosMeetHub
{
    internal class clsConexion
    {
        //Atributos o datos de conexión a la base de datos
        private string host = "189.240.192.140";
        private string bd = "equipo4gb_meethub";
        private string usuario = "usuario4GB";
        private string password = "equipo4gb";
        private string puerto = "3306";

        //Cadena de conexión a la base de datos donde se susituyen los valores de los atributos
        private string cadenaConexion => $"server={host};database={bd};user={usuario};password={password};port={puerto};";

        //Metodo para abrir la conexión a la base de datos
        public MySqlConnection AbrirConexion()
        {
            var conexion = new MySqlConnection(cadenaConexion);
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar conectarse a la base de datos: " + ex.Message, ex);

            }
        }
    }
}

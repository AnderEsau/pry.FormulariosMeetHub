using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pry.FormulariosMeetHub
{
    internal class clsReservaciones
    {
        //Usamos un adaptador
        private MySqlDataAdapter consulta;


        // Método para cargar la lista de salas en el ComboBox
        public DataTable CargarSalas()
        {
            DataTable dtSalas = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    // Agregamos la columna 'descripcion'
                    string sql = "SELECT id_sala, nombre_sala, descripcion " +
                                 "FROM tblsalas;";

                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(dtSalas);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar las salas: " + ex.Message);
            }
            return dtSalas;
        }
    }
}

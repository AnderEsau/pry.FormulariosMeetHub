using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pry.FormulariosMeetHub
{
    internal class clsSalas
    {

        private int idSala; // Este atributo es para referencia en update y delete
        private string nombreSala;
        private string descripcion;
        private int capacidad;

        // Usamos un adaptador
        private MySqlDataAdapter consulta;
        // Usamos un command para insertar o actualizar
        private MySqlCommand comando;
        // Usamos una tabla temporal
        private DataTable tabla;

        // Propiedades para los atributos
        public int IdSala { get => idSala; set => idSala = value; }
        public string NombreSala { get => nombreSala; set => nombreSala = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }

        // Metodo para cargar datos en el DataGrid
        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();

            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    // Mapeo de columnas con alias legibles para el DataGrid
                    string sql = "SELECT id_sala AS Clave, nombre_sala AS Sala, descripcion AS Descripción, capacidad AS Capacidad FROM tblSalas;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    } // Liberar la consulta
                } // Liberar la conexión 
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexion " + ex.Message);
            }
            return tabla;
        }

        // Metodo para consultar por coincidencia 
        public DataTable Consultar()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT id_sala AS Clave, nombre_sala AS Sala, descripcion AS Descripción, capacidad AS Capacidad FROM tblSalas WHERE nombre_sala LIKE @sala;";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@sala", "%" + nombreSala + "%");
                        using (consulta = new MySqlDataAdapter(consultar))
                        {
                            consulta.Fill(tabla);
                        } // Libera el adaptador
                    } // Libera la consulta
                } // Libera la conexión
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexión de la base de datos " + ex.Message);
            }
            return tabla;
        }

        // Metodo para guardar o actualizar
        public string GuardarActualizar(int tipoOperacion)
        {
            string msg = "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    switch (tipoOperacion)
                    {
                        case 0: // Insertar new
                            string sqlN = "INSERT INTO tblSalas(nombre_sala, descripcion, capacidad) VALUES(@nombreSala, @descripcion, @capacidad);";
                            using (comando = new MySqlCommand(sqlN, conexion))
                            {
                                comando.Parameters.AddWithValue("@nombreSala", nombreSala);
                                comando.Parameters.AddWithValue("@descripcion", descripcion);
                                comando.Parameters.AddWithValue("@capacidad", capacidad);

                                int filasAfectadas = comando.ExecuteNonQuery();
                                if (filasAfectadas > 0)
                                {
                                    msg = "El registro se guardó correctamente";
                                }
                                else
                                {
                                    msg = "Error, no se guardaron los datos...";
                                }
                            } // Libera la operacion de inserción
                            break;

                        case 1: // Actualizar old
                            string sqlA = "UPDATE tblSalas S SET S.nombre_sala=@nombreSala, S.descripcion=@descripcion, S.capacidad=@capacidad WHERE S.id_sala=@idSala;";
                            using (comando = new MySqlCommand(sqlA, conexion))
                            {
                                comando.Parameters.AddWithValue("@idSala", idSala);
                                comando.Parameters.AddWithValue("@nombreSala", nombreSala);
                                comando.Parameters.AddWithValue("@descripcion", descripcion);
                                comando.Parameters.AddWithValue("@capacidad", capacidad);

                                int filasAfectadas = comando.ExecuteNonQuery();
                                if (filasAfectadas > 0)
                                {
                                    msg = "El registro se guardó correctamente";
                                }
                                else
                                {
                                    msg = "Error, no se guardaron los datos";
                                }
                            } // Libera la operacion de actualización
                            break;
                    }
                } // Libera la conexión
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return msg;
        }

        public string Eliminar()
        {
            string msg = "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "DELETE FROM tblSalas WHERE id_sala=@idSala;";
                    using (comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@idSala", idSala);
                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            msg = "Datos eliminados correctamente";
                        }
                        else
                        {
                            msg = "Los datos no se pudieron eliminar";
                        }
                    } // Libera la eliminación
                } // Liberar las conexiones
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.Message);
            }
            return msg;
        }


    }
}

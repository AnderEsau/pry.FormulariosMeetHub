using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;

namespace pry.FormulariosMeetHub
{
    internal class clsAreaDpto
    {
        private string nombreArea;
        private string descripcion;
        private int idArea;//Este atributo es para referencia en update y delete

        //usamos un adaptador
        private MySqlDataAdapter consulta;
        //Usamos una tabla temporal
        private DataTable tabla;
        //Usamos un command para insertar o actualizar
        private MySqlCommand comando;

        //propiedad para los atributos
        public int IdArea { get => idArea; set => idArea = value; }
        public string NombreArea { get => nombreArea; set => nombreArea = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        //Metodo para cargar datos en el DataGrid
        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();

            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "select id_area AS Clave,nombre_area AS Nombre,descripcion AS Descripcion from tblarea_depto;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }//Liberar la consulta

                }//Liberar la conexión 
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexion " + ex.Message);
            }
            return tabla;
        }

        //Metodo para consultar por coincidencia 
        public DataTable Consultar()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT id_area AS Clave, nombre_area AS Nombre, descripcion AS Descripcion FROM tblarea_depto WHERE nombre_area LIKE @area;";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@area", "%" + nombreArea + "%");
                        using (consulta = new MySqlDataAdapter(consultar))
                        {
                            consulta.Fill(tabla);
                        }//Libera el adaptador
                    }//Libera la consulta
                }//Libera la conexión
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexión de la base de datos " + ex.Message);
            }
            return tabla;
        }

        //metodo para Actualizar
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
                        case 0://Insertar new
                            string sqlN = "INSERT INTO tblarea_depto(nombre_area, descripcion) VALUES(@nombre, @descripcion);";
                            using (comando = new MySqlCommand(sqlN, conexion))
                            {
                                comando.Parameters.AddWithValue("@nombre", nombreArea);
                                comando.Parameters.AddWithValue("@descripcion", descripcion);

                                int filasAfectadas = comando.ExecuteNonQuery();
                                if (filasAfectadas > 0)
                                {
                                    msg = "EL registro se guardo correctamente";
                                }
                                else
                                {
                                    msg = "Error, No se guardaron los datos...";
                                }
                            }//Libera la operacion de inserción
                            break;
                        case 1://Actualizar old
                            string sqlA = "UPDATE tblarea_depto SET nombre_area = @nombre, descripcion = @descripcion WHERE id_area = @id;";
                            using (comando = new MySqlCommand(sqlA, conexion))
                            {
                                comando.Parameters.AddWithValue("@nombre", nombreArea);
                                comando.Parameters.AddWithValue("@descripcion", descripcion);
                                comando.Parameters.AddWithValue("@id", idArea);

                                int filasAfectadas = comando.ExecuteNonQuery();
                                if (filasAfectadas > 0)
                                {
                                    msg = "EL registro se guardo correctamente";
                                }
                                else
                                {
                                    msg = "Error, No se guardaron los datos...";
                                }
                            }//Libera la operacion de actualización
                            break;
                    }
                }//Libera la conexión
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
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
                    string sql = "DELETE FROM tblarea_depto WHERE id_area = @id;";
                    using (comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", idArea);
                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            msg = "Datos eliminados correctamente";
                        }
                        else
                        {
                            msg = "Los datos no se pudieron eliminar";
                        }
                    }//Libera la eliminación

                }//Liberar las conexiones
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.Message);
            }
            return msg;

        }
    }
}

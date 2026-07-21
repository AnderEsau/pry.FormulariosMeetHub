using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pry.FormulariosMeetHub
{
    internal class clsEquipamiento
    {
        //Atributos
        private int idEquipamiento;
        private int idSala;
        private string nombreEquipamiento;
        private string descripcion;
        private string tipoEquipamiento;



        //Propiedades
        public int IdEquipamiento { get => idEquipamiento; set => idEquipamiento = value; }
        public int IdSala { get => idSala; set => idSala = value; }
        public string NombreEquipamiento { get => nombreEquipamiento; set => nombreEquipamiento = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string TipoEquipamiento { get => tipoEquipamiento; set => tipoEquipamiento = value; }


        //Usamos un adaptador
        private MySqlDataAdapter consulta;
        //Usamos un command para insertar o actualizar
        private MySqlCommand comando;
        //Usamos una tabla temporal
        private DataTable tabla;

        //Método para cargar datos en el DataGrid
        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT " +
                                 "E.id_equipamiento AS Clave, " +
                                 "E.nombre_equipamiento AS Equipamiento, " +
                                 "E.descripcion AS Descripción, " +
                                 "E.tipo_equipamiento AS Tipo, " +
                                 "E.id_sala AS 'Clave Sala' " +
                                 "FROM tblequipamiento E;";

                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexión " + ex.Message);
            }
            return tabla;
        }

        // Método para consultar por coincidencia (Buscador)
        public DataTable Consultar()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT " +
                                 "E.id_equipamiento AS Clave, " +
                                 "E.nombre_equipamiento AS Equipamiento, " +
                                 "E.descripcion AS Descripción, " +
                                 "E.tipo_equipamiento AS Tipo, " +
                                 "E.id_sala AS 'Clave Sala' " +
                                 "FROM tblequipamiento E " +
                                 "WHERE E.nombre_equipamiento LIKE @nombre;";

                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@nombre", "%" + nombreEquipamiento + "%");
                        using (consulta = new MySqlDataAdapter(consultar))
                        {
                            consulta.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexión de la base de datos " + ex.Message);
            }
            return tabla;
        }

        // Método para cargar la lista de salas en el ComboBox
        public DataTable CargarSalas()
        {
            DataTable dtSalas = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT id_sala, nombre_sala " +
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

        //Metodo para ya sea guardar o actualizar
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
                            string sqlN = "INSERT INTO tblequipamiento(id_sala,nombre_equipamiento,descripcion,tipo_equipamiento) VALUES(@id_sala,@nombre_equipamiento,@descripcion,@tipo_equipamiento);";
                            using (comando = new MySqlCommand(sqlN, conexion))
                            {
                                comando.Parameters.AddWithValue("id_sala", idSala);
                                comando.Parameters.AddWithValue("nombre_equipamiento", nombreEquipamiento);
                                comando.Parameters.AddWithValue("descripcion", descripcion);
                                comando.Parameters.AddWithValue("tipo_equipamiento", tipoEquipamiento);

                                int filasAfectadas = comando.ExecuteNonQuery();
                                if (filasAfectadas > 0)
                                {
                                    msg = "El registro se guardo correctamente";
                                }
                                else
                                {
                                    msg = "Error, No se guardaron los datos...";
                                }
                            }//Libera la operacion de la insercion

                            break;
                        case 1://Actualizar old
                            string sqlA = "UPDATE tblequipamiento E SET E.id_sala=@id_sala,E.nombre_equipamiento=@nombre_equipamiento,E.descripcion=@descripcion,E.tipo_equipamiento=@tipo_equipamiento WHERE E.id_equipamiento=@id_equipamiento;";
                            using (comando = new MySqlCommand(sqlA, conexion))
                            {
                                comando.Parameters.AddWithValue("id_equipamiento", idEquipamiento);
                                comando.Parameters.AddWithValue("id_sala", idSala);
                                comando.Parameters.AddWithValue("nombre_equipamiento", nombreEquipamiento);
                                comando.Parameters.AddWithValue("descripcion", descripcion);
                                comando.Parameters.AddWithValue("tipo_equipamiento", tipoEquipamiento);

                                int filasAfectadas = comando.ExecuteNonQuery();
                                if (filasAfectadas > 0)
                                {
                                    msg = "El registro se guardo correctamente";
                                }
                                else
                                {
                                    msg = "Error, No se guardaron los datos...";
                                }
                                break;
                            }//Libera la operacion de actualizacion
                    }

                }//Libera la conexión

            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo registrar. Asegurate de llenar todos los campos " + ex.Message);
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
                    string sql = "DELETE FROM tblequipamiento E WHERE E.id_equipamiento=@id_equipamiento;";
                    using (comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("id_equipamiento", idEquipamiento);
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

                }//Libera la conexión
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.Message);
            }
            return msg;

        }

        public void LimpiarPanel(Panel panelDestino)
        {
            foreach (Control control in panelDestino.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = 0;
                }
            }
        }
    }
}

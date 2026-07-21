using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pry.FormulariosMeetHub
{
    internal class clsUsuario
    {
        // Atributos privados basados en tu tabla tblbibliotecario y tu mockup
        private int idBibliotecario;
        private int matricula;
        private string usuarios;
        private string psw;
        private string tipo;

        // Adaptador y tablas virtuales de la clase
        private MySqlDataAdapter consulta;
        private DataTable tabla;
        private MySqlCommand comando;

        // Propiedades
        public int IdBibliotecario { get => idBibliotecario; set => idBibliotecario = value; }
        public int Matricula { get => matricula; set => matricula = value; }
        public string Usuarios { get => usuarios; set => usuarios = value; }
        public string Psw { get => psw; set => psw = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        // Método para cargar datos en el DataGrid de Usuarios
        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT id_bibliotecario AS ID, " +
                                 "matricula AS 'Matrícula del trabajador', " +
                                 "usuarios AS 'Usuario', " +
                                 "tipo AS 'Perfil', " +
                                 "psw AS 'Password' " +
                                 "FROM tblbibliotecario WHERE activo = TRUE;";

                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexión al cargar catálogo de usuarios: " + ex.Message);
            }
            return tabla;
        }

        // Método para buscar usuarios (Filtro de la barra "Buscar usuario")
        public DataTable Consultar()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT id_bibliotecario AS ID, " +
                                 "matricula AS 'Matrícula del trabajador', " +
                                 "usuarios AS 'Usuario', " +
                                 "tipo AS 'Perfil', " +
                                 "psw AS 'Password' " +
                                 "FROM tblbibliotecario WHERE usuarios LIKE @user AND activo = TRUE;";

                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@user", "%" + usuarios + "%");
                        using (consulta = new MySqlDataAdapter(consultar))
                        {
                            consulta.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexión de la base de datos: " + ex.Message);
            }
            return tabla;
        }

        // Método para Guardar o Actualizar SIN transacciones ni chismoso
        public string GuardarActualizar(int tipoOperacion)
        {
            string msg = "";
            clsConexion conexionBD = new clsConexion();

            try
            {
                using (var conexion = conexionBD.AbrirConexion())
                {
                    switch (tipoOperacion)
                    {
                        case 0: // NUEVO E INSERTAR
                            string sqlInsUser = "INSERT INTO tblbibliotecario (matricula, usuarios, psw, tipo, activo) " +
                                                "VALUES (@matricula, @usuarios, MD5(@psw), @tipo, TRUE);";

                            using (comando = new MySqlCommand(sqlInsUser, conexion))
                            {
                                comando.Parameters.AddWithValue("@matricula", matricula);
                                comando.Parameters.AddWithValue("@usuarios", usuarios);
                                comando.Parameters.AddWithValue("@psw", psw);
                                comando.Parameters.AddWithValue("@tipo", tipo);

                                comando.ExecuteNonQuery();
                            }
                            msg = "El usuario se registró correctamente de forma exitosa.";
                            break;

                        case 1: // ACTUALIZAR
                            string sqlUpdUser = "UPDATE tblbibliotecario SET matricula = @matricula, usuarios = @usuarios, " +
                                                "tipo = @tipo WHERE id_bibliotecario = @idBiblio;";

                            using (comando = new MySqlCommand(sqlUpdUser, conexion))
                            {
                                comando.Parameters.AddWithValue("@idBiblio", idBibliotecario);
                                comando.Parameters.AddWithValue("@matricula", matricula);
                                comando.Parameters.AddWithValue("@usuarios", usuarios);
                                comando.Parameters.AddWithValue("@tipo", tipo);

                                comando.ExecuteNonQuery();
                            }
                            msg = "Los datos del usuario se actualizaron correctamente.";
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                // El error se propaga hacia el formulario a través del throw
                throw new Exception("Error al procesar la solicitud en la base de datos: " + ex.Message);
            }
            return msg;
        }

        // Método para Eliminar físicamente el registro de la tabla
        public string Eliminar()
        {
            string msg = "";
            clsConexion conexionBD = new clsConexion();

            try
            {
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sqlDelUsuario = "DELETE FROM tblbibliotecario WHERE id_bibliotecario = @idBiblio;";
                    using (comando = new MySqlCommand(sqlDelUsuario, conexion))
                    {
                        comando.Parameters.AddWithValue("@idBiblio", idBibliotecario);
                        comando.ExecuteNonQuery();
                    }
                    msg = "El usuario ha sido eliminado del sistema.";
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexión al eliminar: " + ex.Message);
            }
            return msg;
        }

        // Método para limpiar los controles del panel
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
                    ((ComboBox)control).SelectedIndex = -1;
                }
            }
        }
    }
}


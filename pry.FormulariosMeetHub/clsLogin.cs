using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pry.FormulariosMeetHub
{
    internal class clsLogin
    {
        private string usuario;
        private string password;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }

        //Atributo estático
        private static string tipo;
        private static bool esAdministrador;
        private static bool esBibliotecario;

        //Propiedad estático
        public static bool EsAdministrador { get => esAdministrador; }
        public static bool EsBibliotecario { get => esBibliotecario; }

        public void AsignarPermisos()
        {
            switch (tipo)
            {
                case "Administrador":
                    esAdministrador = true;
                    esBibliotecario = false;
                    break;
                case "Bibliotecario":
                    esAdministrador = false;
                    esBibliotecario = true;
                    break;
                default:
                    esAdministrador = false;
                    esBibliotecario = false;
                    break;

            }
        }

        public bool ValidarAcceso()
        {
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT tipo, activo FROM tblbibliotecario " +
                                 "WHERE usuarios = @usuario AND psw = MD5(@password);";

                    using (var consulta = new MySqlCommand(sql, conexion))
                    {
                        consulta.Parameters.AddWithValue("@usuario", usuario);
                        consulta.Parameters.AddWithValue("@password", password);

                        using (var resultado = consulta.ExecuteReader())
                        {
                            if (resultado.Read())
                            {
                                // Se verifica el estado(activo) del usuario
                                int esActivo = resultado.GetInt32("activo");

                                // Si es 0 (o cualquier cosa que no sea 1), no funcionara el login y marcara error
                                if (esActivo != 1)
                                {
                                    throw new Exception("Su usuario se encuentra INACTIVO. Comuníquese con el administrador.");
                                }
                                //Verifica el tipo de usuario y asigna los permisos correspondientes
                                tipo = resultado.GetString("tipo");
                                AsignarPermisos();
                                if (!esAdministrador && !esBibliotecario)
                                {
                                    throw new Exception($"El perfil {tipo} no tiene permisos para acceder");
                                }
                                MessageBox.Show("Tu perfil es: " + tipo, "Sistema");
                                return true;
                            }
                            else
                            {
                                throw new Exception("Usuario o contraseña incorrectos.");
                            }
                        }// Liberar MySqlDateReader
                    }// Liberar MySqlCommand
                }// liberar MySqlConnection a través de tu clase 

            }
            catch (Exception ex)
            {
                //Si ocurre un error, lo relanzamos para que lo capture el formulario
                throw new Exception(ex.Message, ex);
            }
        }

    }
}

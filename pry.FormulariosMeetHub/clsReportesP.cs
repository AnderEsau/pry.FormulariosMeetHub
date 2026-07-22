using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pry.FormulariosMeetHub
{
    internal class clsReportesP
    {
        DataTable tabla;
        MySqlDataAdapter consulta;
        public DataTable ConsultarReporteSemanal()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT S.nombre_sala AS Sala, " + // Agarra el nombre de la sala
                                 "IFNULL(R.id_alumno, R.matricula) AS Responsable, " +
                                 "R.fecha_reserva AS 'Fecha de Reserva', " +
                                 "R.fecha_solicitud AS 'Fecha de Formalización' " +
                                 "FROM tblreserva R " +
                                 "INNER JOIN tblsalas S ON R.id_sala = S.id_sala;";
                                 

                    using (consulta = new MySqlDataAdapter(sql, conexion))//CONDICION
                    {
                        consulta.Fill(tabla);
                    }//se libera la consulta

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar alumnos en riesgo:" + ex.Message);
            }
            return tabla;
        }

        public DataTable consultarReporteMensual()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT S.nombre_sala AS Sala, " + // Agarra el nombre de la sala
                                 "IFNULL(R.id_alumno, R.matricula) AS Responsable, " +
                                 "R.fecha_reserva AS 'Fecha de Reserva', " +
                                 "R.fecha_solicitud AS 'Fecha de Formalización' " +
                                 "FROM tblreserva R " +
                                 "INNER JOIN tblsalas S ON R.id_sala = S.id_sala;";

                    using (consulta = new MySqlDataAdapter(sql, conexion))//CONDICION
                    {
                        consulta.Fill(tabla);
                    }//se libera la consulta

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar alumnos y tutores:" + ex.Message);
            }
            return tabla;
        }

        public DataTable consultarRangoFechas(string fechaInicio, string fechaFin)
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT S.nombre_sala AS Sala, " +
                                 "IFNULL(R.id_alumno, R.matricula) AS Responsable, " +
                                 "R.fecha_reserva AS 'Fecha de Reserva', " +
                                 "R.fecha_solicitud AS 'Fecha de Formalización' " +
                                 "FROM tblreserva R " +
                                 "INNER JOIN tblsalas S ON R.id_sala = S.id_sala " +
                                 "WHERE R.fecha_reserva BETWEEN '" + fechaInicio + "' AND '" + fechaFin + "';";

                    using (consulta = new MySqlDataAdapter(sql, conexion))//CONDICION
                    {
                        consulta.Fill(tabla);
                    }//se libera la consulta

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar alumnos y tutores:" + ex.Message);
            }
            return tabla;
        }
    }
}

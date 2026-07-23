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
                    string sql =
                        // ALUMNOS
                        "SELECT S.nombre_sala AS Sala, " +
                        "CONCAT(A.nombre, ' ', A.apellido_paterno, ' ', A.apellido_materno) AS 'Nombre', " +
                        "'Alumno' AS Tipo, " +
                        "R.fecha_solicitud AS 'Fecha de Solicitud', R.fecha_reserva AS 'Fecha de Reserva', " +
                        "R.tipo_evento AS 'Tipo de Evento', R.total_asistentes AS Asistentes, R.estado_reserva AS Estado " +
                        "FROM tblreserva R " +
                        "INNER JOIN tblsalas S ON R.id_sala = S.id_sala " +
                        "INNER JOIN tblalumnos A ON R.id_alumno = A.id_alumno " +
                        "WHERE YEARWEEK(R.fecha_reserva, 1) = YEARWEEK(CURDATE(), 1) " +

                        "UNION " +

                        // TRABAJADORES
                        "SELECT S.nombre_sala AS Sala, " +
                        "CONCAT(T.nombre, ' ', T.apellido_paterno, ' ', T.apellido_materno) AS 'Nombre', " +
                        "'Trabajador' AS Tipo, " +
                        "R.fecha_solicitud AS 'Fecha de Solicitud', R.fecha_reserva AS 'Fecha de Reserva', " +
                        "R.tipo_evento AS 'Tipo de Evento', R.total_asistentes AS Asistentes, R.estado_reserva AS Estado " +
                        "FROM tblreserva R " +
                        "INNER JOIN tblsalas S ON R.id_sala = S.id_sala " +
                        "INNER JOIN tbltrabajadores T ON R.matricula = T.matricula " +
                        "WHERE YEARWEEK(R.fecha_reserva, 1) = YEARWEEK(CURDATE(), 1) " +

                        "UNION " +

                        // EXTERNOS
                        "SELECT S.nombre_sala AS Sala, " +
                        "CONCAT(E.nombre, ' ', E.apellido_paterno, ' ', E.apellido_materno) AS 'Nombre', " +
                        "'Externo' AS Tipo, " +
                        "R.fecha_solicitud AS 'Fecha de Solicitud', R.fecha_reserva AS 'Fecha de Reserva', " +
                        "R.tipo_evento AS 'Tipo de Evento', R.total_asistentes AS Asistentes, R.estado_reserva AS Estado " +
                        "FROM tblreserva R " +
                        "INNER JOIN tblsalas S ON R.id_sala = S.id_sala " +
                        "INNER JOIN tblexterno E ON R.id_externo = E.id_externo " +
                        "WHERE YEARWEEK(R.fecha_reserva, 1) = YEARWEEK(CURDATE(), 1) " +

                        "ORDER BY `Fecha de Reserva` ASC;";

                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }//se libera la consulta
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar el reporte semanal:" + ex.Message);
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
                    string sql =
                        // ALUMNOS
                        "SELECT S.nombre_sala AS Sala, " +
                        "CONCAT(A.nombre, ' ', A.apellido_paterno, ' ', A.apellido_materno) AS 'Nombre', " +
                        "'Alumno' AS Tipo, " +
                        "R.fecha_solicitud AS 'Fecha de Solicitud', R.fecha_reserva AS 'Fecha de Reserva', " +
                        "R.tipo_evento AS 'Tipo de Evento', R.total_asistentes AS Asistentes, R.estado_reserva AS Estado " +
                        "FROM tblreserva R " +
                        "INNER JOIN tblsalas S ON R.id_sala = S.id_sala " +
                        "INNER JOIN tblalumnos A ON R.id_alumno = A.id_alumno " +
                        "WHERE MONTH(R.fecha_reserva) = MONTH(CURDATE()) AND YEAR(R.fecha_reserva) = YEAR(CURDATE()) " +

                        "UNION " +

                        // TRABAJADORES
                        "SELECT S.nombre_sala AS Sala, " +
                        "CONCAT(T.nombre, ' ', T.apellido_paterno, ' ', T.apellido_materno) AS 'Nombre', " +
                        "'Trabajador' AS Tipo, " +
                        "R.fecha_solicitud AS 'Fecha de Solicitud', R.fecha_reserva AS 'Fecha de Reserva', " +
                        "R.tipo_evento AS 'Tipo de Evento', R.total_asistentes AS Asistentes, R.estado_reserva AS Estado " +
                        "FROM tblreserva R " +
                        "INNER JOIN tblsalas S ON R.id_sala = S.id_sala " +
                        "INNER JOIN tbltrabajadores T ON R.matricula = T.matricula " +
                        "WHERE MONTH(R.fecha_reserva) = MONTH(CURDATE()) AND YEAR(R.fecha_reserva) = YEAR(CURDATE()) " +

                        "UNION " +

                        // EXTERNOS
                        "SELECT S.nombre_sala AS Sala, " +
                        "CONCAT(E.nombre, ' ', E.apellido_paterno, ' ', E.apellido_materno) AS 'Nombre', " +
                        "'Externo' AS Tipo, " +
                        "R.fecha_solicitud AS 'Fecha de Solicitud', R.fecha_reserva AS 'Fecha de Reserva', " +
                        "R.tipo_evento AS 'Tipo de Evento', R.total_asistentes AS Asistentes, R.estado_reserva AS Estado " +
                        "FROM tblreserva R " +
                        "INNER JOIN tblsalas S ON R.id_sala = S.id_sala " +
                        "INNER JOIN tblexterno E ON R.id_externo = E.id_externo " +
                        "WHERE MONTH(R.fecha_reserva) = MONTH(CURDATE()) AND YEAR(R.fecha_reserva) = YEAR(CURDATE()) " +

                        "ORDER BY `Fecha de Reserva` ASC;";

                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar el reporte mensual: " + ex.Message);
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
                    string sql =
                        //  ALUMNOS
                        "SELECT S.nombre_sala AS Sala, " +
                        "CONCAT(A.nombre, ' ', A.apellido_paterno, ' ', A.apellido_materno) AS 'Nombre', " +
                        "'Alumno' AS Tipo, " +
                        "R.fecha_solicitud AS 'Fecha de Solicitud', R.fecha_reserva AS 'Fecha de Reserva', " +
                        "R.tipo_evento AS 'Tipo de Evento', R.total_asistentes AS Asistentes, R.estado_reserva AS Estado " +
                        "FROM tblreserva R " +
                        "INNER JOIN tblsalas S ON R.id_sala = S.id_sala " +
                        "INNER JOIN tblalumnos A ON R.id_alumno = A.id_alumno " +
                        "WHERE R.fecha_reserva BETWEEN '" + fechaInicio + "' AND '" + fechaFin + "' " +

                        "UNION " +

                        // TRABAJADORES
                        "SELECT S.nombre_sala AS Sala, " +
                        "CONCAT(T.nombre, ' ', T.apellido_paterno, ' ', T.apellido_materno) AS 'Nombre', " +
                        "'Trabajador' AS Tipo, " +
                        "R.fecha_solicitud AS 'Fecha de Solicitud', R.fecha_reserva AS 'Fecha de Reserva', " +
                        "R.tipo_evento AS 'Tipo de Evento', R.total_asistentes AS Asistentes, R.estado_reserva AS Estado " +
                        "FROM tblreserva R " +
                        "INNER JOIN tblsalas S ON R.id_sala = S.id_sala " +
                        "INNER JOIN tbltrabajadores T ON R.matricula = T.matricula " +
                        "WHERE R.fecha_reserva BETWEEN '" + fechaInicio + "' AND '" + fechaFin + "' " +

                        "UNION " +

                        // EXTERNOS
                        "SELECT S.nombre_sala AS Sala, " +
                        "CONCAT(E.nombre, ' ', E.apellido_paterno, ' ', E.apellido_materno) AS 'Nombre', " +
                        "'Externo' AS Tipo, " +
                        "R.fecha_solicitud AS 'Fecha de Solicitud', R.fecha_reserva AS 'Fecha de Reserva', " +
                        "R.tipo_evento AS 'Tipo de Evento', R.total_asistentes AS Asistentes, R.estado_reserva AS Estado " +
                        "FROM tblreserva R " +
                        "INNER JOIN tblsalas S ON R.id_sala = S.id_sala " +
                        "INNER JOIN tblexterno E ON R.id_externo = E.id_externo " +
                        "WHERE R.fecha_reserva BETWEEN '" + fechaInicio + "' AND '" + fechaFin + "' " +

                        "ORDER BY `Fecha de Reserva` ASC;";

                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }//se libera la consulta
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar los rangos de fecha:" + ex.Message);
            }
            return tabla;
        }
    }
}

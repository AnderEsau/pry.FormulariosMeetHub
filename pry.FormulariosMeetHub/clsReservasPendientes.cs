using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pry.FormulariosMeetHub
{
    

    internal class clsReservasPendientes
    {
        //Adaptador y tabla virtuales de la clase
        private MySqlDataAdapter consulta;
        private DataTable tabla;

        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();

            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT R.id_reserva, " + // Agarra el id de la tabla reservas
                                 "S.nombre_sala AS Sala, " +
                                 "R.matricula AS Responsable, " +
                                 "R.fecha_reserva AS 'Fecha de Reserva', " +
                                 "R.fecha_solicitud AS 'Fecha de Formalización', " + // nombro la fecha de solicitud como lo requerido
                                 "R.hora_inicio, " +
                                 "R.hora_fin, " +
                                 "R.tipo_evento, " +
                                 "R.descripcion_evento, " +
                                 "R.motivo_evento, " +
                                 "R.total_asistentes, " +
                                 "R.estado_reserva " +
                                 "FROM tblreserva R " +
                                 "INNER JOIN tblsalas S ON R.id_sala = S.id_sala " +
                                 "WHERE R.estado_reserva = 'Pendiente';";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    } //Liberar la consulta
                } //Liberar la conexión externa automáticamente
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexión al cargar: " + ex.Message);
            }
            return tabla;

        }       
    }
}

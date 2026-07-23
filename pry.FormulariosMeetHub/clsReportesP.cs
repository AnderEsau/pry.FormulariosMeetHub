using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//agregar los using de la libreria QuestPDF
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

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
        public void ExportarPDF(DataTable tabla, string tituloReporte, string nombreArchivoSugerido)
        {
            if (tabla == null || tabla.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para convertir a PDF", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // abre la ventana para guardar el archivo PDF 
            SaveFileDialog guardarArchivo = new SaveFileDialog();
            guardarArchivo.FileName = nombreArchivoSugerido;
            guardarArchivo.Filter = "Archivos PDF (*.pdf)|*.pdf";

            if (guardarArchivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Document.Create(container =>
                    {
                        container.Page(page =>
                        {
                            page.Size(PageSizes.Letter.Landscape());
                            page.Margin(1.5f, Unit.Centimetre);
                            page.PageColor(Colors.White);
                            page.DefaultTextStyle(x => x.FontFamily(Fonts.Arial));
                            // Esto es para poner un título al reporte
                            page.Header().Row(row =>
                            {
                                row.RelativeItem().AlignLeft().AlignMiddle().Column(col =>
                                {
                                    col.Item().Text("MEETHUB")
                                     .FontSize(18)
                                     .Bold()
                                     .FontColor("#10407A");

                                    col.Item().PaddingTop(5).LineHorizontal(1).LineColor(Colors.Grey.Lighten2);

                                });

                                if (Properties.Resources.MEETHUB != null)
                                {
                                    byte[] byteslogo = Properties.Resources.MEETHUB;
                                    row.ConstantItem(90).AlignRight().AlignMiddle().Image(byteslogo);

                                }

                            });

                            //----Parte 2: contenido central ----
                            page.Content().PaddingTop(20).Column(column =>
                            {

                                //AQUI SE IMPRIME EL TITULO QUE LE PASES POR PARAMETRO 
                                column.Item().PaddingBottom(15).Text(tituloReporte) // <--DINAMICO
                                           .FontSize(12).Bold().FontColor(Colors.Black);

                                //LA TABLA SE CONSTRUYE SOLA SUGUN LAS COLUMNAS QUE TRAIGA EL DATATABLE 
                                column.Item().Table(table =>
                                {
                                    int totalcolumas = tabla.Columns.Count;

                                    table.ColumnsDefinition(columns =>
                                    {
                                        for (int i = 0; i < totalcolumas; i++)
                                        {
                                            if (i > 0 && i < totalcolumas - 1)
                                                columns.RelativeColumn(2f);
                                            else
                                                columns.RelativeColumn(1.2f);
                                        }

                                    });

                                    //Nombres de las columnas en automatico de acuerdo a la tabla 
                                    foreach (DataColumn columnaobjn in tabla.Columns)
                                    {
                                        table.Cell().Background("#4272CB").Padding(8).AlignLeft().AlignMiddle()
                                        .Text(columnaobjn.ColumnName).FontSize(10).Bold().FontColor(Colors.White);
                                    }
                                    //filas automaticas 
                                    bool alternarFila = true;
                                    foreach (DataRow fila in tabla.Rows)
                                    {
                                        string colorFondo = alternarFila ? "#E6EBF5" : "#FFFFFF";

                                        for (int i = 0; i < totalcolumas; i++)
                                        {
                                            var celda = table.Cell().Background(colorFondo)
                                                   .BorderBottom(1).BorderColor(Colors.Grey.Lighten3)
                                                   .Padding(7).AlignMiddle();
                                            if (i == 0 || i == (totalcolumas - 1))
                                                celda.AlignCenter();
                                            else
                                                celda.AlignCenter();

                                            celda.Text(fila[i].ToString()).FontSize(9).FontColor(Colors.Black);
                                        }
                                        alternarFila = !alternarFila;
                                    }

                                });

                            });

                            //este es el pie de  la pagina 
                            page.Footer().AlignRight().Text(x =>
                            {
                                x.Span("Pagina").FontSize(9).FontColor(Colors.Grey.Darken1);
                                x.CurrentPageNumber().FontSize(9).Bold();
                                x.Span("  de  ").FontSize(9).FontColor(Colors.Grey.Darken1);
                                x.TotalPages().FontSize(9).Bold();
                            });

                        });

                    }).GeneratePdf(guardarArchivo.FileName);

                    MessageBox.Show("Reporte institucional generado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el PDF " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }//finaliza metodo de conversión
    }
}

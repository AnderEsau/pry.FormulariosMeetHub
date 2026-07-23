using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry.FormulariosMeetHub
{
    public partial class frmReportesP : Form
    {
        clsReportesP reportes;
        DataTable tabla;
        public frmReportesP()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            reportes = new clsReportesP();

            if (rdbOpcion1.Checked == true)
            {
                //llamar la consulta para cargar en el grid 
                tabla = reportes.ConsultarReporteSemanal();
                dgvReporte.DataSource = tabla;
            }
            else if (rdbOpcion2.Checked == true)
            {
                //llamar la consulta para cargar en el grid 
                tabla = reportes.consultarReporteMensual();
                dgvReporte.DataSource = tabla;
            }
            else if (rdbOpcion3.Checked == true)
            {
                //llamar la consulta para cargar en el grid
                tabla = reportes.consultarRangoFechas(dtpInicio.Value.ToString("yyyy-MM-dd"), dtpFinal.Value.ToString("yyyy-MM-dd"));
                dgvReporte.DataSource = tabla;
            }
        }

        private void rdbOpcion3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbOpcion3.Checked == true)
            {
                // Al marcar la opción de rango personalizado, mostrara el calendario
                dtpInicio.Visible = true;
                dtpFinal.Visible = true;
                lblDesde.Visible = true;
                lblHasta.Visible = true;
            }
            else
            {
                // Si se marca semanal o mensual, oculta el calendario
                dtpInicio.Visible = false;
                dtpFinal.Visible = false;
                lblDesde.Visible = false;
                lblHasta.Visible = false;
            }
        }

        
        private void btnGenerarPdf_Click(object sender, EventArgs e)
        {
            reportes = new clsReportesP();
            if (rdbOpcion1.Checked == true)
            {
                reportes.ExportarPDF(tabla, "Reporte semanal de reservaciones", "ReporteSemanal.pdf");
            }
            else if (rdbOpcion2.Checked == true)
            {
                reportes.ExportarPDF(tabla, "Reporte mensual de reservaciones", "ReporteMensual.pdf");
            }
            else if (rdbOpcion3.Checked == true)
            {
                reportes.ExportarPDF(tabla, "Reporte de reservaciones por rango de fechas específico", "ReporteRangoFechas.pdf");
            }
        }
    }
}

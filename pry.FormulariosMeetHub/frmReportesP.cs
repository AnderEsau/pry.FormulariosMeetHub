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
                CargarGridReporteSemanal();
            }
            else if (rdbOpcion2.Checked == true)
            {
                //llamar la consulta para cargar en el grid 
                CargarGridReporteMensual();
            }
            else if (rdbOpcion3.Checked == true)
            {
                CargarGridRangoFechas();
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

        public void CargarGridReporteSemanal()
        {
            reportes = new clsReportesP();
            dgvReporte.DataSource = null;
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvReporte.DataSource = reportes.ConsultarReporteSemanal();
            }
            catch (Exception ex)    
            {
                MessageBox.Show(ex.Message);
            }   
        }
        public void CargarGridReporteMensual()
        {
            reportes = new clsReportesP();
            dgvReporte.DataSource = null;
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvReporte.DataSource = reportes.consultarReporteMensual();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CargarGridRangoFechas()
        {
            reportes = new clsReportesP();
            dgvReporte.DataSource = null;
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                string inicio = dtpInicio.Value.ToString("yyyy-MM-dd");
                string fin = dtpFinal.Value.ToString("yyyy-MM-dd");
                dgvReporte.DataSource = reportes.consultarRangoFechas(inicio, fin);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnGenerarPdf_Click(object sender, EventArgs e)
        {
            reportes = new clsReportesP();
            if (rdbOpcion1.Checked == true)
            {
                reportes.ExportarPDF(tabla, "reporte semanal de reservaciones", "ReporteSemanal.pdf");
            }
            else if (rdbOpcion2.Checked == true)
            {
                reportes.ExportarPDF(tabla, "reporte mensual de reservaciones", "ReporteMensual.pdf");
            }
            else if (rdbOpcion3.Checked == true)
            {
                reportes.ExportarPDF(tabla, "reporte de reservaciones por rango de fechas específico", "ReporteRangoFechas.pdf");
            }
        }
    }
}

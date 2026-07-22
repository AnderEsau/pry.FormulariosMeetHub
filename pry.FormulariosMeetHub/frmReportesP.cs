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
    }
}

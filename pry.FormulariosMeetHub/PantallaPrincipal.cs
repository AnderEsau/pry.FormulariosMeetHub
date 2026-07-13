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
    public partial class frmPrincipal : Form
    {
        clsPrincipal principal;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnReservaciones_Click(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.agregarAlContenedor(new frmReservaciones(), pnlContenedor);
        }

        private void btnReservasPnds_Click(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.agregarAlContenedor(new frmReservasPendientes(), pnlContenedor);
        }

        private void btnCancelaciones_Click(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.agregarAlContenedor(new frmCancelaciones(), pnlContenedor);
        }

        private void btnReporteP_Click(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.agregarAlContenedor(new frmReportesP(), pnlContenedor);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

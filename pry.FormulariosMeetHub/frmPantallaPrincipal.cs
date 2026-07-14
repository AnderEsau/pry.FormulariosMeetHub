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
        //Llamamos al formulario principal
        public frmPrincipal()
        {
            InitializeComponent();
        }
        //Evento que al mantener el click presionado hace que se mueva el btn seleccionado 3 pixeles hacia abajo y a la derecha
        private void btnGeneral_MouseDown(object mibotonSeleccionado, MouseEventArgs e)
        {
            Control btn = (Control)mibotonSeleccionado;
            btn.Location = new Point(btn.Location.X + 3, btn.Location.Y + 3);
        }

        //Evento que al soltar el click hace que se mueva el btn seleccionado vuelva  a su posicion original
        private void btnGeneral_MouseUp(object mibotonSeleccionado, MouseEventArgs e)
        {
            Control btn = (Control)mibotonSeleccionado;
            btn.Location = new Point(btn.Location.X - 3, btn.Location.Y - 3);
        }


        //Evento click del boton de reservaciones que trae el formulario al panel contenedor
        private void btnReservaciones_Click(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.agregarAlContenedor(new frmReservaciones(), pnlContenedor);

            //Actualiza el título
            lblNombreModulo.Text = "Reservaciones";
        }
        //Evento click del boton de reservas pendientes que trae el formulario al panel contenedor
        private void btnReservasPnds_Click(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.agregarAlContenedor(new frmReservasPendientes(), pnlContenedor);

            //Actualiza el título
            lblNombreModulo.Text = "Reservas Pendientes";
        }
        //Evento click del boton de cancelaciones que trae el formulario al panel contenedor
        private void btnCancelaciones_Click(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.agregarAlContenedor(new frmCancelaciones(), pnlContenedor);

            //Actualiza el título
            lblNombreModulo.Text = "Cancelaciones";
        }
        //Evento click del boton de reporte periodico que trae el formulario al panel contenedor
        private void btnReporteP_Click(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.agregarAlContenedor(new frmReportesP(), pnlContenedor);

            //Actualiza el título
            lblNombreModulo.Text = "Reporte Periódico";
        }
        //Evento click del boton de salir que cierra la aplicación
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

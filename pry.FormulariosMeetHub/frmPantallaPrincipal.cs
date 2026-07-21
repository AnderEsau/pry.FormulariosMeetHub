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
        public frmPrincipal(string nombreUsuario) // string nombreUsuario se define para que llegue ahí el nombre
        {
            InitializeComponent();

            lblNombreUser.Text = nombreUsuario; // inserta el nombre del usuario en el label
        }


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Verificando permisos
            //Si es administrador o bibliotecario podra ver los siguientes botones
            btnReservaciones.Visible = clsLogin.EsAdministrador || clsLogin.EsBibliotecario;
            btnCancelaciones.Visible = clsLogin.EsAdministrador || clsLogin.EsBibliotecario;
            btnResponsables.Visible = clsLogin.EsAdministrador || clsLogin.EsBibliotecario;
            btnAreasDpto.Visible = clsLogin.EsAdministrador || clsLogin.EsBibliotecario;
            //Unicamente si es administrador se le van a mostrar los siguientes botones
            btnUsuarios.Visible = clsLogin.EsAdministrador;
            btnReservasPnds.Visible = clsLogin.EsAdministrador;
            btnReporteP.Visible = clsLogin.EsAdministrador;
            btnSalas.Visible = clsLogin.EsAdministrador;
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
        //Evento click del boton de responsables que trae el formulario al panel contenedor
        private void btnResponsables_Click(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.agregarAlContenedor(new frmResponsables(), pnlContenedor);

            //Actualiza el título
            lblNombreModulo.Text = "Responsables";
        }
        //Evento click del boton de salas y equipamiento que trae el formulario al panel contenedor
        private void btnSalas_Click(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.agregarAlContenedor(new frmSalas(), pnlContenedor);

            //Actualiza el título
            lblNombreModulo.Text = "Salas";
        }
        //Evento click del boton de áreas o departamentos que trae el formulario al panel contenedor
        private void btnAreasDpto_Click(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.agregarAlContenedor(new frmAreaDpto(), pnlContenedor);

            //Actualiza el titulo
            lblNombreModulo.Text = "Áreas o Departamentos";
        }
        //Evento click del boton de salir que cierra la aplicación
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            principal = new clsPrincipal();
            principal.agregarAlContenedor(new frmUsuarios(), pnlContenedor);

            //Actualiza el título
            lblNombreModulo.Text = "Usuarios";
        }

        
    }
}

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
    public partial class frmResponsables : Form
    {
        public frmResponsables()
        {
            InitializeComponent();
        }
        //Eventos para el formulario de Responsables

        //Evento click del boton de agregar un nuevo responsable externo, que hace que salga un formulario emergente
        private void btnExternos_Click(object sender, EventArgs e)
        {
            frmExternos formulario = new frmExternos();
            formulario.ShowDialog(); //Bloqueamos el formulario del fondo, hasta que complete el registro o lo cancele
        }
        //Evento click del boton de agregar un nuevo responsable Alumno, que hace que salga un formulario emergente
        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            frmAlumnos formulario = new frmAlumnos();
            formulario.ShowDialog(); //Bloqueamos el formulario del fondo, hasta que complete el registro o lo cancele
        }
        //Evento click del boton de agregar un nuevo responsable trabajador, que hace que salga un formulario emergente
        private void btnTrabajadores_Click(object sender, EventArgs e)
        {
            frmTrabajadores formulario = new frmTrabajadores();
            formulario.ShowDialog(); //Bloqueamos el formulario del fondo, hasta que complete el registro o lo cancele
        }
    }
}

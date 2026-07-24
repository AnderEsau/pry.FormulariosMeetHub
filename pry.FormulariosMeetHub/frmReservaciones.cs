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
    public partial class frmReservaciones : Form
    {
        clsReservaciones reservacion;
        // Variable para controlar el inicio de la semana que aparece en el label
        private DateTime fechaInicio;
        public frmReservaciones()
        {
            InitializeComponent();
            // Obtenemos el lunes de cada semana
            fechaInicio = ObtenerLunesDeLaSemana(DateTime.Now);
            // Aqui ya se muestra el rango en el label y se carga el horario
            ActualizarSemana();
            LlenarComboSalas();
        }

        // Cargar el ComboBox de salas
        private void LlenarComboSalas()
        {
            reservacion = new clsReservaciones();

            try
            {
                DataTable dtSalas = reservacion.CargarSalas();

                // Creamos la fila del placeholder para la Sala
                DataRow filaPSala = dtSalas.NewRow();
                filaPSala["id_sala"] = 0;
                filaPSala["nombre_sala"] = "-- Seleccione una Sala --";
                dtSalas.Rows.InsertAt(filaPSala, 0); // Insertar al inicio de la lista

                // Enlazamos los datos al ComboBox visual
                cmbSala.DataSource = dtSalas;
                cmbSala.DisplayMember = "nombre_sala"; // El texto visible
                cmbSala.ValueMember = "id_sala";       // La llave primaria real
                cmbSala.SelectedIndex = 0;               // Forzar a que muestre el placeholder
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al rellenar los catálogos en los menús desplegables: " + ex.Message);
            }
        }

        // En el evento de carga del formulario hacemos que se cargue el data grid con los horarios establecidos
        private void frmReserva_Load(object sender, EventArgs e)
        {
            CargarHorarios();
        }

        //Metodo para cargar los horarios en el DataGrid
        private void CargarHorarios()
        {
            dgvReservaciones.Columns.Clear();

            // Creamos las columnas
            dgvReservaciones.Columns.Add("Hora", "Hora");
            dgvReservaciones.Columns.Add("Lunes", "Lunes");
            dgvReservaciones.Columns.Add("Martes", "Martes");
            dgvReservaciones.Columns.Add("Miercoles", "Miércoles");
            dgvReservaciones.Columns.Add("Jueves", "Jueves");
            dgvReservaciones.Columns.Add("Viernes", "Viernes");

            // Creamos las horas de las posibles reservas
            string[] horas = {
                "08:00 a. m.",
                "09:00 a. m.",
                "10:00 a. m.",
                "11:00 a. m.",
                "12:00 p. m.",
                "01:00 p. m.",
                "02:00 p. m.",
                "03:00 p. m.",
                "04:00 p. m.",
                "05:00 p. m."
            };

            foreach (string hora in horas)
            {
                // Rellenamos solo las 5 columnas correspondientes a los días de la semana con "Disponible"
                dgvReservaciones.Rows.Add(hora, "Disponible", "Disponible", "Disponible", "Disponible", "Disponible");
            }
        }

        // Metodo para cambiar el color de las celdas dependiendo si están ocupadas o disponibles
        private void dgvHorario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            // Evaluamos que la columna sea mayor a 0( osea en los días de la semana) y que la celda tenga datos asignados
            if (e.ColumnIndex > 0)
            {
                if (e.Value is string) // Comprueba directamente si el valor contiene un texto válido
                {
                    string texto = e.Value.ToString();

                    if (texto.StartsWith("Ocupado") == true)
                    {
                        e.CellStyle.BackColor = System.Drawing.Color.LightSteelBlue; // Azul
                        e.CellStyle.ForeColor = System.Drawing.Color.DarkBlue;
                    }
                    else if (texto == "Disponible")
                    {
                        e.CellStyle.BackColor = System.Drawing.Color.LightGreen; // Verde
                        e.CellStyle.ForeColor = System.Drawing.Color.DarkGreen;
                    }
                }
            }
        }

        private void cmbSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Validamos que haya una fila seleccionada y que corresponda al tipo de dato enlazado
                if (cmbSala.SelectedItem is DataRowView fila)
                {
                    int idSala = Convert.ToInt32(fila["id_sala"]);

                    // Si es la opción placeholder "-- Selecciona una Sala --"
                    if (idSala == 0)
                    {
                        txtDetalles.Text = string.Empty;
                    }
                    else
                    {
                        // Mostramos la descripción correspondiente a la sala elegida
                        txtDetalles.Text = fila["descripcion"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los detalles de la sala: " + ex.Message);
            }
        }

        // Metodo para calcular la fecha del Lunes de la semana que reciba
        private DateTime ObtenerLunesDeLaSemana(DateTime fecha)
        {
            int diferencia = (int)fecha.DayOfWeek - (int)DayOfWeek.Monday;

            // Si el dia es un domingo en este lenguaje es 0, la diferencia se ajusta
            if (diferencia < 0)
            {
                diferencia += 7;
            }

            return fecha.Date.AddDays(-diferencia);
        }

        // Actualiza la etiqueta visual y recarga las columnas/filas
        private void ActualizarSemana()
        {
            // el viernes de esa semana y sumandole 4 días al lunes
            DateTime fechaFinSemana = fechaInicio.AddDays(4);

            // Actualizamos la etiqueta para que se vea asi Semana: 20/07/2026 al 24/07/2026)
            lblFecha.Text = $"Semana: {fechaInicio:dd/MM/yyyy} al {fechaFinSemana:dd/MM/yyyy}";

            // Volvemos a mostrar la tabla de las semanas
            CargarHorarios();
        }

        // evento para el boton "siguiente", hace que se sumen 7 dias
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            fechaInicio = fechaInicio.AddDays(7);
            ActualizarSemana();
        }

        // evento para el boton "anterior", hace que retroceda 7 dias
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            fechaInicio = fechaInicio.AddDays(-7);
            ActualizarSemana();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmExternos formulario = new frmExternos();
            formulario.ShowDialog(); //Bloqueamos el formulario del fondo, hasta que complete el registro o lo cancele
        }
    }
}

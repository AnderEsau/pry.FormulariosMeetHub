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
    public partial class frmReservasPendientes : Form
    {
        clsReservasPendientes reservas;
        int idReservaSeleccionada;

        public frmReservasPendientes()
        {
            InitializeComponent();
            CargarGrid();
        }

        //Metodo para cargar el DataGridView
        public void CargarGrid()
        {
            reservas = new clsReservasPendientes();
            dgvReservasPendientes.DataSource = null;
            dgvReservasPendientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                //Asignamos la tabla virtual de la clase directamente al control visual
                dgvReservasPendientes.DataSource = reservas.CargarDataGrid();

                dgvReservasPendientes.Columns["id_reserva"].Visible = false;
                dgvReservasPendientes.Columns["hora_inicio"].Visible = false;
                dgvReservasPendientes.Columns["hora_fin"].Visible = false;
                dgvReservasPendientes.Columns["tipo_evento"].Visible = false;
                dgvReservasPendientes.Columns["descripcion_evento"].Visible = false;
                dgvReservasPendientes.Columns["motivo_evento"].Visible = false;
                dgvReservasPendientes.Columns["total_asistentes"].Visible = false;
                dgvReservasPendientes.Columns["estado_reserva"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvReservasPendientes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                // Validamos que realmente haya una fila seleccionada en el Grid
                if (dgvReservasPendientes.CurrentRow != null && dgvReservasPendientes.CurrentRow.Cells["id_reserva"].Value != null)
                {
                    idReservaSeleccionada = int.Parse(dgvReservasPendientes.CurrentRow.Cells["id_reserva"].Value.ToString());
                    // esto se mandará a los TextBox
                    txtHoraInicio.Text = dgvReservasPendientes.CurrentRow.Cells["hora_inicio"].Value.ToString();
                    txtHoraFin.Text = dgvReservasPendientes.CurrentRow.Cells["hora_fin"].Value.ToString();
                    txtTipoEvento.Text = dgvReservasPendientes.CurrentRow.Cells["tipo_evento"].Value.ToString();
                    txtTotalAsistentes.Text = dgvReservasPendientes.CurrentRow.Cells["total_asistentes"].Value.ToString();
                    txtDescripcion.Text = dgvReservasPendientes.CurrentRow.Cells["descripcion_evento"].Value.ToString();
                    txtMotivo.Text = dgvReservasPendientes.CurrentRow.Cells["motivo_evento"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los detalles: " + ex.Message);
            }
        }
    }
}

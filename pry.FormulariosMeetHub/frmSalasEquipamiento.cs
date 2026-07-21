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
    public partial class frmSalasEquipamiento : Form
    {
        clsSalas salas;
        int idSala; // Variable para mantener la referencia del registro seleccionado

        public frmSalasEquipamiento()
        {
            InitializeComponent();
            CargarGrid();
        }

        // Método para cargar y actualizar el DataGrid
        public void CargarGrid()
        {
            salas = new clsSalas();
            dgvSalas.DataSource = null;
            dgvSalas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvSalas.DataSource = salas.CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Evento TextChanged del campo de búsqueda "Buscar sala" (txtNombreSala)
        private void txtNombreSala_TextChanged(object sender, EventArgs e)
        {
            salas = new clsSalas();
            dgvSalas.DataSource = null;
            dgvSalas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                salas.NombreSala = txtNombreSala.Text;
                dgvSalas.DataSource = salas.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Evento para cuando seleccionas una fila en la tabla
        private void dgvSalas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSalas.CurrentRow != null && dgvSalas.CurrentRow.Cells[0].Value != null)
            {
                // Este es el campo oculto que servirá de referencia para actualizar y eliminar
                idSala = int.Parse(dgvSalas.CurrentRow.Cells[0].Value.ToString());

                // Llenamos los campos visibles con los datos de la fila seleccionada
                txtSala.Text = dgvSalas.CurrentRow.Cells[1].Value.ToString();
                txtDescripcion.Text = dgvSalas.CurrentRow.Cells[2].Value.ToString();
                txtAforo.Text = dgvSalas.CurrentRow.Cells[3].Value.ToString();
            }
        }

        // Evento del botón Guardar (btnGuardarS)
        private void btnGuardarS_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el campo Aforo sea un número válido antes de procesar
                if (!int.TryParse(txtAforo.Text, out int aforoConvertido))
                {
                    MessageBox.Show("Por favor, introduce un número válido para el Aforo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Si idSala es 0, es un nuevo registro (0), de lo contrario es una actualización (1)
                int tipoOperacion = idSala == 0 ? 0 : 1;

                salas.IdSala = idSala;
                salas.NombreSala = txtSala.Text;
                salas.Descripcion = txtDescripcion.Text;
                salas.Capacidad = aforoConvertido; // Guardamos el aforo numérico en Capacidad

                string msg = "";

                if (tipoOperacion != 0)
                {
                    var resp = MessageBox.Show("¿Confirmar que se desea actualizar el dato seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resp == DialogResult.Yes)
                    {
                        msg = salas.GuardarActualizar(tipoOperacion);
                        MessageBox.Show(msg);
                    }
                }
                else
                {
                    msg = salas.GuardarActualizar(tipoOperacion);
                    MessageBox.Show(msg);
                }

                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Evento del botón Nuevo (btnNuevoS)
        private void btnNuevoS_Click(object sender, EventArgs e)
        {
            idSala = 0; // Restablecemos el ID a 0 para que sea considerado una inserción
            txtSala.Clear();
            txtDescripcion.Clear();
            txtAforo.Clear();
            txtSala.Focus(); // Mandamos el cursor al primer campo
        }

        // Evento del botón Eliminar (btnEliminarS)
        private void btnEliminarS_Click(object sender, EventArgs e)
        {
            try
            {
                if (idSala == 0)
                {
                    MessageBox.Show("Por favor, selecciona una sala de la lista para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                salas.IdSala = idSala;
                var resp = MessageBox.Show("¿Confirmar que se desea eliminar la sala seleccionada?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resp == DialogResult.Yes)
                {
                    string msg = salas.Eliminar();
                    MessageBox.Show(msg);
                    CargarGrid();
                    btnNuevoS_Click(null, null); // Limpia los campos tras eliminar
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardarS_Click_1(object sender, EventArgs e)
        {

        }
    }
}


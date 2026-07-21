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
    public partial class frmEquipamiento : Form
    {
        clsEquipamiento equipamiento;
        int idEquipamiento = 0;

        public frmEquipamiento()
        {
            InitializeComponent();
            LlenarComboSalas();
            CargarGrid();
        }

        // Cargar el ComboBox de salas
        private void LlenarComboSalas()
        {
            equipamiento = new clsEquipamiento();

            try
            {
                DataTable dtSalas = equipamiento.CargarSalas();

                // Creamos la fila del placeholder para la Sala
                DataRow filaPSala = dtSalas.NewRow();
                filaPSala["id_sala"] = 0;
                filaPSala["nombre_sala"] = "-- Selecciona una Sala --";
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

        // Método para cargar datos en el DataGridView
        public void CargarGrid()
        {
            equipamiento = new clsEquipamiento();
            dgvEquipamiento.DataSource = null;
            dgvEquipamiento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvEquipamiento.DataSource = equipamiento.CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvEquipamiento_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                // Esto es para poder saber si es nuevo o vamos a actualizar
                idEquipamiento = int.Parse(dgvEquipamiento.CurrentRow.Cells["Clave"].Value.ToString());

                // Esto es para la tabla equipamiento
                txtEquipamiento.Text = dgvEquipamiento.CurrentRow.Cells["Equipamiento"].Value.ToString();
                txtDescripcionEquip.Text = dgvEquipamiento.CurrentRow.Cells["Descripción"].Value.ToString();
                txtTipo.Text = dgvEquipamiento.CurrentRow.Cells["Tipo"].Value.ToString();

                // Usar SelectedValue para apuntar al dato preciso del registro
                cmbSala.SelectedValue = int.Parse(dgvEquipamiento.CurrentRow.Cells["Clave Sala"].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mapear los datos seleccionados: " + ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            idEquipamiento = 0;
            equipamiento.LimpiarPanel(pnlEquipamiento);
            txtEquipamiento.Focus();
        }

        private void txtNombreEquipamiento_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreEquipamiento.Text))
            {
                CargarGrid();
                return;
            }
            equipamiento = new clsEquipamiento();
            dgvEquipamiento.DataSource = null;
            dgvEquipamiento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                equipamiento.NombreEquipamiento = txtNombreEquipamiento.Text;
                dgvEquipamiento.DataSource = equipamiento.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Requiere asignar datos ", ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Determinamos el tipo de operación
                int tipoOperacion = idEquipamiento == 0 ? 0 : 1;

                equipamiento = new clsEquipamiento();

                // Llenamos las propiedades del bloque Equipamiento
                equipamiento.IdEquipamiento = idEquipamiento;
                equipamiento.NombreEquipamiento = string.IsNullOrEmpty(txtEquipamiento.Text) ? null : txtEquipamiento.Text;
                equipamiento.Descripcion = string.IsNullOrEmpty(txtDescripcionEquip.Text) ? null : txtDescripcionEquip.Text;
                equipamiento.TipoEquipamiento = string.IsNullOrEmpty(txtTipo.Text) ? null : txtTipo.Text;
                equipamiento.IdSala = Convert.ToInt32(cmbSala.SelectedValue);

                string msg = "";

                // Si es una modificación (tipoOperacion = 1), pedimos confirmación
                if (tipoOperacion == 1)
                {
                    var resp = MessageBox.Show("¿Confirmar que deseas actualizar los datos de este equipamiento?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resp == DialogResult.Yes)
                    {
                        msg = equipamiento.GuardarActualizar(tipoOperacion);
                        MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrid(); // Refrescamos la tabla del formulario
                    }
                }
                else // Si es nuevo (tipoOperacion = 0), se guarda directo
                {
                    msg = equipamiento.GuardarActualizar(tipoOperacion);
                    MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrid(); // Refrescamos la tabla del formulario
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron guardar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show($"¿Estás completamente seguro de eliminar permanentemente el equipamiento con Clave :{idEquipamiento}?",
                                            "¡ADVERTENCIA!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    equipamiento = new clsEquipamiento();

                    equipamiento.IdEquipamiento = idEquipamiento;

                    string resultado = equipamiento.Eliminar();

                    MessageBox.Show(resultado, "Registro Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al intentar eliminar el registro: " + ex.Message,
                                    "Error Operacional", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

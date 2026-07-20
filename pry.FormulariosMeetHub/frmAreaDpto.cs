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
    public partial class frmAreaDpto : Form
    {
        clsAreaDpto area;
        int idArea;

        public frmAreaDpto()
        {
            InitializeComponent();
            CargarGrid();
        }

        //Metodo para cargar el DataGridView
        public void CargarGrid()
        {
            area = new clsAreaDpto();
            dgvAreaDpto.DataSource = null;
            dgvAreaDpto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                //Asignamos la tabla virtual de la clase directamente al control visual
                dgvAreaDpto.DataSource = area.CargarDataGrid();

                dgvAreaDpto.Columns["Clave"].Visible = true;
                dgvAreaDpto.Columns["Nombre"].Visible = true;
                dgvAreaDpto.Columns["Descripcion"].Visible = true;
                //dgvUsuarios.Columns["Responsable"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNombreArea_TextChanged(object sender, EventArgs e)
        {
            area = new clsAreaDpto();
            dgvAreaDpto.DataSource = null;
            dgvAreaDpto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                area.NombreArea = txtNombreArea.Text;
                dgvAreaDpto.DataSource = area.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAreaDpto_SelectionChanged(object sender, EventArgs e)
        {
            //Este es el campo oculto que me servirá de referencia para actualizar y eliminar
            idArea = int.Parse(dgvAreaDpto.CurrentRow.Cells[0].Value.ToString());
            //Estos son los campos visibles
            txtArea.Text = dgvAreaDpto.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text = dgvAreaDpto.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int tipoOperacion = idArea == 0 ? 0 : 1;
                area.IdArea = idArea;
                area.NombreArea = string.IsNullOrEmpty(txtArea.Text) ? null : txtArea.Text;
                area.NombreDescripcion = string.IsNullOrEmpty(txtDescripcion.Text) ? null:txtDescripcion.Text;
                string msg = "";
                if (tipoOperacion != 0)
                {
                    var resp = MessageBox.Show("Confirmar que se desea actualizar el dato seleccionado", "ALERTA!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resp == DialogResult.Yes)
                    {
                        msg = area.GuardarActualizar(tipoOperacion);
                        MessageBox.Show(msg);
                    }
                }
                else
                {
                    msg = area.GuardarActualizar(tipoOperacion);
                    MessageBox.Show(msg);
                }
                CargarGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            idArea = 0;
            txtArea.Clear();
            txtDescripcion.Clear();
            txtArea.Focus();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                area.IdArea = idArea;
                var resp = MessageBox.Show("Confirmar que se desea eliminar el dato seleccionado", "ALERTA!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (resp == DialogResult.Yes)
                {
                    string msg = area.Eliminar();
                    MessageBox.Show(msg);
                    CargarGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}

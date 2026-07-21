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
    public partial class frmUsuarios : Form
    {


        // Instancia de la clase de negocio
        clsUsuario objetoUsuario = new clsUsuario();

        // 0 = Insertar, 1 = Modificar
        int operacion = 0;

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CargarGrid();
            ConfigurarComboPerfil();
        }

        private void CargarGrid()
        {
            try
            {
                dgvUsuarios.DataSource = objetoUsuario.CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarComboPerfil()
        {
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Administrador");
            cmbTipo.Items.Add("Bibliotecario");
            cmbTipo.SelectedIndex = -1;
        }

        // BOTÓN: Nuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            operacion = 0;
            objetoUsuario.LimpiarPanel(pnlUsuarios); // Ajusta pnlDatos al nombre de tu Panel/GroupBox
            txtMatricula.Focus();
        }

        // BOTÓN: Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones básicas utilizando los nombres de tus controles
            if (string.IsNullOrEmpty(txtMatricula.Text) || string.IsNullOrEmpty(txtUsuario.Text) || cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, rellene todos los campos obligatorios del formulario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Mapeo desde tus nombres de controles
                objetoUsuario.Matricula = Convert.ToInt32(txtMatricula.Text);
                objetoUsuario.Usuarios = txtUsuario.Text;
                objetoUsuario.Psw = txtPassword.Text;
                objetoUsuario.Tipo = cmbTipo.SelectedItem.ToString();

                string respuesta = objetoUsuario.GuardarActualizar(operacion);

                MessageBox.Show(respuesta, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                objetoUsuario.LimpiarPanel(pnlUsuarios);
                CargarGrid();
                operacion = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al Guardar/Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // BOTÓN: Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (objetoUsuario.IdBibliotecario == 0)
            {
                MessageBox.Show("Por favor, seleccione un usuario de la tabla para proceder a eliminarlo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Está completamente seguro de eliminar este usuario del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    string respuesta = objetoUsuario.Eliminar();
                    MessageBox.Show(respuesta, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objetoUsuario.LimpiarPanel(pnlUsuarios);
                    CargarGrid();
                    objetoUsuario.IdBibliotecario = 0;
                    operacion = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // EVENTO CELLCLICK: Al seleccionar una fila en dgvUsuario
        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];

                // Guardar ID
                objetoUsuario.IdBibliotecario = Convert.ToInt32(fila.Cells["ID"].Value);

                // Asignar datos a los controles específicos
                txtMatricula.Text = fila.Cells["Matrícula del trabajador"].Value.ToString();
                txtUsuario.Text = fila.Cells["Usuario"].Value.ToString();
                txtPassword.Text = fila.Cells["Password"].Value.ToString();
                cmbTipo.SelectedItem = fila.Cells["Perfil"].Value.ToString();

                operacion = 1; // Cambia a modo actualización
            }
        }

        // EVENTO TEXTCHANGED: Cajas de texto de búsqueda en tiempo real
        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                objetoUsuario.Usuarios = txtNombreUsuario.Text;
                dgvUsuarios.DataSource = objetoUsuario.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de filtrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

   
}


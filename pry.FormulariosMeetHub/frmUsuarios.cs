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
        clsUsuario usuario;
        int idBibliotecario = 0;

        public frmUsuarios()
        {
            InitializeComponent();
            LlenarComboPerfiles();
            CargarGrid();
        }

        private void LlenarComboPerfiles()
        {
            try
            {
                DataTable dtPerfiles = new DataTable();
                dtPerfiles.Columns.Add("id", typeof(int));
                dtPerfiles.Columns.Add("perfil", typeof(string));


                dtPerfiles.Rows.Add(0, "-- Selecciona un Perfil --");


                dtPerfiles.Rows.Add(1, "Administrador");
                dtPerfiles.Rows.Add(2, "Bibliotecario");



                cmbTipo.DataSource = dtPerfiles;
                cmbTipo.DisplayMember = "perfil";
                cmbTipo.ValueMember = "id";
                cmbTipo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los perfiles: " + ex.Message);
            }
        }

        // Método para cargar datos en el DataGridView
        public void CargarGrid()
        {
            usuario = new clsUsuario();
            dgvUsuarios.DataSource = null;

            // Oculta el encabezado de filas y ajusta columnas
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            try
            {
                dgvUsuarios.DataSource = usuario.CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dgvUsuario_SelectionChanged(object sender, EventArgs e)
        {


            try
            {
                // Validamos que exista una fila seleccionada y que la celda ID no esté vacía
                if (dgvUsuarios.CurrentRow != null && dgvUsuarios.CurrentRow.Cells["ID"].Value != DBNull.Value)
                {
                    // 1. Guardamos el ID del usuario seleccionado
                    idBibliotecario = int.Parse(dgvUsuarios.CurrentRow.Cells["ID"].Value.ToString());

                    // 2. Pasamos los datos a los TextBox correspondientes
                    txtMatricula.Text = dgvUsuarios.CurrentRow.Cells["Matrícula del trabajador"].Value?.ToString();
                    txtUsuario.Text = dgvUsuarios.CurrentRow.Cells["Usuario"].Value?.ToString();
                    txtPassword.Text = dgvUsuarios.CurrentRow.Cells["Password"].Value?.ToString();

                    // 3. Seleccionamos la opción correcta en el ComboBox de Perfil
                    string perfilSeleccionado = dgvUsuarios.CurrentRow.Cells["Perfil"].Value?.ToString();

                    if (!string.IsNullOrEmpty(perfilSeleccionado))
                    {
                        // Busca coincidencia de texto dentro de las opciones del ComboBox
                        cmbTipo.SelectedIndex = cmbTipo.FindStringExact(perfilSeleccionado);
                    }
                    else
                    {
                        cmbTipo.SelectedIndex = 0; // Vuelve al placeholder '-- Selecciona un Perfil --'
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        // Botón Nuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            idBibliotecario = 0;
            usuario.LimpiarPanel(pnlUsuarios);
            txtMatricula.Focus();
        }

        // Búsqueda en tiempo real
        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreUsuario.Text))
            {
                CargarGrid();
                return;
            }

            usuario = new clsUsuario();
            dgvUsuarios.DataSource = null;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            try
            {
                usuario.Usuarios = txtNombreUsuario.Text;
                dgvUsuarios.DataSource = usuario.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Requiere asignar datos ", ex.Message);
            }
        }

        // Botón Guardar 
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Determinamos el tipo de operación
                int tipoOperacion = idBibliotecario == 0 ? 0 : 1;

                usuario = new clsUsuario();

                // Llenamos las propiedades del objeto usuario
                usuario.IdBibliotecario = idBibliotecario;
                usuario.Matricula = Convert.ToInt32(txtMatricula.Text);
                usuario.Usuarios = string.IsNullOrEmpty(txtUsuario.Text) ? null : txtUsuario.Text.Trim();
                usuario.Psw = string.IsNullOrEmpty(txtPassword.Text) ? null : txtPassword.Text.Trim();
                usuario.Tipo = cmbTipo.Text;

                string msg = "";

                // Si es una modificación (tipoOperacion = 1), pedimos confirmación
                if (tipoOperacion == 1)
                {
                    var resp = MessageBox.Show("¿Confirmar que deseas actualizar los datos de este usuario?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resp == DialogResult.Yes)
                    {
                        msg = usuario.GuardarActualizar(tipoOperacion);
                        MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        usuario.LimpiarPanel(pnlUsuarios);
                        idBibliotecario = 0;
                        CargarGrid(); // Refrescamos la tabla del formulario
                    }
                }
                else // Si es nuevo (tipoOperacion = 0), se guarda directo
                {
                    msg = usuario.GuardarActualizar(tipoOperacion);
                    MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    usuario.LimpiarPanel(pnlUsuarios);
                    idBibliotecario = 0;
                    CargarGrid(); // Refrescamos la tabla del formulario
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron guardar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idBibliotecario == 0)
            {
                MessageBox.Show("Seleccione un registro del catálogo para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var respuesta = MessageBox.Show($"¿Estás completamente seguro de eliminar permanentemente el usuario con Clave :{idBibliotecario}?",
                                            "¡ADVERTENCIA!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    usuario = new clsUsuario();

                    usuario.IdBibliotecario = idBibliotecario;

                    string resultado = usuario.Eliminar();

                    MessageBox.Show(resultado, "Registro Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    usuario.LimpiarPanel(pnlUsuarios);
                    idBibliotecario = 0;
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


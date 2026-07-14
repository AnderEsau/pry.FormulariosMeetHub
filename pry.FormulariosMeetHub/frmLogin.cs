namespace pry.FormulariosMeetHub
{
    public partial class frmLogin : Form
    {
        public string UsuarioLogueado { get; set; } // Es como una caja que va a almacenar el nombre del usuario 
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                clsLogin login = new clsLogin();
                login.Usuario = txtUsuario.Text;
                login.Password = txtPassword.Text;

                bool resp = login.ValidarAcceso();
                if (resp == true)
                {
                    this.UsuarioLogueado = txtUsuario.Text; //Se guarda el nombre en la "caja"

                    this.DialogResult = DialogResult.OK;
                    this.Close(); // cierra el login y abre el formulario principal
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

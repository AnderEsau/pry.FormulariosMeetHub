namespace pry.FormulariosMeetHub
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Creamos la ventana principal
            frmPrincipal ventanaPrincipal = new frmPrincipal();

            // Ocultamos el login momentáneamente
            this.Hide();

            // Mostramos la principal como un diálogo flotante absoluto
            ventanaPrincipal.ShowDialog();

            // Cuando el usuario por fin cierre la ventana principal, regresará aquí y cerrará el login (y la app)
            this.Close();


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

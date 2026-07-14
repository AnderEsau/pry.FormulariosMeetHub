namespace pry.FormulariosMeetHub
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            using (frmLogin login = new frmLogin())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    string usuario = login.UsuarioLogueado; //Se saca el nombre del usuario antes de iniciar el formulario

                    Application.Run(new frmPrincipal(usuario)); //Arranca de nuevo el formulario pero ya metiendo el nombre del usuario
                }
            }
        }
    }
}
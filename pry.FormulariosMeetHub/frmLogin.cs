namespace pry.FormulariosMeetHub
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReportesP ventanaReporte = new frmReportesP();
            ventanaReporte.Show();
            this.Hide();

        }
    }
}

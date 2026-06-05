namespace ProyectoBombas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirControl(UserControl control)
        {
            pnlContenido.Controls.Clear();

            control.Dock = DockStyle.Fill;

            pnlContenido.Controls.Add(control);
        }

        private void btnArduino_Click(object sender, EventArgs e)
        {
            UC_Arduino ucArduino = new UC_Arduino();

            AbrirControl(ucArduino);

            lblTituloPagina.Text = "Configuración Arduino";
        }
    }
}

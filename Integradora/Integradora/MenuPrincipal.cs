namespace Integradora
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            SetVisibleCore(false);
            Dispose();
        }
    }
}

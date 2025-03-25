namespace Integradora
{
    public partial class MenuPrincipal : Form
    {
        private List<Seccion> Secciones = [];

        public MenuPrincipal()
        {
            InitializeComponent();

            #region Creacion de un inventario por ahora
            Secciones.Add(new("Productos", [
                new ("Hamburguesa", 1, 90, 90),
                new ("Pizza", 2, 0, 30),
                new ("Salsa", 3, 10, 40)
                ]));

            Secciones.Add(new("Electronicos", [
                new ("Television rota", 1, 2, 0),
                new ("Tostadora bluetooth", 2, 99, 9999),
                new ("Espatula electrica", 3, 10, 5)
                ]));
            #endregion
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            SetVisibleCore(false);
            Dispose();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integradora.Inventario
{
    public partial class AgregarSeccion : Form
    {
        public MenuInventario Main = null;

        public AgregarSeccion()
        {
            InitializeComponent();

            SetVisibleCore(true);
        }

        private void Crear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Nombre.Text))
            {
                Estatus.Text = "Nombre de la seccion vacio";
                return;
            }

            Manager.Secciones.Add(new(Nombre.Text, []));
            Main.AbrirAgregarProducto();

            SetVisibleCore(false);
            Dispose();
        }
    }
}

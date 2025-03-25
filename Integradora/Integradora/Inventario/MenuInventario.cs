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
    public partial class MenuInventario : Form
    {
        private MenuPrincipal Menu;

        public MenuInventario(MenuPrincipal menu)
        {
            InitializeComponent();

            SetVisibleCore(true);
            Menu = menu;

            foreach(Seccion seccion in Menu.Secciones)
            {
                richTextBox1.Text += $"{seccion.Nombre}: \n";

                foreach (Elemento elemento in seccion.Elementos) richTextBox1.Text += $"{elemento} \n";
            }
        }
    }
}

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
    public partial class ModificarUnidades : Form
    {
        public MenuInventario Main = null;
        public Elemento Elem = null;

        public ModificarUnidades()
        {
            InitializeComponent();
            Visible = true;
        }

        public void Inicializar()
        {
            ActualizarUnidades();
        }
        private void ActualizarUnidades()
        {
            UnidadesLabel.Text = $"Unidades Actuales: {Elem.Unidades}";
        }

        private void MasUno_Click(object sender, EventArgs e)
        {
            CambioUnidadAlElemento(+1);
        }

        private void MenosUno_Click(object sender, EventArgs e)
        {
            CambioUnidadAlElemento(-1);
        }

        private void CambioUnidadAlElemento(int unidades)
        {
            Elem.Unidades += unidades;
            Manager.ExecuteNonQuery($"update elementos set unidades = '{Elem.Unidades}' where id = '{Elem.ID}';");
            Manager.ActualizarBaseDeDatos();
            Main.ActualizarDatos();
            ActualizarUnidades();
        }

        private void AgregarUnidades_Click(object sender, EventArgs e)
        {
            if (ChecarAgregarUnidadesText()) CambioUnidadAlElemento(int.Parse(AgregarUnidadesText.Text));
        }
        private void AgregarUnidadesText_TextChanged(object sender, EventArgs e)
        {
            ChecarAgregarUnidadesText();
        }
        private bool ChecarAgregarUnidadesText()
        {
            try
            {
                int entero = int.Parse(AgregarUnidadesText.Text);
                return true;
            }
            catch
            {
                AgregarUnidadesText.Text = "";
                return false;
            }
        }

        private void QuitarUnidadesText_TextChanged(object sender, EventArgs e)
        {
            ChecarQuitarUnidadesText();
        }
        private bool ChecarQuitarUnidadesText()
        {
            try
            {
                int entero = int.Parse(QuitarUnidadesText.Text);
                return true;
            }
            catch
            {
                QuitarUnidadesText.Text = "";
                return false;
            }
        }

        private void QuitarUnidades_Click(object sender, EventArgs e)
        {
            if (ChecarQuitarUnidadesText()) CambioUnidadAlElemento(-int.Parse(QuitarUnidadesText.Text));
        }
    }
}

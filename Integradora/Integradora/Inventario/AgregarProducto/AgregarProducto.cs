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
    public partial class AgregarProducto : Form
    {
        public List<string> Secciones = [];
        public MenuInventario Main = null;

        public AgregarProducto()
        {
            InitializeComponent();

            SetVisibleCore(true);

        }
        public void Inicializar()
        {
            #region Insertar los nombres de las secciones
            SeccionBox.Items.Clear();
            foreach (string seccion in Secciones) SeccionBox.Items.Add(seccion);

            if (SeccionBox.Items.Count > 0) SeccionBox.SelectedItem = SeccionBox.Items[0];
            else throw new Exception("No hay secciones");
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SeccionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChecarSeccionTexto();
        }
        private bool ChecarSeccionTexto()
        {
            if (string.IsNullOrEmpty(SeccionBox.Text)) return false;
            return Secciones.Contains(SeccionBox.Text);
        }

        private void Unidades_TextChanged(object sender, EventArgs e)
        {
            ChecarUnidadesTexto();
        }
        private bool ChecarUnidadesTexto()
        {
            if (string.IsNullOrEmpty(Unidades.Text)) return false;
            try
            {
                int prueba = int.Parse(Unidades.Text.ToString());
                return true;
            }
            catch
            {
                Unidades.Text = "";
                return false;
            }
        }

        private void Ventas_TextChanged(object sender, EventArgs e)
        {
            ChecarVentasTexto();
        }
        private bool ChecarVentasTexto()
        {
            if (string.IsNullOrEmpty(Ventas.Text)) return false;
            try
            {
                int prueba = int.Parse(Ventas.Text.ToString());
                return true;
            }
            catch
            {
                Ventas.Text = "";
                return false;
            }
        }

        private void Agregar_Click_1(object sender, EventArgs e)
        {
            if (!ChecarSeccionTexto())
            {
                Estatus.Text = "Seccion no existe";
                SeccionBox.Text = Secciones[0];
                return;
            }

            if (string.IsNullOrEmpty(Nombre.Text))
            {
                Estatus.Text = "Nombre vacio";
                return;
            }

            if (!ChecarUnidadesTexto())
            {
                Estatus.Text = "Error en Unidades";
                Unidades.Text = "0";
                return;
            }

            if (!ChecarVentasTexto())
            {
                Estatus.Text = "Error en Ventas";
                Ventas.Text = "0";
                return;
            }

            Elemento elem = new (SeccionBox.Text, Nombre.Text, int.Parse(Unidades.Text), int.Parse(Ventas.Text));
            Manager.InsertInto("Elementos", elem.ObtenerDatosPalInsert());
            Manager.ActualizarBaseDeDatos();

            Main.ActualizarDatos();

            Estatus.Text = "ta bien";
        }

        private void Nombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

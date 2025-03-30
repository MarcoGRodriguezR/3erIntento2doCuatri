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
    public partial class EliminarProducto : Form
    {
        public Seccion Seccion = null;
        public MenuInventario Main = null;

        public EliminarProducto()
        {
            InitializeComponent();

            SetVisibleCore(true);
        }
        public void Inicializar()
        {
            if (Seccion == null) return;

            IndicacionLabel.Text = $"Eliga un elemento que eliminar de {Seccion.Nombre}";

            Elementos.Items.Clear();
            //for (int i = Elementos.Items.Count - 1; i >= 0; i--) Elementos.Items.RemoveAt(i);
            Elementos.Width = IndicacionLabel.Width;
            foreach (Elemento elem in Seccion.Elementos) Elementos.Items.Add($"{elem.Nombre}");
            if (Elementos.Items.Count > 0) Elementos.SelectedItem = Elementos.Items[0];
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (Seccion == null)
            {
                Estatus.Text = "Seccion no existe";
                return;
            }

            if (Elementos.Items.Count < 0 || Elementos.Items == null)
            {
                Estatus.Text = "No hay elementos";
                return;
            }

            if (!Elementos.Items.Contains(Elementos.Text))
            {
                Estatus.Text = "No existe ese elemento";
                Elementos.SelectedIndex = 0;
                Elementos.SelectedItem = Elementos.Items[0];
                return;
            }


            for (int i = 0; i < Elementos.Items.Count; i++)
            {
                if (Elementos.Items[i].ToString() == Elementos.Text)
                {
                    Elementos.SelectedIndex = i;
                }
            }

            Elemento elem = Seccion.Elementos[Elementos.SelectedIndex];
            Manager.ExecuteNonQuery($"delete from Elementos where ID = {elem.ID}");

            if (!Seccion.Elementos.Remove(elem)) throw new Exception($"{elem.Nombre} no existe");
            Elementos.Items.Clear();
            Inicializar();

            Manager.Secciones.Clear();
            Manager.ActualizarBaseDeDatos();
            Main.ActualizarDatos();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

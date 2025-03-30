using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integradora.Inventario
{
    public partial class EliminarSeccion : Form
    {
        public List<string> Secciones = [];
        public MenuInventario Main = null;

        public EliminarSeccion()
        {
            InitializeComponent();

            SetVisibleCore(true);
        }

        public void Inicializar()
        {
            SeccionBox.Items.Clear();
            foreach(string s in Secciones) SeccionBox.Items.Add(s);
            if (SeccionBox.Items.Count > 0) SeccionBox.SelectedItem = SeccionBox.Items[0];

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (Secciones == null || SeccionBox == null)
            {
                EstatusLabel.Text = "Secciones no existen";
                return;
            }

            bool existe = false;
            foreach(Seccion sec in Manager.Secciones)
                if (sec.Nombre == SeccionBox.SelectedItem.ToString()) existe = true;
            if (!existe)
            {
                if (SeccionBox.Items.Count > 0) SeccionBox.SelectedItem = SeccionBox.Items[0];
                EstatusLabel.Text = "La Seccion elegida no existe";
                return;
            }

            Seccion seccion = Manager.Secciones[SeccionBox.SelectedIndex];
            Manager.ExecuteNonQuery($"delete from Elementos where Seccion = '{seccion.Nombre}'");

            if (!Secciones.Remove(SeccionBox.SelectedItem.ToString())) throw new Exception($"{SeccionBox.SelectedItem} no existe");
            SeccionBox.Items.Clear();
            Inicializar();

            Manager.Secciones.Clear();
            Manager.ActualizarBaseDeDatos();
            Main.ActualizarDatos();
        }
    }
}

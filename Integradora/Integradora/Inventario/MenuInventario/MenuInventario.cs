using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Integradora.Inventario
{
    public partial class MenuInventario : Form
    {

        public MenuInventario()
        {
            InitializeComponent();

            SetVisibleCore(true);

            ActualizarDatos();

        }

        #region Metodo en clic o similares
        private void Secciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarElementos();
        }

        private void Elementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextoPrincipal.Text = Manager.Secciones[SeccionBox.SelectedIndex].Elementos[ElementoBox.SelectedIndex].ToString();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            SetVisibleCore(false);
            Dispose();
        }

        private void ModUnidades_Click(object sender, EventArgs e)
        {
            ModificarUnidades mod = new();
        }
        #endregion

        #region Metodos 
        public void ActualizarDatos()
        {
            #region Insertar los nombres de secciones al combo box
            SeccionBox.Items.Clear();
            foreach (Seccion seccion in Manager.Secciones) SeccionBox.Items.Add(seccion.Nombre);
            // 2025 Mar 25: Por alguna razon no se autoselecciona el primer elemento en el combo box, asi que lo hare manualmente
            if (SeccionBox.Items.Count > 0) SeccionBox.SelectedItem = SeccionBox.Items[0];
            else throw new Exception("No hay secciones");
            #endregion

            ActualizarElementos();

        }

        /// <summary>
        /// Devuelve un <see cref="Seccion"/> basado en el parametro, da error si no encuentra una seccion
        /// </summary>
        /// <param name="nombre">Nombre de la seleccion a buscar, por defecto es el nombre seleccionado en <see cref="SeccionBox"/></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private Seccion ObtenerSeccionSeleccionada(string nombre = null)
        {
            nombre ??= SeccionBox.Items[SeccionBox.SelectedIndex].ToString();

            foreach (Seccion seccion in Manager.Secciones)
            {
                if (seccion.Nombre == nombre) return seccion;
            }

            throw new Exception($"{nombre} no existe");
        }

        /// <summary>
        /// Cambia los elementos en <see cref="ElementoBox"/> a la seccion seleccionada en <see cref="SeccionBox"/>
        /// </summary>
        private void ActualizarElementos()
        {
            Seccion seccion = ObtenerSeccionSeleccionada();

            #region Insertar los nombres de los productos al otro combo box
            ElementoBox.Items.Clear();

            foreach (Elemento elemento in seccion.Elementos) ElementoBox.Items.Add(elemento.Nombre);
            if (ElementoBox.Items.Count > 0) ElementoBox.SelectedItem = ElementoBox.Items[0];
            #endregion
        }
        #endregion

        private void AgregarProducto_Click(object sender, EventArgs e)
        {
            AbrirAgregarProducto();
        }
        public void AbrirAgregarProducto()
        {
            AgregarProducto agg = new();

            List<string> secciones = [];
            foreach (Seccion seccion in Manager.Secciones) secciones.Add(seccion.Nombre);
            agg.Secciones = secciones;
            agg.Main = this;

            agg.Inicializar();
        }

        private void EliminarProducto_Click(object sender, EventArgs e)
        {
            EliminarProducto eli = new()
            {
                Seccion = Manager.Secciones[SeccionBox.SelectedIndex],
                Main = this
            };

            eli.Inicializar();
        }

        private void AgregarSeccion_Click(object sender, EventArgs e)
        {
            _ = new AgregarSeccion()
            {
                Main = this
            };

        }

        private void EliminarSecciones_Click(object sender, EventArgs e)
        {
            EliminarSeccion elim = new ()
            {
                Main = this
            };

            foreach(string sec in SeccionBox.Items) elim.Secciones.Add(sec);

            elim.Inicializar();
        }
    }
}

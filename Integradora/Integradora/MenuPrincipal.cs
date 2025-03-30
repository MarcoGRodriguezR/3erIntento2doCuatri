using Integradora.Inventario;
using System.Collections.Generic;
using System.Data.SQLite;
//using System.Data.Nuget

namespace Integradora
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();

            Database();

            Elemento elem = new("Productos", "Hueso Vegano");
            //Manager.InsertInto("Elementos", elem.ObtenerDatosPalInsert());
            Manager.ActualizarBaseDeDatos(ref Testo);

            #region Creacion de un inventario por ahora
            //Manager.Secciones.Add(new("Productos", [
            //    new ("Hamburguesa", 90, 90),
            //    new ("Pizza", 0, 30),
            //    new ("Salsa", 10, 40)
            //    ]));

            //Manager.Secciones.Add(new("Electronicos", [
            //    new ("Television rota", 2, 0),
            //    new ("Tostadora bluetooth", 99, 9999),
            //    new ("Espatula electrica", 10, 5)
            //    ]));
            #endregion
        }

        private void Database()
        {
            string dbPath = Manager.dbPath;

            if (!File.Exists(dbPath))
                SQLiteConnection.CreateFile(dbPath);

            //Manager.ExecuteNonQuery("drop table elementos");

            using (SQLiteConnection connection = new(Manager.ConnectionString))
            {
                connection.Open();
                string createTableQuery = "CREATE TABLE IF NOT EXISTS Elementos (" +
                    "ID INTEGER PRIMARY KEY AUTOINCREMENT," +
                    "Seccion varchar(100) not null," +
                    "Nombre varchar(100) not null," +
                    "Unidades integer not null," +
                    "Ventas integer not null" +
                    ");";
                using (SQLiteCommand command = new(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        #region Metodo de click o similares
        private void Cerrar_Click(object sender, EventArgs e)
        {
            SetVisibleCore(false);
            Dispose();
        }

        private void Inventario_Click(object sender, EventArgs e)
        {
            _ = new MenuInventario();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Testo.Text = "";
            Manager.ActualizarBaseDeDatos(ref Testo);
        }
    }
}

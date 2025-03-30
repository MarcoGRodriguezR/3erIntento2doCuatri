using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Integradora;
public static class Manager
{
    public static List<Seccion> Secciones = [];

    public const string dbPath = "ServiKino.sqlite";
    public static readonly string ConnectionString = $"Data Source={dbPath};Version=3;";

    public static void ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
    {
        using (SQLiteConnection connection = new(ConnectionString))
        {
            connection.Open();
            using (SQLiteCommand command = new(query, connection))
            {
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }
                command.ExecuteNonQuery();
            }
        }
    }

    /// <summary>
    /// Para crear mesas en la base de datos
    /// </summary>
    /// <param name="tableName">Nombre de la mesa</param>
    /// <param name="columns">Los parametros de la mesa a insertar</param>
    public static void CreateTable(string tableName, string columns) => ExecuteNonQuery($"CREATE TABLE IF NOT EXISTS {tableName} ({columns})");

    /// <summary>
    /// Insertar una instancia a una mesa (un registro)
    /// </summary>
    /// <param name="tableName">A que mesa se va agregar el elemento</param>
    /// <param name="values">Los valores</param>
    public static void InsertInto(string tableName, Dictionary<string, object> values)
    {
        string columns = string.Join(", ", values.Keys);
        string placeholders = string.Join(", @", values.Keys);
        string query = $"INSERT INTO {tableName} ({columns}) VALUES (@{placeholders})";
        ExecuteNonQuery(query, values);
    }

    public static void Update(string tableName, Dictionary<string, object> values, string condition)
    {
        string setClause = string.Join(", ", values.Keys) + "=@..."; //<col in DB > like Eg Main Name=
    }

    public static List<Dictionary<string, object>> SelectFrom(string tableName, string columns, string whereCondition = null, Dictionary<string, object> parameters = null)
    {
        var results = new List<Dictionary<string, object>>();
        string query = $"SELECT {columns} FROM {tableName}";

        // Agregar cláusula WHERE si se especifica
        if (!string.IsNullOrEmpty(whereCondition))
        {
            query += $" WHERE {whereCondition}";
        }

        using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
        {
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                // Agregar parámetros al comando si se proporcionan
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var row = new Dictionary<string, object>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row[reader.GetName(i)] = reader.GetValue(i);
                        }
                        results.Add(row);
                    }
                }
            }
        }

        return results;
    }

    public static void ActualizarBaseDeDatos()
    {
        if (!File.Exists(dbPath)) throw new Exception();

        Secciones.Clear();

        List<Dictionary<string, object>> leCosos = SelectFrom("Elementos Group by Seccion", "Seccion");

        foreach (Dictionary<string, object> leCoso in leCosos)
        {
            foreach (var elCoso in leCoso)
            {
                string? nombreSeccion = elCoso.Value.ToString();
                nombreSeccion ??= $"error en {elCoso.Key}";

                Secciones.Add(new(nombreSeccion, []));
            }
        }

        foreach (Seccion seccion in Secciones)
        {
            leCosos = SelectFrom("Elementos", "*", $"Seccion = '{seccion.Nombre}'");
            foreach (var elCoso in leCosos)
            {
                long? ID = null, Unidades = null, Ventas = null;
                string? Nombre = null;
                foreach (var ele in elCoso)
                {
                    if (ele.Key == "Seccion") continue;
                    switch (ele.Key)
                    {
                        case "Nombre": Nombre = ele.Value.ToString(); break;
                        case "ID": ID = (long)ele.Value; break;
                        case "Unidades": Unidades = (long)ele.Value; break;
                        case "Ventas": Ventas = (long)ele.Value; break;
                        default: throw new Exception($"{ele.Key} no se ha reconocido");
                    }
                }
                if (ID != null && Nombre != null && Unidades != null && Ventas != null)
                    seccion.Elementos.Add(new Elemento(seccion.Nombre, Nombre, (int)Unidades, (int)Ventas, (int)ID));
            }

        }
    }
    public static void ActualizarBaseDeDatos(ref RichTextBox? Testo)
    {
        if (!File.Exists(dbPath)) throw new Exception();

        Secciones.Clear();

        List<Dictionary<string, object>> leCosos = SelectFrom("Elementos Group by Seccion", "Seccion");

        foreach (Dictionary<string, object> leCoso in leCosos)
        {
            foreach (var elCoso in leCoso)
            {
                string? nombreSeccion = elCoso.Value.ToString();
                nombreSeccion ??= $"error en {elCoso.Key}";

                Secciones.Add(new(nombreSeccion, []));
            }
        }

        foreach (Seccion seccion in Secciones)
        {
            leCosos = SelectFrom("Elementos", "*", $"Seccion = '{seccion.Nombre}'");
            foreach (var elCoso in leCosos)
            {
                long? ID = null, Unidades = null, Ventas = null;
                string? Nombre = null;
                foreach (var ele in elCoso)
                {
                    if (ele.Key == "Seccion") continue;
                    switch (ele.Key)
                    {
                        case "Nombre": Nombre = ele.Value.ToString(); break;
                        case "ID": ID = (long)ele.Value; break;
                        case "Unidades": Unidades = (long)ele.Value; break;
                        case "Ventas": Ventas = (long)ele.Value; break;
                        default: throw new Exception($"{ele.Key} no se ha reconocido");
                    }
                }
                if (ID != null && Nombre != null && Unidades != null && Ventas != null)
                    seccion.Elementos.Add(new Elemento(seccion.Nombre, Nombre, (int)Unidades, (int)Ventas, (int)ID));
            }

            if (Testo != null) Testo.Text += $"{seccion}\n";


        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora;
public class DataBaseManager (string dbPath)
{
    private readonly string _connectionString = $"Data Source={dbPath};Version=3;";

    private void ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
    {
        using (SQLiteConnection connection = new (_connectionString))
        {
            connection.Open();
            using (SQLiteCommand command = new (query, connection))
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
    public void CreateTable(string tableName, string columns) => ExecuteNonQuery($"CREATE TABLE IF NOT EXISTS {tableName} ({columns})");

    /// <summary>
    /// Insertar una instancia a una mesa (un registro)
    /// </summary>
    /// <param name="tableName">A que mesa se va agregar el elemento</param>
    /// <param name="values">Los valores</param>
    public void InsertInto(string tableName, Dictionary<string, object> values)
    {
        string columns = string.Join(", ", values.Keys);
        string placeholders = string.Join(", ", values.Keys).Replace(",", ", @");
        string query = $"INSERT INTO {tableName} ({columns}) VALUES (@{placeholders})";
        ExecuteNonQuery(query, values);
    }

    public void Update(string tableName, Dictionary<string, object> values, string condition)
    {
        string setClause = string.Join(", ", values.Keys) + "=@..."; //<col in DB > like Eg Main Name=
    }
}


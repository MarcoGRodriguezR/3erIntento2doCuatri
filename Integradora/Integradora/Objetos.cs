using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora;

/// <summary>
/// Lista de <see cref="Elemento"/>
/// <param name="nombre">Nombre de la seccion</param>
/// </summary>
public class Seccion(string nombre, Elemento[] elementos)
{
    public string Nombre = nombre;
    public List<Elemento> Elementos = elementos.ToList();

    public override string ToString()
    {
        string nombres = "";
        foreach (Elemento elemento in Elementos) nombres += $"{elemento.Nombre}({elemento.ID}), ";

        return $"Seccion de nombre {Nombre} {Elementos.Count}\n" +
            $"  {nombres}";
    }
}

/// <summary>
/// El elemento de una <see cref="Seccion"/>, por ejemplo hamburguesa, tv, celular, etc
/// </summary>
/// <param name="nombre">Nombre del producto</param>
/// <param name="id">ID unica del producto</param>
/// <param name="unidades">Unidades en existencia</param>
/// <param name="ventas">Ventas totales</param>
public class Elemento(string seccion, string nombre, int unidades = 0, int ventas = 0, int id = 0)
{
    public string Nombre = nombre;
    public int ID = id;
    public int Unidades = unidades;
    public int Ventas = ventas;
    public string Seccion = seccion;

    public override string ToString() =>
        $"Nombre: {Nombre}, ID: {ID}; \n" +
        $"Viene de la seccion: {Seccion} \n" +
        $"{Unidades} unidad(es) \n" +
        $"{Ventas} ventas \n";

    public Dictionary<string, object> ObtenerDatosPalInsert()
    {
        Dictionary<string, object> dict = [];

        dict.Add("Seccion", Seccion);
        dict.Add("Nombre", Nombre);
        dict.Add("Unidades", Unidades);
        dict.Add("Ventas", Ventas);

        return dict;
    }
}

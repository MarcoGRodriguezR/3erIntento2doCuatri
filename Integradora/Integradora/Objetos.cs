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
}

/// <summary>
/// El elemento de una <see cref="Seccion"/>, por ejemplo hamburguesa, tv, celular, etc
/// </summary>
/// <param name="nombre">Nombre del producto</param>
/// <param name="id">ID unica del producto</param>
/// <param name="unidades">Unidades en existencia</param>
/// <param name="ventas">Ventas totales</param>
public class Elemento(string nombre, int id, int unidades, int ventas)
{
    public string Nombre = nombre;
    public int ID = id;
    public int Unidades = unidades;
    public int Ventas = ventas;

    public override string ToString() =>
        $"Nombre: {Nombre} \n" +
        $"{Unidades} unidad(es) \n" +
        $"{Ventas} ventas \n";
}

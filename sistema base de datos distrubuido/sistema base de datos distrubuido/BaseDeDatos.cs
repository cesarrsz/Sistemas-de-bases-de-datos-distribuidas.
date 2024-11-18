using System;
using System.Collections.Generic;

class BaseDeDatos
{
    public string NombreNodo { get; set; }
    private Dictionary<string, string> datos;

    public BaseDeDatos(string nombreNodo)
    {
        NombreNodo = nombreNodo;
        datos = new Dictionary<string, string>();
    }

    // Agregar datos
    public void AgregarDato(string clave, string valor)
    {
        datos[clave] = valor;
    }

    // Obtener dato por clave
    public string ObtenerDato(string clave)
    {
        return datos.ContainsKey(clave) ? datos[clave] : null;
    }

    // Mostrar todos los datos
    public void MostrarDatos()
    {
        Console.WriteLine($"Datos en el nodo {NombreNodo}:");
        foreach (var item in datos)
        {
            Console.WriteLine($"Clave: {item.Key}, Valor: {item.Value}");
        }
        Console.WriteLine();
    }
}

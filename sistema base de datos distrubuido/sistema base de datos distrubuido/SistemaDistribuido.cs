using System.Collections.Generic;
using System;

class SistemaDistribuido
{
    private List<BaseDeDatos> nodos;

    public SistemaDistribuido()
    {
        nodos = new List<BaseDeDatos>();
    }

    // Agregar un nodo al sistema
    public void AgregarNodo(BaseDeDatos nodo)
    {
        nodos.Add(nodo);
    }

    // Consultar datos en todos los nodos
    public void ConsultarDato(string clave)
    {
        Console.WriteLine($"Buscando la clave '{clave}' en todos los nodos...\n");
        foreach (var nodo in nodos)
        {
            string resultado = nodo.ObtenerDato(clave);
            if (resultado != null)
            {
                Console.WriteLine($"Encontrado en el nodo {nodo.NombreNodo}: {resultado}");
                return;
            }
        }
        Console.WriteLine($"La clave '{clave}' no fue encontrada en ningún nodo.\n");
    }

    // Actualizar datos en todos los nodos
    public void ActualizarDato(string clave, string nuevoValor)
    {
        Console.WriteLine($"Actualizando la clave '{clave}' en todos los nodos...\n");
        foreach (var nodo in nodos)
        {
            if (nodo.ObtenerDato(clave) != null)
            {
                nodo.AgregarDato(clave, nuevoValor);
                Console.WriteLine($"Clave '{clave}' actualizada en el nodo {nodo.NombreNodo}.");
            }
        }
        Console.WriteLine("Actualización completada.\n");
    }

    // Mostrar datos en todos los nodos
    public void MostrarTodosLosDatos()
    {
        Console.WriteLine("Mostrando los datos de todos los nodos:");
        foreach (var nodo in nodos)
        {
            nodo.MostrarDatos();
        }
    }
}


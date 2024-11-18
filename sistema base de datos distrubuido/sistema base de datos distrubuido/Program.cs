using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        // Crear sistema distribuido
        SistemaDistribuido sistema = new SistemaDistribuido();

        // Crear nodos (bases de datos)
        BaseDeDatos nodo1 = new BaseDeDatos("Nodo1");
        BaseDeDatos nodo2 = new BaseDeDatos("Nodo2");
        BaseDeDatos nodo3 = new BaseDeDatos("Nodo3");

        // Agregar nodos al sistema
        sistema.AgregarNodo(nodo1);
        sistema.AgregarNodo(nodo2);
        sistema.AgregarNodo(nodo3);

        // Agregar datos a los nodos
        nodo1.AgregarDato("Usuario1", "César Sánchez");
        nodo1.AgregarDato("Usuario2", "Rubén Riojas");

        nodo2.AgregarDato("Usuario3", "María López");
        nodo2.AgregarDato("Usuario4", "José Hernández");

        nodo3.AgregarDato("Usuario5", "Ana Gómez");

        // Mostrar todos los datos
        sistema.MostrarTodosLosDatos();

        // Consultar un dato específico
        Console.WriteLine("=== CONSULTAR ===");
        sistema.ConsultarDato("Usuario3");

        // Actualizar un dato
        Console.WriteLine("=== ACTUALIZAR ===");
        sistema.ActualizarDato("Usuario3", "María Ramírez");

        // Mostrar todos los datos después de la actualización
        sistema.MostrarTodosLosDatos();

        // Intentar consultar un dato inexistente
        Console.WriteLine("=== CONSULTAR INEXISTENTE ===");
        sistema.ConsultarDato("Usuario6");

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}


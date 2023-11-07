using System;
namespace Tarea;
class Program
{
    static void Main(string[] args)
    {
        // Ejercicio 7: Ingresar una palabra en un arreglo y ordenarlo en orden alfabético
        Console.Write("Ingresa una palabra: ");
        string? palabra = Console.ReadLine();

        if (!string.IsNullOrEmpty(palabra))
        {
            char[] arregloPalabra = palabra.ToCharArray();
            OrdenarArregloPalabra(arregloPalabra);

            // Imprimir el arreglo de palabra ordenada
            Console.WriteLine("Ejercicio 7: Arreglo de Palabra Ordenada: " + new string(arregloPalabra));
        }
        else
        {
            Console.WriteLine("La palabra ingresada es nula o vacía.");
        }
    }

    static void OrdenarArregloPalabra(char[] arreglo)
    {
        Array.Sort(arreglo, StringComparer.OrdinalIgnoreCase);
    }
}
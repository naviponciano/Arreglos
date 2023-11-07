using System;
namespace Tarea;
class Program
{
    static void Main(string[] args)
    {
        // Ejercicio 2: Alimentar un arreglo de manera dinámica
        Console.Write("Ingresa la longitud del arreglo: ");
        if (int.TryParse(Console.ReadLine(), out int longitud))
        {
            int[] arregloDinamico = GenerarArregloDinamico(longitud);

            // Imprimir el arreglo
            Console.WriteLine("Ejercicio 2: Arreglo Dinámico: " + string.Join(", ", arregloDinamico));
        }
        else
        {
            Console.WriteLine("La entrada no es un número válido.");
        }
    }

    static int[] GenerarArregloDinamico(int longitud)
    {
        int[] arreglo = new int[longitud];
        for (int i = 0; i < longitud; i++)
        {
            Console.Write($"Ingresa el valor {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int valor))
            {
                arreglo[i] = valor;
            }
            else
            {
                Console.WriteLine("El valor ingresado no es un número válido. Se establecerá como 0.");
            }
        }
        return arreglo;
    }
}

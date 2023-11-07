using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // Ejercicio 4: Alimentar un arreglo sin permitir duplicados
        Console.Write("Ingresa la longitud del arreglo: ");
        if (int.TryParse(Console.ReadLine(), out int longitud) && longitud > 0)
        {
            int[] arregloSinDuplicados = GenerarArregloSinDuplicados(longitud);

            // Imprimir el arreglo sin duplicados
            Console.WriteLine("Ejercicio 4: Arreglo sin Duplicados: " + string.Join(", ", arregloSinDuplicados));
        }
        else
        {
            Console.WriteLine("La entrada no es una longitud válida.");
        }
    }

    static int[] GenerarArregloSinDuplicados(int longitud)
    {
        HashSet<int> valores = new HashSet<int>();
        int[] arreglo = new int[longitud];

        for (int i = 0; i < longitud; i++)
        {
            int valor;

            do
            {
                Console.Write($"Ingresa el valor {i + 1}: ");
            }
            while (!int.TryParse(Console.ReadLine(), out valor) || !valores.Add(valor));

            arreglo[i] = valor;
        }
        return arreglo;
    }
}
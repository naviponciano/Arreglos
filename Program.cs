using System;

namespace NavieskaArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int Tamaño = 5;
            int Contar = 0;
            int[] Numeros = new int[Tamaño];

            for (int i = 0; i < Tamaño; i++)
            {
                Console.Write($"Ingrese el Numero ({i + 1}): ");
                string? input = Console.ReadLine();

                if (input != null)
                {
                    if (int.TryParse(input, out int numero))
                    {
                        Numeros[i] = numero;
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
                        i--; // Repetir la entrada para el mismo índice.
                    }
                }
                else
                {
                    Console.WriteLine("No se pudo leer más entrada. Finalizando el programa.");
                    break; // Salir del bucle si no hay más entrada.
                }
            }

            for (int i = 0; i < Tamaño; i++)
            {
                Contar += Numeros[i];
                Console.WriteLine($"El valor de Suma en la posición ({i}) es ({Contar})");
            }

            Console.WriteLine("La suma total de los elementos del Arreglo es: " + Contar);
        }
    }
}

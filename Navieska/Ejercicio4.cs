using System;
using System.Collections.Generic;

public class Ejercicio4
{
    public void Ejecutar()
    {
        Console.WriteLine("Ejercicio 4: Alimentar un arreglo sin permitir duplicados");

        List<int> listaConDuplicados = new List<int>();
        List<int> listaSinDuplicados = new List<int>();

        Console.Write("Ingresa la cantidad de elementos del arreglo: ");
        if (int.TryParse(Console.ReadLine(), out int cantidadElementos))
        {
            for (int i = 0; i < cantidadElementos; i++)
            {
                Console.Write($"Ingresa el valor {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int valor))
                {
                    if (!listaConDuplicados.Contains(valor))
                    {
                        listaConDuplicados.Add(valor);
                        listaSinDuplicados.Add(valor);
                    }
                    else
                    {
                        Console.WriteLine("Advertencia: El valor ya ha sido ingresado. Ingresa un valor distinto.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Debes ingresar un número entero.");
                    i--; // Repetir la entrada para este índice
                }
            }

            Console.WriteLine("Arreglo original con duplicados: " + string.Join(", ", listaConDuplicados));
            Console.WriteLine("Arreglo sin duplicados: " + string.Join(", ", listaSinDuplicados));
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debes ingresar un número entero para la cantidad de elementos.");
        }
    }
}

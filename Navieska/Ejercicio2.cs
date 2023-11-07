using System;

public class Ejercicio2
{
    public void Ejecutar()
    {
        Console.WriteLine("Ejercicio 2: Alimentar un arreglo de manera dinámica");

        int longitud = 0;
        bool longitudValida = false;

        while (!longitudValida)
        {
            Console.Write("Ingresa la longitud del arreglo: ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out longitud) && longitud > 0)
            {
                longitudValida = true;
            }
            else
            {
                Console.WriteLine("Por favor, ingresa una longitud válida (un número mayor que 0).");
            }
        }

        int[] arregloDinamico = new int[longitud];

        for (int i = 0; i < arregloDinamico.Length; i++)
        {
            bool valorValido = false;
            while (!valorValido)
            {
                Console.Write($"Ingresa el valor {i + 1}: ");
                string? valorStr = Console.ReadLine();

                if (int.TryParse(valorStr, out int valor))
                {
                    arregloDinamico[i] = valor;
                    valorValido = true;
                }
                else
                {
                    Console.WriteLine("Por favor, ingresa un valor válido (número entero).");
                }
            }
        }

        Console.WriteLine("Arreglo dinámico:");
        foreach (int numero in arregloDinamico)
        {
            Console.Write(numero + " ");
        }

        Console.WriteLine();
    }
}

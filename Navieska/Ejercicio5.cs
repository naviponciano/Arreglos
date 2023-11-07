using System;

public class Ejercicio5
{
    public void Ejecutar()
    {
        Console.WriteLine("Ejercicio 5: Multiplicar dos arreglos y añadir el resultado a un tercero");

        Console.Write("Ingresa la longitud de los arreglos: ");
        if (int.TryParse(Console.ReadLine(), out int longitud) && longitud > 0)
        {
            int[] arreglo1 = new int[longitud];
            int[] arreglo2 = new int[longitud];
            int[] arregloResultado = new int[longitud];

            Console.WriteLine("Ingresa los valores del primer arreglo:");
            for (int i = 0; i < longitud; i++)
            {
                Console.Write($"Ingresa el valor {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int valor))
                {
                    arreglo1[i] = valor;
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Debes ingresar un número entero.");
                    i--; // Repetir la entrada para este índice
                }
            }
            Console.WriteLine("");

            Console.WriteLine("Ingresa los valores del segundo arreglo:");
            for (int i = 0; i < longitud; i++)
            {
                Console.Write($"Ingresa el valor {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int valor))
                {
                    arreglo2[i] = valor;
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Debes ingresar un número entero.");
                    i--; // Repetir la entrada para este índice
                }
            }

            for (int i = 0; i < longitud; i++)
            {
                arregloResultado[i] = arreglo1[i] * arreglo2[i];
            }

            Console.WriteLine("Arreglo Resultado: " + string.Join(", ", arregloResultado));
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debes ingresar un número entero positivo para la longitud de los arreglos.");
        }
    }
}

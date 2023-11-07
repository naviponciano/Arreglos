using System;

public class Ejercicio3
{
    public void Ejecutar()
    {
        Console.WriteLine("Ejercicio 3: Buscar un valor dentro de un arreglo");

        int[] arregloDinamico = { 1, 2, 3, 4, 5 }; // Puedes reemplazar esto con tu propio arreglo

        Console.Write("Ingresa el valor a buscar: ");
        string? entrada = Console.ReadLine();

        if (entrada != null)
        {
            if (int.TryParse(entrada, out int valorBuscado))
            {
                bool encontrado = false;
                foreach (int elemento in arregloDinamico)
                {
                    if (elemento == valorBuscado)
                    {
                        encontrado = true;
                        break;
                    }
                }

                if (encontrado)
                {
                    Console.WriteLine($"El valor {valorBuscado} se encuentra en el arreglo.");
                }
                else
                {
                    Console.WriteLine($"El valor {valorBuscado} no se encuentra en el arreglo.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Debes ingresar un número entero.");
            }
        }
        else
        {
            Console.WriteLine("Entrada nula. Debes ingresar un número entero.");
        }
    }
}

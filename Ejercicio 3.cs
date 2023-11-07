using System;
namespace Tarea;
class Program{
    static void Main(string[] args)
    {
        // Generar un arreglo dinámico con valores de ejemplo
        int[] arregloDinamico = { 10, 20, 30, 40, 50 };

        // Ejercicio 3: Buscar un valor dentro de un arreglo
        Console.Write("Ingresa el valor a buscar: ");
        if (int.TryParse(Console.ReadLine(), out int valorBuscado))
        {
            bool encontrado = BuscarValorEnArreglo(arregloDinamico, valorBuscado);

            if (encontrado)
            {
                Console.WriteLine("El valor {0} se encuentra en el arreglo.", valorBuscado);
            }
            else
            {
                Console.WriteLine("El valor {0} no se encuentra en el arreglo.", valorBuscado);
            }
        }
        else
        {
            Console.WriteLine("La entrada no es un número válido.");
        }
    }

    static bool BuscarValorEnArreglo(int[] arreglo, int valor)
    {
        foreach (int elemento in arreglo)
        {
            if (elemento == valor)
            {
                return true;
            }
        }
        return false;
    }
}

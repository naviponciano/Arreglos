using System;
namespace Tarea;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al programa de multiplicación de arreglos.");
        Console.Write("Ingresa la longitud de los arreglos: ");

        if (int.TryParse(Console.ReadLine(), out int longitud) && longitud > 0)
        {
            int[] arreglo1 = ObtenerArreglo("primer", longitud);
            int[] arreglo2 = ObtenerArreglo("segundo", longitud);

            if (arreglo1.Length != arreglo2.Length)
            {
                Console.WriteLine("Los arreglos deben tener la misma longitud para multiplicarlos.");
            }
            else
            {
                int[] arregloResultado = MultiplicarArreglos(arreglo1, arreglo2);
                Console.WriteLine("Ejercicio 5: Multiplicación de Arreglos");
                ImprimirArreglo("Primer Arreglo: ", arreglo1);
                ImprimirArreglo("Segundo Arreglo: ", arreglo2);
                ImprimirArreglo("Resultado: ", arregloResultado);
            }
        }
        else
        {
            Console.WriteLine("La entrada no es una longitud válida.");
        }
    }

    static int[] ObtenerArreglo(string nombre, int longitud)
    {
        int[] arreglo = new int[longitud];

        for (int i = 0; i < longitud; i++)
        {
            Console.Write($"Ingresa el valor {i + 1} del {nombre} arreglo: ");
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

    static int[] MultiplicarArreglos(int[] arreglo1, int[] arreglo2)
    {
        int longitud = Math.Min(arreglo1.Length, arreglo2.Length);
        int[] arregloResultado = new int[longitud];

        for (int i = 0; i < longitud; i++)
        {
            arregloResultado[i] = arreglo1[i] * arreglo2[i];
        }

        return arregloResultado;
    }

    static void ImprimirArreglo(string titulo, int[] arreglo)
    {
        Console.WriteLine(titulo + string.Join(", ", arreglo));
    }
}
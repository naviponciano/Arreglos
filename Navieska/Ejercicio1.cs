using System;

public class Ejercicio1
{
    public void Ejecutar()
    {
        Console.WriteLine("Ejercicio 1: Alimentar un arreglo de manera estática");

        // Declarar un arreglo de enteros y asignar valores estáticos
        int[] arregloEstatico = { 1, 2, 3, 4, 5 };

        // Mostrar el arreglo en la consola
        Console.Write("Arreglo estático: ");
        foreach (int numero in arregloEstatico)
        {
            Console.Write(numero + " ");
        }

        Console.WriteLine();
    }
}

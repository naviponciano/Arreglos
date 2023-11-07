using System;

class Program
{
    static void Main(string[] args)
    {
        // Ejercicio 1: Alimentar un arreglo de manera estática
        int[] arregloEstatico = GenerarArregloEstatico(5);
        
        // Imprimir el arreglo
        Console.WriteLine("Ejercicio 1: Arreglo Estático: " + string.Join(", ", arregloEstatico));
    }

    static int[] GenerarArregloEstatico(int tamaño)
    {
        int[] arreglo = new int[tamaño];
        for (int i = 0; i < tamaño; i++)
        {
            arreglo[i] = i + 1;
        }
        return arreglo;
    }
}
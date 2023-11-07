using System;

public class Ejercicio6
{
    public void Ejecutar()
    {
        Console.WriteLine("Ejercicio 6: Ingresar una palabra en un arreglo");

        Console.Write("Ingresa una palabra: ");
        string? palabra = Console.ReadLine();

        if (palabra != null)
        {
            char[] arregloPalabra = new char[palabra.Length];
            for (int i = 0; i < palabra.Length; i++)
            {
                arregloPalabra[i] = palabra[i];
            }

            Console.WriteLine("Ejercicio 6: Arreglo de Palabra: " + new string(arregloPalabra));
        }
        else
        {
            Console.WriteLine("La palabra ingresada es nula.");
        }
    }
}

using System;

public class Ejercicio7
{
    public void Ejecutar()
    {
        Console.WriteLine("Ejercicio 7: Ingresar una palabra en un arreglo y ordenarlo en orden alfabético");

        Console.Write("Ingresa una palabra: ");
        string? palabra = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(palabra))
        {
            Console.WriteLine("La entrada es inválida. Ingresa una palabra válida.");
            return;
        }

        char[] arregloPalabra = palabra.ToCharArray();

        for (int i = 0; i < arregloPalabra.Length; i++)
        {
            for (int j = i + 1; j < arregloPalabra.Length; j++)
            {
                if (arregloPalabra[i] > arregloPalabra[j])
                {
                    char temp = arregloPalabra[i];
                    arregloPalabra[i] = arregloPalabra[j];
                    arregloPalabra[j] = temp;
                }
            }
        }

        Console.Write("Arreglo de Palabra Ordenada: ");
        foreach (char c in arregloPalabra)
        {
            Console.Write(c);
        }

        Console.WriteLine();
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menú de Ejercicios en C#");
            Console.WriteLine("1. Ejercicio 1: Alimentar un arreglo de manera estática");
            Console.WriteLine("2. Ejercicio 2: Alimentar un arreglo de manera dinámica");
            Console.WriteLine("3. Ejercicio 3: Buscar un valor dentro de un arreglo");
            Console.WriteLine("4. Ejercicio 4: Alimentar un arreglo sin permitir duplicados");
            Console.WriteLine("5. Ejercicio 5: Multiplicar dos arreglos y añadir el resultado a un tercero");
            Console.WriteLine("6. Ejercicio 6: Ingresar una palabra en un arreglo");
            Console.WriteLine("7. Ejercicio 7: Ingresar una palabra en un arreglo y ordenarlo en orden alfabético");
            Console.WriteLine("8. Salir");

            Console.Write("Seleccione una opción: ");
            string? opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    new Ejercicio1().Ejecutar();
                    break;
                case "2":
                    new Ejercicio2().Ejecutar();
                    break;
                case "3":
                    new Ejercicio3().Ejecutar();
                    break;
                case "4":
                    new Ejercicio4().Ejecutar();
                    break;
                case "5":
                    new Ejercicio5().Ejecutar();
                    break;
                case "6":
                    new Ejercicio6().Ejecutar();
                    break;
                case "7":
                    new Ejercicio7().Ejecutar();
                    break;
                case "8":
                    Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }
        }
    }
}

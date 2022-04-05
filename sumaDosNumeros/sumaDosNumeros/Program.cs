using System;

public class Sum
{
    private static void Main()
    {
        Console.WriteLine("Ingresa dos valores separados '+' y pulsa enter. Ejemplo 50+32");
        string[] valores = Console.ReadLine().Split('+');
        int total = int.Parse(valores[0]) + int.Parse (valores[1]);
        Console.WriteLine( total);

        Console.ReadKey();

    }
}

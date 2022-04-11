using System;

namespace sumaValoresBucleFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de numeros a sumar:");
            int cantidadValores = int.Parse(Console.ReadLine()); 
            int[] conversion = Array.ConvertAll((Console.ReadLine()).Split(' '), int.Parse);
            int suma = 0;

            for (int i = 0; i < cantidadValores; i++)
            {
                suma += conversion[i];
            }
            Console.WriteLine(suma);


            Console.ReadKey();
        }
    }
}
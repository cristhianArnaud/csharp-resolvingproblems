using System;

namespace sumaValoresBucleFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadValores = int.Parse(Console.ReadLine());
            string[] valores = (Console.ReadLine()).Split(' '); //Version mas restringida
            int[] conversion = Array.ConvertAll(valores, int.Parse);
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
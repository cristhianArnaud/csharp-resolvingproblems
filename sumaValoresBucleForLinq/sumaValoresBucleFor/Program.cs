using System;
using System.Collections.Generic;
using System.Linq;

namespace sumaFilasMatrizBucleFor
{
    class Program
    {
        static void Main(string[] args)
        {

            var cantidadLineas = int.Parse(Console.ReadLine());

            var valores = new List<int>();

            for (var i = 0; i < cantidadLineas; i++)
            {
                valores.Add(Console.ReadLine().Split(' ').Select(int.Parse).Sum());
            }

            Console.WriteLine(string.Join(" ", valores));

        }
    }
}

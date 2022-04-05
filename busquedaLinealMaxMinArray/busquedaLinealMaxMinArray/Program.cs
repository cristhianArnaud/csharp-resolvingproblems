using System;

namespace busquedaLinealMaxMinArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese por favor los valores a analizar separados por un espacio");

            string[] valores = Console.ReadLine().Split(" ");

            int max = 0;
            int min = 0;

            for (int i=0; i<300; i++)
            {
                    if (int.Parse(valores[i]) >= max)
                {
                    max = int.Parse(valores[i]);
                }

                else if (int.Parse(valores[i]) <= min)
                    min = int.Parse(valores[i]);
            }

            Console.WriteLine("El valor mínimo es "+min +" y el valor máximo es "+max);
        }
    }
}

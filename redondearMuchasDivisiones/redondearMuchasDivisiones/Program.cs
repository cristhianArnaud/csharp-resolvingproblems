using System;

namespace redondearMuchasDivisiones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qué cantidad de divisiones realizará?");
            int divisiones = int.Parse(Console.ReadLine());
            string[] valores;

            double p0 = 1.15;
            double p1 = 1.49;
            double p2 = 1.51;
            double p3 = -1.49;

            Console.WriteLine(Math.Round(p3));


            for (int i=0; i<divisiones; i++)
            {
                int residuo;

            }
        }
    }
}

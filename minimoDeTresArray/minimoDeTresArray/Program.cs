using System;

namespace minimoDeTresArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MINIMO DE DOS NUMEROS, QUE CANTIDAD DE NUEVOS VA A COMPARAR: ");

            int fila = int.Parse(Console.ReadLine());
            string[] valores;
            int[] menorValor = new int[fila];

            for (int i = 0; i < fila; i++) //Rows 
            {
                valores = Console.ReadLine().Split(' ');
                int a = int.Parse(valores[0]); int b = int.Parse(valores[1]); int c = int.Parse(valores[2]);
                if (a <= b && a <= c)
                {
                    menorValor[i] = a;
                }
                else if (b <= a && b <= c) 
                    menorValor[i] = b;
                else if (c<a&&c<b) menorValor[i] = c;
            }

            for (int i = 0; i < fila; i++)
            {
                Console.Write(menorValor[i] + " ");
            }

            Console.ReadKey();
        }
    }
}

using System;

namespace sumaFilasMatrizBucleFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MINIMO DE DOS NUMEROS, QUE CANTIDAD DE NUEVOS VA A COMPARAR: ");

            int fila = int.Parse(Console.ReadLine());
            string[] valores;
            int[] menorValor= new int[fila];

            for (int i = 0; i < fila; i++) //Rows 
            {
                valores = Console.ReadLine().Split(' ');
                if (int.Parse(valores[0]) > int.Parse(valores[1]))
                {
                    menorValor[i] = int.Parse(valores[1]);
                }
                else menorValor[i] = int.Parse(valores[0]);

            }

            for (int i = 0; i < fila; i++)
            {
                Console.Write(menorValor[i]+" ");
            }
            
            Console.ReadKey();
        }
    }
}
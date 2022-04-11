using System;

namespace DivisiblesNums
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Dados los números del 1 al 100. 

            Encuentre:

            A- La suma de los números que son divisibles por 5.
            B- La suma de los números que son divisibles por 3.
            C- El resultado de restar A de B. */
            int numMaximo = 1;
            int sumaDivx3 =0;
            int sumaDivx5 =0;
            

            while (numMaximo<=100) {
                if (numMaximo % 3 == 0)
                {
                    sumaDivx3 += numMaximo; 
                } 
                else if (numMaximo % 5 == 0)
                {
                    sumaDivx5 += numMaximo;
                }
                
                numMaximo++;
            }
            Console.WriteLine("La suma de los valores divisibles por 3 es de: " +sumaDivx3+
                "\n La suma de los valores divisibles por 5 es de: "+sumaDivx5+ 
                "\n La resta de ambas cantidades es de: "+(sumaDivx3-sumaDivx5));

        }
    }
}

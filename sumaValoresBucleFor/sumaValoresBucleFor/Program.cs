using System;

namespace sumaFilasMatrizBucleFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese cantidad de filas y columnas ejemplo: 3x2"); 

            string[] matrizise = Console.ReadLine().ToLower().Split('x');
            int fila = int.Parse(matrizise[0]);
            int columna = int.Parse(matrizise[1]);
            int[] resultadoSumaFila = new int [fila]; //In order to use it later


            for (int i=0; i<fila; i++) //Rows 
            {
                int suma = 0;
                for (int j=0; j<columna; j++) //Columns
                {
                    Console.WriteLine("Ingresa el valor de la matriz de la fila ["+i+"] y columna ["+j+"]");
                    int valores =int.Parse(Console.ReadLine());
                    suma += valores;
                }
                resultadoSumaFila[i] = suma; // Sum when a row is complete in an array.
                 
            }

            for (int i = 0; i < fila; i++)
            {

                Console.WriteLine(resultadoSumaFila[i]); //Present the result for each row.
            }
                
            Console.ReadKey();
        }
    }
}

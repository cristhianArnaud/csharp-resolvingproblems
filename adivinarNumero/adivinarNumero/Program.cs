using System;

namespace adivinarNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adivina un numero del 1 al 100 con la cantidad de intentos.

            Random numero = new Random();
            int numeroAleatorio = numero.Next(0,100);

            Console.WriteLine("QUIERES JUGAR A ADIVINAR EL NUMERO DEL 1 AL 100 QUE TENGO EN MENTE?");

            string respuesta = Console.ReadLine();
            int numIntentos = 0;
            int numero1;
           
            Console.WriteLine("En que numero estoy pensando?");

            while (respuesta != "no")

            {
                try
                {
                    numero1 = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("No has introducido un valor numerico valido");
                    numero1 = 0;
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Haz introducido un valor demasiado alto");
                    numero1 = 0;
                }

                numIntentos++;

                if (numero1 == numeroAleatorio)
                {
                    Console.WriteLine($"Haz acertado usando {numIntentos} intentos. Deseas jugar otra vez?");
                    respuesta = Console.ReadLine();
                    if (respuesta != "no") Console.WriteLine("En que numero estoy pensando?");
                }

                else if (numero1 >= numeroAleatorio) Console.WriteLine("Intenta un numero mas bajo");

                else if (numero1 <= numeroAleatorio) Console.WriteLine("Intenta un numero mas alto");

            }
        }
    }
}

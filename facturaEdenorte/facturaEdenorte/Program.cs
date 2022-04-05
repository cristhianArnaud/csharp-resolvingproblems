using System;

namespace facturaEdenorte
{
    class Program
    {
        static void Main(string[] args)
        {

            //Pago cargo fijo por consumo menor o mayor de 100 kwh
            double cargoFijoRHasta100 = 37.95;
            double cargoFijoRDesde101 = 137.25;
            double cargoFijoComercial = 137.67;

            //Cargos por energia en residencias

            double cargoRHasta200 = 4.44;
            double cargoRHasta300 = 6.97;
            double cargoRHasta700 = 10.86;
            double cargoRMayor700 = 11.10;

            //Cargos por energia en oficinas comerciales

            double cargoCHasta200 = 5.97;
            double cargoCHasta300 = 8.62;
            double cargoCHasta700 = 11.30;
            double cargoCMayor700 = 11.49;

            int respuesta = 0;
            double consumokwh0;
            double consumokwh1=0;
            double consumokwh2;
            double consumokwh3;
            double consumoPago =0;


            //Solucion programa

            Console.WriteLine("Bienvenido al sistema de calculo de tu factura de EDENORTE.");
            Console.WriteLine("El calculo es para una (1) Residencia o para (2) un establecimiento comercial?");
            try
            {
                respuesta = int.Parse(Console.ReadLine());
            }
            
            catch (Exception ex)
            { 
                Console.WriteLine("Introduzca un valor valido. (1) Residencia o (2) Establecimiento comercial"); 
            }

            if (respuesta == 1)
            {
                Console.WriteLine($"Cuantos kwh ha consumido en este mes?");
                consumokwh0 = int.Parse(Console.ReadLine());

                if (consumokwh0 < 101)
                { 
                    consumoPago = (consumokwh0 * cargoRHasta200) + cargoFijoRHasta100;
                    Console.WriteLine($"Tendra que pagar un monto total de RD$ {consumoPago} por el consumo de {consumokwh0} kwh desglozado de la siguiente manera:");
                    Console.WriteLine($"{consumokwh0} kwh por el precio de 4.44 mas una cuota fija de {cargoFijoRHasta100}");
                }

                else if (consumokwh0 > 100 && consumokwh0 <= 200)
                {
                    consumokwh1 = consumokwh0 - 100;
                    consumoPago = 100 * cargoRHasta200 + consumokwh1 * cargoRHasta200 + cargoFijoRDesde101;
                    Console.WriteLine($"Tendra que pagar un monto total de RD$ {consumoPago} por el consumo de {consumokwh0} kwh desglozado de la siguiente manera:");
                    Console.WriteLine($"{consumokwh0} kwh por el precio de {cargoRHasta200} mas una cuota fija de {cargoFijoRDesde101}");
                }

                else if (consumokwh0 > 200 && consumokwh0 <= 300)
                { 
                    consumokwh1 = consumokwh0 - 200;
                    consumoPago = 200 * cargoRHasta200 + consumokwh1 * cargoRHasta300 + cargoFijoRDesde101;
                    Console.WriteLine($"Tendra que pagar un monto total de RD$ {consumoPago} por el consumo de {consumokwh0} kwh desglozado de la siguiente manera:");
                    Console.WriteLine($"200 kwh por el precio de {cargoRHasta200}");
                    Console.WriteLine($"{consumokwh1} kwh por el precio de {cargoRHasta300} mas una cuota fija de {cargoFijoRDesde101}");
                }

                else if (consumokwh0 > 300 && consumokwh0 <= 700)

                { 
                    consumokwh1 = consumokwh0 - 200;
                    consumokwh2 = consumokwh1 - 100;
                    consumoPago = 200 * cargoRHasta200 + 100 * cargoRHasta300 + consumokwh2 * cargoRHasta700 + cargoFijoRDesde101;
                    Console.WriteLine($"Tendra que pagar un monto total de RD$ {consumoPago} por el consumo de {consumokwh0} kwh desglozado de la siguiente manera:");
                    Console.WriteLine($"200 kwh por el precio de {cargoRHasta200}");
                    Console.WriteLine($"100 kwh por el precio de {cargoRHasta300}");
                    Console.WriteLine($"{consumokwh2} kwh por el precio de {cargoRHasta700} mas una cuota fija de {cargoFijoRDesde101}");
                }

                else if (consumokwh0 > 700)

                {   consumokwh1 = consumokwh0 - 200;
                    consumokwh2 = consumokwh1 - 100;
                    consumokwh3 = consumokwh2 - 400;
                    consumoPago = 200 * cargoRHasta200 + 100 * cargoRHasta300 + 400 * cargoRHasta700 + consumokwh3 * cargoRMayor700 + cargoFijoRDesde101;
                    Console.WriteLine($"Tendra que pagar un monto total de RD$ {consumoPago} por el consumo de {consumokwh0} kwh desglozado de la siguiente manera:");
                    Console.WriteLine($"200 kwh por el precio de {cargoRHasta200}");
                    Console.WriteLine($"100 kwh por el precio de {cargoRHasta300}");
                    Console.WriteLine($"400 kwh por el precio de {cargoRHasta700}");
                    Console.WriteLine($"{consumokwh3} kwh por el precio de {cargoRMayor700} mas una cuota fija de {cargoFijoRDesde101}");
                }
            
            }

            // Comercial

            if (respuesta == 2)
            {
                Console.WriteLine($"Cuantos kwh ha consumido en este mes?");
                consumokwh0 = int.Parse(Console.ReadLine());

                if (consumokwh0 < 101)
                {
                    consumoPago = (consumokwh0 * cargoCHasta200) + cargoFijoComercial;
                    Console.WriteLine($"Tendra que pagar un monto total de RD$ {consumoPago} por el consumo de {consumokwh0} kwh desglozado de la siguiente manera:");
                    Console.WriteLine($"{consumokwh0} kwh por el precio de 4.44 mas una cuota fija de {cargoFijoComercial}");
                }

                else if (consumokwh0 > 100 && consumokwh0 <= 200)
                {
                    consumokwh1 = consumokwh0 - 100;
                    consumoPago = 100 * cargoCHasta200 + consumokwh1 * cargoCHasta200 + cargoFijoComercial;
                    Console.WriteLine($"Tendra que pagar un monto total de RD$ {consumoPago} por el consumo de {consumokwh0} kwh desglozado de la siguiente manera:");
                    Console.WriteLine($"{consumokwh0} kwh por el precio de {cargoCHasta200} mas una cuota fija de {cargoFijoComercial}");
                }

                else if (consumokwh0 > 200 && consumokwh0 <= 300)
                {
                    consumokwh1 = consumokwh0 - 200;
                    consumoPago = 200 * cargoCHasta200 + consumokwh1 * cargoCHasta300 + cargoFijoComercial;
                    Console.WriteLine($"Tendra que pagar un monto total de RD$ {consumoPago} por el consumo de {consumokwh0} kwh desglozado de la siguiente manera:");
                    Console.WriteLine($"200 kwh por el precio de {cargoCHasta200}");
                    Console.WriteLine($"{consumokwh1} kwh por el precio de {cargoCHasta300} mas una cuota fija de {cargoFijoComercial}");
                }

                else if (consumokwh0 > 300 && consumokwh0 <= 700)

                {
                    consumokwh1 = consumokwh0 - 200;
                    consumokwh2 = consumokwh1 - 100;
                    consumoPago = 200 * cargoCHasta200 + 100 * cargoCHasta300 + consumokwh2 * cargoCHasta700 + cargoFijoComercial;
                    Console.WriteLine($"Tendra que pagar un monto total de RD$ {consumoPago} por el consumo de {consumokwh0} kwh desglozado de la siguiente manera:");
                    Console.WriteLine($"200 kwh por el precio de {cargoCHasta200}");
                    Console.WriteLine($"100 kwh por el precio de {cargoCHasta300}");
                    Console.WriteLine($"{consumokwh2} kwh por el precio de {cargoCHasta700} mas una cuota fija de {cargoFijoComercial}");
                }

                else if (consumokwh0 > 700)

                {
                    consumokwh1 = consumokwh0 - 200;
                    consumokwh2 = consumokwh1 - 100;
                    consumokwh3 = consumokwh2 - 400;
                    consumoPago = 200 * cargoCHasta200 + 100 * cargoCHasta300 + 400 * cargoCHasta700 + consumokwh3 * cargoCMayor700 + cargoFijoComercial;
                    Console.WriteLine($"Tendra que pagar un monto total de RD$ {consumoPago} por el consumo de {consumokwh0} kwh desglozado de la siguiente manera:");
                    Console.WriteLine($"200 kwh por el precio de {cargoCHasta200}");
                    Console.WriteLine($"100 kwh por el precio de {cargoCHasta300}");
                    Console.WriteLine($"400 kwh por el precio de {cargoCHasta700}");
                    Console.WriteLine($"{consumokwh3} kwh por el precio de {cargoCMayor700} mas una cuota fija de {cargoFijoComercial}");
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaPractica1_OM100123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short opcion = 0;
            double temperatura = 0;
            bool isContinue = true;

            Console.WriteLine("Conversor de Temperaturas");

            do
            {
                Console.WriteLine("Elija una Opción");
                Console.WriteLine("Presione 1 para convertir de Fahrenheit a Celius");
                Console.WriteLine("Presione 2 para convertir de Celsius a Fahrenheit");
                Console.WriteLine("Presione 3 para convertir de Celsius a Kelvin");
                opcion = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Digite la temperatura a convertir:");
                temperatura = Convert.ToDouble(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Fahrenheit f = new Fahrenheit(temperatura);
                        double celsius = f.ConvertFahrenheitToCelsius();
                        Console.WriteLine(temperatura + " grados Fahrenheit equivalen a " + celsius + " grados Celsius");
                        break;

                    case 2:
                        Celsius c = new Celsius(temperatura);
                        double fahrenheit = c.ConvertCelsiusToFahrenheit();
                        Console.WriteLine(temperatura + " grados Celsius equivalen a " + fahrenheit + " grados Fahrenheit");
                        break;

                    case 3:
                        Kelvin k = new Kelvin(temperatura);
                        double kelvin = k.ConvertCelsiusToKelvin();
                        Console.WriteLine(temperatura + " grados Celsius equivalen a " + kelvin + " grados Kelvin");
                        break;

                    default:
                        Console.WriteLine("Ingrese una opción válida");
                        break;
                }

                Console.WriteLine("¿Desea continuar? (Y/N)");
                isContinue = Console.ReadLine().ToUpper().Equals("Y");

            } while (isContinue);



        }
    }
}

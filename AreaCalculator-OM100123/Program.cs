using AreaCalculator_OM100123.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator_OM100123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short opcion = 0;
            bool isContinue = true;

            Console.WriteLine("Calculadora de Áreas");
            Console.WriteLine("Oscar Orellana - OM100123");
            Console.WriteLine("Aplicación para el cálculo de figuras geométricas básicas utilizando POO");
            Console.WriteLine("======================================================================\n");

            do
            {
                Console.WriteLine("Ingrese el número de una figura geométrica para calcular su área: ");
                Console.WriteLine("1) Cuadrado");
                Console.WriteLine("2) Rectángulo");
                Console.WriteLine("3) Círculo");
                Console.WriteLine("4) Triángulo");
                opcion = Convert.ToInt16(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CalcularAreaCuadrado();
                        break;

                    case 2:
                        CalcularAreaRectangulo();
                        break;

                    case 3:
                        CalcularAreaCirculo();
                        break;

                    case 4:
                        CalcularAreaTriangulo();
                        break;

                    default:
                        Console.WriteLine("Ingrese una opción válida");
                        break;
                }

                Console.WriteLine("¿Desea continuar? (Y/N)");
                isContinue = Console.ReadLine().ToUpper().Equals("Y");

            } while (isContinue);

        }

        public static void CalcularAreaCuadrado()
        {
            double inputLado = 0;
            Console.WriteLine("Ingrese el valor de un lado del cuadrado (m): ");
            inputLado = Convert.ToDouble(Console.ReadLine());
            Cuadrado c = new Cuadrado(inputLado);
            double area = c.CalculateArea();
            Console.WriteLine("El área del cuadrado es de " + area + " metros cuadrados.");
        }

        public static void CalcularAreaRectangulo()
        {
            (double inputBase, double inputAltura) = IngresarBaseAltura("rectángulo");

            Rectangulo r = new Rectangulo(inputBase, inputAltura);
            double area = r.CalculateArea();
            Console.WriteLine("El área del rectángulo es de " + area + " metros cuadrados.");
        }

        public static void CalcularAreaCirculo()
        {
            double inputRadio = 0;
            Console.WriteLine("Ingrese el valor del radio del círculo (m): ");
            inputRadio = Convert.ToDouble(Console.ReadLine());

            Circulo c = new Circulo(inputRadio);
            double area = c.CalculateArea();
            Console.WriteLine("El área del círculo es de " + area + " metros cuadrados.");
        }

        public static void CalcularAreaTriangulo()
        {
            (double inputBase, double inputAltura) = IngresarBaseAltura("triángulo");

            Triangulo t = new Triangulo(inputBase, inputAltura);
            double area = t.CalculateArea();
            Console.WriteLine("El área del triángulo es de " + area + " metros cuadrados.");
        }

        public static (double, double) IngresarBaseAltura(String figura)
        {
            double inputBase = 0, inputAltura = 0;
            Console.WriteLine("Ingrese los valores de base y altura del " + figura + " (m): ");
            inputBase = Convert.ToDouble(Console.ReadLine());
            inputAltura = Convert.ToDouble(Console.ReadLine());
            return (inputBase, inputAltura);
        }

    }
}

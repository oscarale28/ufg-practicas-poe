using GuiaSobrecarga_OM100123.calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaSobrecarga_OM100123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short opcion = 0;
            bool isContinue = true;

            Console.WriteLine("Calculadora Aritmética");
            Console.WriteLine("Oscar Orellana - OM100123");
            Console.WriteLine("Aplicación para el cálculo de operaciones aritméticas básicas utilizando sobrecarga de métodos");
            Console.WriteLine("======================================================================\n");

            Calculadora calc = new Calculadora();

            do
            {
                Console.WriteLine("Seleccione una operación: ");
                Console.WriteLine("1) Suma");
                Console.WriteLine("2) Resta");
                Console.WriteLine("3) Multiplicación");
                Console.WriteLine("4) División");
                opcion = Convert.ToInt16(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        
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
        
        public static (void) solicitarNumeros()
        {

        }
    
    }
}

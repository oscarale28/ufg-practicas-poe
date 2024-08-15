using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaSobrecarga_OM100123.calculadora
{
    internal class Calculadora
    {
        public Calculadora() { }

        public static int Sumar(int a, int b)
        {
            return a + b;
        }

        public double Sumar(double a, double b)
        {
            return a + b;
        }

        public static int Restar(int a, int b)
        {
            return a - b;
        }

        public double Restar(double a, double b)
        {
            return a - b;
        }

        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public static int Dividir(int a, int b)
        {
            return a / b;
        }

        public double Dividir(double a, double b)
        {
            return a / b;
        }

    }
}

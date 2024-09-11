using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator_OM100123.classes
{
    internal class Cuadrado : FiguraGeometrica
    {

        double lado;

        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        public override double CalculateArea()
        {
            double area = Math.Pow(this.lado, 2);
            return area;
        }
    }
}

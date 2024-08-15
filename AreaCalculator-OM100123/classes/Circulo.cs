using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator_OM100123.classes
{
    internal class Circulo :  FiguraGeometrica
    {
        double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public override double CalculateArea()
        {
            double area = Math.PI * Math.Pow(this.radio, 2);
            return area;
        }
    }
}

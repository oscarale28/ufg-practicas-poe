using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator_OM100123.classes
{
    internal class Triangulo : FiguraGeometrica
    {
        double trBase, trAltura;

        public Triangulo(double trBase, double trAltura)
        {
            this.trBase = trBase;
            this.trAltura = trAltura;
        }

        public override double CalculateArea()
        {
            double area = (this.trBase * this.trAltura) / 2;
            return area;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator_OM100123.classes
{
    internal class Rectangulo : FiguraGeometrica
    {
        double rectBase, rectAltura;

        public Rectangulo(double rectBase, double rectAltura)
        {
            this.rectBase = rectBase;
            this.rectAltura = rectAltura;
        }

        public override double CalculateArea()
        {
            double area = rectBase * rectAltura;
            return area;
        }
    }
}

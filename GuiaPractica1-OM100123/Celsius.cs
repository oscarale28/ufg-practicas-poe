using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaPractica1_OM100123
{
    internal class Celsius
    {
        double celsius;

        public Celsius(double c)
        {
            this.celsius = c;
        }

        public double ConvertCelsiusToFahrenheit()
        {
            double f = (this.celsius * 1.8) + 32;
            return f;
        }

    }
}

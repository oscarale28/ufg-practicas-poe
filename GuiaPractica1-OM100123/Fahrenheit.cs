using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaPractica1_OM100123
{
    internal class Fahrenheit
    {

        double fahrenheit;

        public Fahrenheit(double fahrenheit)
        {
            this.fahrenheit = fahrenheit;
        }

        public double ConvertFahrenheitToCelsius()
        {
            double c = (fahrenheit / 32) / 1.8;
            return c;
        }

    }
}

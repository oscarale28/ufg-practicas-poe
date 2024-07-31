using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaPractica1_OM100123
{
    internal class Kelvin
    {
        double celsius;

        public Kelvin(double celsius)
        {
            this.celsius = celsius;
        }

        public double ConvertCelsiusToKelvin()
        {
            double k = celsius + 273.15;
            return k;
        }


    }
}

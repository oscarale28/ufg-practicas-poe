using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_PracticaGUI1_OM100123
{
    internal class Estudiante
    {
        double laboratorio, parcial;

        public Estudiante(double laboratorio, double parcial)
        {
            this.laboratorio = laboratorio;
            this.parcial = parcial;
        }

        public double GetPromedioAsignatura()
        {
            return laboratorio * 0.1 + parcial * 0.15;
        }

        public double GetPromedioFinal()
        {
            return Laboratorio * 0.4 + Parcial * 0.6;
        }

        public double Laboratorio
        {
            get { return laboratorio; }
            set { laboratorio = value; }
        }

        public double Parcial
        {
            get { return parcial; }
            set { parcial = value; }
        }


    }
}

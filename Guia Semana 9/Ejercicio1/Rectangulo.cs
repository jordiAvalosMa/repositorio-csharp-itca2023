using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Rectangulo : FiguraGeometrica
    {
        private double altura;
        private double basee;
        private double area;
        public Rectangulo()
        { 

        }

        public double Altura { get => altura; set => altura = value; }
        public double Basee { get => basee; set => basee = value; }
        public double Area { get => area; set => area = value; }

        public override double CalcularArea()
        {
            return Altura * Basee;
        }
    }
}

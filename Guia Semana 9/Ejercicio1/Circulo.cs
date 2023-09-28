using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Circulo : FiguraGeometrica
    {
        private double radio;
        private double circuferencia;
        private double area;

        public double Radio { get => radio; set => radio = value; }
        public double Circuferencia { get => circuferencia; set => circuferencia = value; }
        public double Area { get => area; set => area = value; }

        public Circulo()
        {
        
        }

        public Circulo(double circuferencia)
        {
                Circuferencia = circuferencia;
                Radio = Circuferencia / (2 * Math.PI);
        }

        public override double CalcularArea()
        {
            return radio * radio * Math.PI;
        }
    }
}

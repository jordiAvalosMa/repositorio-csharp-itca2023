using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio3_Alumno
{
    internal class Alumno
    {
        private int carnet;
        private string nombre;
        private string apellido;
        private int edad;
        private double nota;
        private List<double> calificaciones;

        public int Carnet { get => carnet; set => carnet = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public double Nota { get => nota; set => nota = value; }
        public List<double> Calificaciones { get => calificaciones; set => calificaciones = value; }

        public Alumno(int carnet, string nombre, string apellido, int edad, double nota)
        {
            Carnet = carnet;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Nota = nota;
            Calificaciones = new List<double>();
        }

        public double CalcularPromedioCalificaciones()
        {
            if (Calificaciones.Count > 0)
            {
                return Calificaciones.Average();
            }
            else
            {
                return 0.0;
            }
        }
    }

}
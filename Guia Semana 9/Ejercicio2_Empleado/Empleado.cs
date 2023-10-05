using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Empleado
{
    internal class Empleado
    {
        private int idEmpleado;
        private string nombreEmpleado;
        private int apellidoEmpleado;
        private double salarioEmpleado;

        public Empleado()
        {

        }

        public int IdEmpleado 
        { 
            get => idEmpleado;
            set => idEmpleado = value; 
        }
        public string NombreEmpleado 
        { 
            get => nombreEmpleado; 
            set => nombreEmpleado = value; 
        }
        public int ApellidoEmpleado 
        { 
            get => apellidoEmpleado; 
            set => apellidoEmpleado = value; 
        }
        public double SalarioEmpleado 
        { 
            get => salarioEmpleado;
            set => salarioEmpleado = value; 
        }

        public virtual double calcularSalario()
        {
            return salarioEmpleado;
        }
    }
}

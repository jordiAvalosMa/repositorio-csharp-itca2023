using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_Alumno
{
    internal class RegistroAlumno
    {
        private List<Alumno> listaAlumnos = new List<Alumno>();
        public void RegistrarAlumno(Alumno alumno)
        {
            listaAlumnos.Add(alumno);
        }
        public double CalcularPromedioGlobal()
        {
            if (listaAlumnos.Count > 0)
            {
                double sumaNotas = listaAlumnos.Sum(alumno => alumno.Nota);
                return sumaNotas / listaAlumnos.Count;
            }
            else
            {
                return 0.0;
            }
        }

        public List<Alumno> ObtenerListaAlumnos()
        {
            return listaAlumnos;
        }
    }
}

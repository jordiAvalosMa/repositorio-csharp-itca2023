/*Investigar que función matemática se utiliza para encontrar la raíz cuadrada de un número y 
  desarrollar un programa que dé solución a ecuaciones de tipo:
  -  ax^2+bx+c=0
  Encontrando los valores respectivos de x1 y x2 en base a la siguiente formula:
  x=(-b±√(〖(b〗^2-4ac)))/2a
*/

using System;

namespace FormulaGeneral
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Ingrese los valosres de a, b y c de la ecuación cuadrática ax^2 + bx + c = 0");
            /*Declaramos las variables*/
            double a, b, c, discriminante, x1, x2, realPar, imaginarioPar;
            string opcion;
            //Leemos y almacena valores de la variables
            do
            {
                Console.Write("a: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("b: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("c: ");
                c = Convert.ToDouble(Console.ReadLine());

                discriminante = Math.Pow(b, 2) - (4 * a * c);
                if ((discriminante > 0))
                {
                    Console.WriteLine("Los resultados son reales.");
                    x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                    x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                    Console.WriteLine($"Las solociones son: x1 = {x1}, x2 = {x2}");
                }
                else if (discriminante == 0)
                {
                    x1 = -b / (2 * a);
                    x2 = x1;
                    Console.WriteLine($"La solucion es repetida : x1 = {x1}, x2 = {x2}, lo cual X es igual a: {x1}");
                }
                else
                {
                    Console.WriteLine("Los resultados son Imaginarios");
                    imaginarioPar = Math.Sqrt(-discriminante) / (2 * a);
                    realPar = -b / (2 * a);
                    Console.WriteLine($"La solucion es compleja: x1= {realPar} + {imaginarioPar}i, X2 = {realPar} - {imaginarioPar}i");
                }
                Console.WriteLine("Deceas continuar con otra ecuacion: \nOpciones:\n'SI' 1\n'NO' Numero diferente a 1");
                opcion = Console.ReadLine();
                Console.Clear();
            } while (opcion == "1");
        }
    }
}
// Investigar como ejecutar comandos MSDOS desde C# y crear un progrma que permita ingresar cantidad en minutos de tal forma que sirva 
// para apagar la computadora de forma definitiva. Crear tambien el programa que detiene el apagado.
using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int minutos, milisegundosTarda;

        Console.Write("Ingresa la cantidad en minutos antes de apagar: ");
        minutos = int.Parse(Console.ReadLine());

        milisegundosTarda = minutos * 60 * 1000;

        Console.WriteLine("La computadora se apagará en "+ minutos+" minutos.");
        Console.WriteLine("Escribe 'c' para cancelar el apagado.");

        // Iniciar temporizador para apagado
        System.Threading.Timer timer = new System.Threading.Timer(Apagar, null, milisegundosTarda, System.Threading.Timeout.Infinite);

        // Verificar si el usuario quiere detener el apagado
        string input = Console.ReadLine();
        if (input.ToLower() == "detener")
        {
            timer.Dispose(); // Detener el temporizador
            Console.WriteLine("Apagado cancelado.");
        }
    }

    static void Apagar(object state)
    {
        // Apagar la computadora
        Process.Start("shutdown", "/s /f /t 0");
    }
}


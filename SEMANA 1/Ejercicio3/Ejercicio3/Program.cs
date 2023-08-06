//
//
// Crear un programa para registro de 5 empleados para una planilla de una empresa constructora, por cada trabajador se registraran los siguientes datos:
// Nombre completo
// DUI
// Salario por hora
// horas trabajadas
// El programa, luego de registar los empleados, mostrara el listado de los empleados ingresados (5) mostrandi los siguentes datos como ejemplo
// no olvidad mostra el total de la planilla.
//
//

using System;
using System.Collections.Generic;

string nombre, dui;
double salarioPorHora = 0, horasTrabajadas = 0, salario = 0, renta = 0, neto = 0, acuDeSalarioPlantilla = 0;

Dictionary<int, Dictionary<string, dynamic>> empleados = new Dictionary<int, Dictionary<string, dynamic>>();

for (int i = 1; i <= 2; i++)
{
    Console.WriteLine($"Ingrese los datos del empleado {i}:");
    Console.Write("Nombre completo: ");
    nombre = Console.ReadLine();

    Console.Write("DUI: ");
    dui = Console.ReadLine();

    Console.Write("Horas trabajadas: ");
    horasTrabajadas = double.Parse(Console.ReadLine());

    Console.Write("Salario por hora: ");
    salarioPorHora = double.Parse(Console.ReadLine());

    salario = horasTrabajadas * salarioPorHora;
    renta = salario - (salario * 0.90);
    neto = salario * 0.90;
    acuDeSalarioPlantilla += neto;

    Dictionary<string, dynamic> empleado = new Dictionary<string, dynamic>
                {
                    { "Nombre", nombre },
                    { "DUI", dui },
                    { "HorasTrabajadas", horasTrabajadas },
                    { "SalarioPorHora", salarioPorHora },
                    { "Salario", salario },
                    { "Renta", renta },
                    { "Neto", neto }
                };

    empleados.Add(i, empleado);
    Console.WriteLine();
    Console.Clear();
}

Console.WriteLine("Listado de empleados de la Constructora:");
Console.WriteLine("----------------------------------------------------------------------------------------------------");
Console.WriteLine("Nombre\t\tHorasTrabajas\t\tSalario/Hora\t\tSalario\t\tRenta\t\tNeto");
Console.WriteLine("----------------------------------------------------------------------------------------------------");

foreach (var empleado in empleados)
{
    Console.WriteLine($"{empleado.Value["Nombre"]}\t\t{empleado.Value["HorasTrabajadas"]}\t\t${empleado.Value["SalarioPorHora"].ToString("0.00")}\t\t${empleado.Value["Salario"]}\t\t${empleado.Value["Renta"].ToString("0.00")}\t\t${empleado.Value["Neto"].ToString("0.00")}");
}

Console.WriteLine("----------------------------------------------------------------------------------------------------");
Console.WriteLine($"Total de la planilla: $" + acuDeSalarioPlantilla.ToString("0.00"));

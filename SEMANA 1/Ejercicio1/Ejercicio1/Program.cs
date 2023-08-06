// Crear un programa a nivel de consola que permita ingresar el nombre, cantidad y precio de 10 productos, al final
// del programa imprimira cuanto es el total a pagar aplicandole el incremento res[ectivo del 13% de IVA.

string nombreProducto;
int cantidadProducto;
double precio, total, acumuladorTotal = 0;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Ingrese el nombre del Producto " + i + ":");
    nombreProducto = Console.ReadLine();
    Console.WriteLine("Ingrese la cantidad de'" + nombreProducto + "' que necesitas: ");
    cantidadProducto = int.Parse(Console.ReadLine());
    Console.WriteLine("Cuales es el precio de Producto'" + nombreProducto + "': ");
    precio = double.Parse(Console.ReadLine());
    total = (cantidadProducto * precio) * 1.13;
    acumuladorTotal += total;
    Console.Clear();
}

Console.WriteLine("Total a pagar: $" + acumuladorTotal);
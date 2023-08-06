using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            var currentPath = Directory.GetCurrentDirectory();
            var filePath = Path.Combine(currentPath, "archivo.txt");

            if (File.Exists(filePath))
            {
                using (TextReader reader = File.OpenText(filePath))
                {
                    Console.WriteLine();
                    Console.WriteLine(reader.ReadToEnd());
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("El archivo no existe.");
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("El archivo no se encontró.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error de E/S: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}

using System;
using System.IO;
using System.Text; // Necesario para StringBuilder
using System.Threading.Tasks;

namespace LabAsincronia1
{
    internal class ProgramEjercicio6
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Introduce el texto línea por línea.");
            Console.WriteLine("Para terminar y guardar el archivo, presiona ENTER en una línea vacía:\n");

            string contenido = EscribirTexto();
            await EscribirArchivoAsync("datos.txt", contenido);

            Console.WriteLine("\n--- Archivo guardado. Intentando leer el contenido: ---\n");

            try
            {
                await LeerArchivoAsync("datos.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo leer el archivo.");
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        private static string EscribirTexto()
        {
            StringBuilder contenidoAcumulado = new StringBuilder();
            string? linea;
            while (true)
            {
                linea = Console.ReadLine();
                if (string.IsNullOrEmpty(linea))
                {
                    break;
                }
                contenidoAcumulado.AppendLine(linea);
            }
            return contenidoAcumulado.ToString();
        }

        private static async Task EscribirArchivoAsync(string ruta, string contenido)
        {
            await File.WriteAllTextAsync(ruta, contenido);
        }

        private static async Task LeerArchivoAsync(string ruta)
        {
            string contenido = await File.ReadAllTextAsync(ruta);
            Console.WriteLine(contenido);
        }
    }
}
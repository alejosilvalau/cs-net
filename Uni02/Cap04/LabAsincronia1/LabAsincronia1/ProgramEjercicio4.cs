using System;
using System.Threading.Tasks;

namespace LabAsincronia1
{
    internal class ProgramEjercicio4
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Iniciando operación larga con progreso...");
            IProgress<int> progreso = new Progress<int>(porcentaje =>
            {
                Console.WriteLine($"Progreso: {porcentaje}%");
            });

            await OperacionLargaConProgresoAsync(progreso);
        }

        private static async Task OperacionLargaConProgresoAsync(IProgress<int> progreso)
        {
            int totalPasos = 10;
            for (int i = 1; i <= totalPasos; i++)
            {
                int tiempo = 500; // 0.5 segundo
                await Task.Delay(tiempo);
                int porcentaje = (i * 100) / totalPasos; // Calcula el porcentaje de avance
                progreso.Report(porcentaje); // Reporta el progreso
            }

        }
    }
}

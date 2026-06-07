using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace LabAsincronia1
{
    internal class ProgramEjercicio2
    {
        private static readonly Stopwatch _stopwatch = new Stopwatch();
        static async Task Main(string[] args)
        {
            Console.WriteLine("Programa de simulación de operaciones asincrónicas");
            await EjecutarTareasSecuencialAsync();
            await EjecutarTareasParalelasAsync();
            Console.ReadLine();
        }

        private static async Task EjecutarTareasParalelasAsync()
        {
            _stopwatch.Restart();
            Console.WriteLine("\nSimulación de operaciones concurrentes");
            Task operacion1 = OperacionCortaAsync();
            Task operacion2 = OperacionMediaAsync();
            Task operacion3 = OperacionLargaAsync();
            Console.WriteLine("Todas las operaciones asincrónicas iniciadas, pero no bloquean el hilo principal\n");

            await Task.WhenAll(operacion1, operacion2, operacion3);
            _stopwatch.Stop();
            Console.WriteLine("Todas las operaciones asincrónicas completadas");
            Console.WriteLine("Tiempo total de ejecución: " + _stopwatch.ElapsedMilliseconds + " ms");
        }

        private static async Task EjecutarTareasSecuencialAsync()
        {
            _stopwatch.Restart();
            Console.WriteLine("\nSimulación de operaciones secuenciales");
            await OperacionCortaAsync();
            await OperacionMediaAsync();
            await OperacionLargaAsync();

            _stopwatch.Stop();
            Console.WriteLine("Todas las operaciones secuenciales asincrónicas completadas");
            Console.WriteLine("Tiempo total de ejecución: " + _stopwatch.ElapsedMilliseconds + " ms");
        }

        private static async Task OperacionCortaAsync()
        {
            int tiempo = 1000; // 1 segundo
            await Task.Delay(tiempo);
        }

        private static async Task OperacionMediaAsync()
        {
            int tiempo = 2000; // 2 segundos
            await Task.Delay(tiempo);
        }

        private static async Task OperacionLargaAsync()
        {
            int tiempo = 3000; // 3 segundos
            await Task.Delay(tiempo);
        }
    }
}
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace LabAsincronia1
{
    internal class Program
    {
        private static readonly Stopwatch _stopwatch = new Stopwatch();
        static void Main(string[] args)
        {
            Console.WriteLine("Programa de simulación de operaciones asincrónicas");
            CompararSincronoVsAsincrono();
        }

        private static void SimularOperacionPesada()
        {
            _stopwatch.Restart();
            Console.WriteLine($"Iniciando operación sincrónica...({_stopwatch.ElapsedMilliseconds} ms)");

            int tiempo = 3000; // 3 segundos
            Thread.Sleep(tiempo);

            _stopwatch.Stop();
            Console.WriteLine($"Operación sincrónica completada en {_stopwatch.ElapsedMilliseconds} ms\n");
        }

        private static async void SimularOperacionPesadaAsync()
        {
            _stopwatch.Restart();
            Console.WriteLine($"Iniciando operación asincrónica... ({_stopwatch.ElapsedMilliseconds} ms)");

            int tiempo = 3000; // 3 segundos
            await Task.Delay(tiempo);

            _stopwatch.Stop();
            Console.WriteLine($"Operación asincrónica completada en {_stopwatch.ElapsedMilliseconds} ms");
        }

        private static void CompararSincronoVsAsincrono()
        {
            Console.WriteLine("Comparación entre operación sincrónica y asincrónica");

            SimularOperacionPesada();

            SimularOperacionPesadaAsync();
            Console.WriteLine("Operación asincrónica iniciada, pero no bloquea el hilo principal\n");
            Console.ReadLine();
        }
    }
}

/*
 * Responder: 
 * A. ¿Qué ventajas observás en el uso del código asincrónico? 
 * Permite que el programa siga respondiendo mientras se ejecuta una operación pesada, evitando bloqueos y mejorando la experiencia del usuario. Además, puede mejorar el rendimiento al permitir que otras tareas se ejecuten simultáneamente.
 * 
 * B. ¿Qué inconvenientes podría tener si el código asincrónico no se maneja adecuadamente?
 * Puede generar condiciones de carrera, errores difíciles de depurar y problemas de sincronización si no se gestionan correctamente las tareas asincrónicas y los recursos compartidos.
 */
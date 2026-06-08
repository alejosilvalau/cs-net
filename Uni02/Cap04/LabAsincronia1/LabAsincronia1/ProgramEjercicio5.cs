using System;
using System.Threading;
using System.Threading.Tasks;

namespace LabAsincronia1
{
    internal class ProgramEjercicio5
    {
        static async Task Main(string[] args)
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                Console.WriteLine("Iniciando operación cancelable...");


                Task operacionTask = OperacionCancelableAsync(cts.Token);

                Console.WriteLine("Presiona cualquier tecla para cancelar la operación antes de que termine...");
                // Ejecutamos una función que espera el teclado de forma no bloqueante.
                Task esperarTecladoTask = Task.Run(() => Console.ReadKey(true));

                Task tareaCompletada = await Task.WhenAny(operacionTask, esperarTecladoTask);
                if (tareaCompletada == esperarTecladoTask && !operacionTask.IsCompleted)
                {
                    cts.Cancel();
                }

                try
                {
                    // Necesitamos otro await para asegurarnos de que si ocurrio cualquier
                    // excepción dentro de la tarea, esta sea capturada aquí.
                    await operacionTask;
                    Console.WriteLine("\nOperación completada exitosamente (Try común).");
                }
                catch (OperationCanceledException)
                {
                    Console.WriteLine("\nOperación cancelada por el usuario (Catch).");
                }
            }
        }


        private static async Task OperacionCancelableAsync(CancellationToken token)
        {
            int totalPasos = 10;
            for (int i = 1; i <= totalPasos; i++)
            {
                token.ThrowIfCancellationRequested();
                Console.WriteLine($"Ejecutando paso {i} de {totalPasos}...");
                await Task.Delay(1000, token);
            }
        }
    }
}
/*
 * A. ¿Qué sucede si no se utiliza un try-catch alrededor de la llamada asincrónica? 
 * Si no se utiliza un try-catch, cualquier excepción que ocurra dentro de la tarea asincrónica
 * no será capturada y podría causar que la aplicación termine de manera inesperada.
 * 
 * B. ¿Por qué es importante capturar las excepciones dentro del método asincrónico en lugar de hacerlo solo en Main? 
 * Capturar las excepciones dentro del método asincrónico permite manejar errores específicos de la operación asincrónica
 * de manera más granular y proporciona un control más fino sobre la lógica de recuperación o limpieza antes de que la excepción
 * se propague a Main.
 */
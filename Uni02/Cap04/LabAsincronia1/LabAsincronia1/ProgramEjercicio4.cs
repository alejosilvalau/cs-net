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

/*
 * A. ¿En qué situaciones prácticas usarías el progreso? 
 *    - Cuando se realizan operaciones largas y se desea informar al usuario sobre el estado actual.
 *    - En aplicaciones con interfaces gráficas para actualizar barras de progreso.
 *    - En procesos de descarga o carga de archivos para mostrar el avance.
 * 
 * B. ¿Cuál es la ventaja de IProgress<T> respecto a pasar simplemente una acción (un Action<int>)? 
 *    - IProgress<T> proporciona una forma segura de informar el progreso desde hilos en segundo plano.
 *    - Permite desacoplar la lógica de progreso de la lógica de la operación.
 *    - Facilita la actualización de la interfaz de usuario desde hilos en segundo plano sin necesidad de invocar manualmente el hilo de la UI.
 */

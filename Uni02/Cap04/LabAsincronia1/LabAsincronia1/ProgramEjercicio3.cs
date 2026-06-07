using System;
using System.Threading.Tasks;

namespace LabAsincronia1
{
    internal class ProgramEjercicio3
    {
        static async Task Main(string[] args)
        {
            await ProbarManejoExcepcionesAsync();
        }

        private static async Task OperacionConErrorAsync()
        {
            int tiempo = 2000; // 2 segundos
            await Task.Delay(tiempo);
            throw new InvalidOperationException("Error simulado en operación asincrónica");
        }

        private static async Task ProbarManejoExcepcionesAsync()
        {
            try
            {
                await OperacionConErrorAsync();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Excepción capturada: " + ex.Message);
            }
        }
    }
}
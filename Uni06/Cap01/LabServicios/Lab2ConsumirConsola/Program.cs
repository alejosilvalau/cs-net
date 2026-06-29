using Dominio;
using System.Net.Http.Json;

namespace Lab2ConsumirConsola
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string puerto = "5012";
            HttpClient httpClient = new HttpClient()
            {
                BaseAddress = new Uri($"http://localhost:{puerto}")
            };

            Alumno alumno1 = new Alumno("Silva", "Alejo", 59398, "Av. Cordoba 3029");
            await httpClient.PostAsJsonAsync("alumnos", alumno1);

            Alumno alumno2 = new Alumno("Doe", "John", 59432, "San Cristobal Colón 3029");
            await httpClient.PostAsJsonAsync("alumnos", alumno2);

            Alumno alumno3 = new Alumno("Quito", "Esteban", 69492, "Entre Rios 4039");
            await httpClient.PostAsJsonAsync("alumnos", alumno3);

            IEnumerable<Alumno>? alumnos = await httpClient.GetFromJsonAsync<IEnumerable<Alumno>>("alumnos");

            if (alumnos != null)
            {
                foreach (Alumno alumno in alumnos)
                {
                    Console.WriteLine("Los alumnos encontrados fueron: ");
                    Console.WriteLine(alumno);
                }
                Console.WriteLine($"\nTotal de alumnos: {alumnos.Count()}");
            }
            Console.WriteLine($"\nIngrese una tecla para terminar");
            Console.ReadKey();
        }
    }
}

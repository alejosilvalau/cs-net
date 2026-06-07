using System;
using System.Collections.Generic;
using System.Linq;

namespace PruebaConsola
{
    // 1. Definición de las clases de datos
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CarreraId { get; set; }
        public List<double> Notas { get; set; }
    }

    public class Carrera
    {
        public int Id { get; set; }
        public string NombreCarrera { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            // Datos de prueba (Fuentes de datos / sources)
            var estudiantes = new List<Estudiante>
        {
            new Estudiante { Id = 1, Nombre = "Ana", CarreraId = 101, Notas = new List<double>{ 8.5, 9.0 } },
            new Estudiante { Id = 2, Nombre = "Carlos", CarreraId = 101, Notas = new List<double>{ 4.0, 5.5 } },
            new Estudiante { Id = 3, Nombre = "Beatriz", CarreraId = 102, Notas = new List<double>{ 7.0, 8.0 } },
            new Estudiante { Id = 4, Nombre = "Damián", CarreraId = 102, Notas = new List<double>{ 9.5, 10.0 } }
        };

            var carreras = new List<Carrera>
        {
            new Carrera { Id = 101, NombreCarrera = "Ingeniería" },
            new Carrera { Id = 102, NombreCarrera = "Medicina" }
        };

            // ==========================================
            // EL EJEMPLO DE LINQ CON TODO LO DE LA IMAGEN
            // ==========================================
            var resultadoAgrupado =
                from est in estudiantes                             // 1. Empieza con 'from' (source 1)
                join car in carreras on est.CarreraId equals car.Id  // 2. 'join' con otra fuente
                let promedioBase = est.Notas.Average()              // 3. 'let' para almacenar una variable
                let promedioFinal = promedioBase + 0.5              //    (Otro 'let' opcional)
                where promedioFinal >= 7.0                          // 4. 'where' con la condición de aprobado
                orderby car.NombreCarrera, promedioFinal descending // 5. 'orderby' con múltiples ordenamientos
                select new { est.Nombre, car.NombreCarrera, Nota = promedioFinal } // 6. 'select' inicial
                into reporteTemporal                                // 7. 'into' (opcional) para continuar la query
                group reporteTemporal by reporteTemporal.NombreCarrera; // 8. Termina con 'group by'

            Console.WriteLine($"Clase de resultadoAgrupado: {resultadoAgrupado.GetType()}");
            Console.WriteLine($"resultadoAgrupado[0]: {resultadoAgrupado.ElementAt(0)}\n");
            // Imprimir los resultados para verificar
            foreach (var grupo in resultadoAgrupado)
            {
                Console.WriteLine($"\nCarrera: {grupo.Key}");
                Console.WriteLine("-------------------------");
                foreach (var item in grupo)
                {
                    Console.WriteLine($"- Alumno: {item.Nombre} | Promedio Final: {item.Nota}");
                }
            }
        }
    }
}
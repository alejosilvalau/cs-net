using System.Collections;

namespace LabLINQ
{
    public static class ArgentinaCiudadesLINQ
    {
        private static ArrayList ciudades = new ArrayList
        {
            ("Buenos Aires", 1000),
            ("Córdoba", 5000),
            ("Rosario", 2000),
            ("Mendoza", 5500),
            ("La Plata", 1900),
            ("San Miguel de Tucumán", 4000),
            ("Mar del Plata", 7600),
            ("Salta", 4400),
            ("Santa Fe", 3000),
            ("San Juan", 5400),
            ("Resistencia", 3500),
            ("Neuquén", 8300),
            ("Santiago del Estero", 4200),
            ("Corrientes", 3400),
        };
        private static string expresionBusqueda = "san";

        public static void BuscarCiudades()
        {
            var ciudadesFiltradas = ciudades.Cast<(string, int)>().Where(c => c.Item1.Contains(expresionBusqueda, StringComparison.OrdinalIgnoreCase)).ToList();

            Console.WriteLine("");
            Console.WriteLine($"Ciudades que contienen '{expresionBusqueda}':");

            int offset = ciudades.Cast<(string, int)>().Max(c => c.Item1.Length);

            ciudadesFiltradas.ForEach(c => Console.WriteLine($"{c.Item1.PadRight(offset)} | Código Postal: {c.Item2}"));
        }
    }
}

namespace LabLINQ
{
    public static class ArgentinaProvinciasLINQ
    {
        private static List<string> provincias = new List<string> {
            "Buenos Aires",
            "Catamarca",
            "Chaco",
            "Chubut",
            "Córdoba",
            "Corrientes",
            "Entre Ríos",
            "Formosa",
            "Jujuy",
            "La Pampa",
            "La Rioja",
            "Mendoza",
            "Misiones",
            "Neuquén",
            "Río Negro",
            "Salta",
            "San Juan",
            "San Luis",
            "Santa Cruz",
            "Santa Fe",
            "Santiago del Estero",
            "Tierra del Fuego",
            "Tucumán"
        };

        public static void MostrarProvinciasConSoT()
        {
            var provinciasConSoT = provincias.Where(p => p.ToLower().Contains("s") || p.ToLower().Contains("t")).ToList();

            Console.WriteLine("");
            Console.WriteLine("Lista de provincias que contienen 's' o 't':");

            foreach (var provincia in provinciasConSoT)
            {
                Console.WriteLine(provincia);
            }
        }
    }
}

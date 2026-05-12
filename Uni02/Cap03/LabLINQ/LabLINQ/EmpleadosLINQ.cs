namespace LabLINQ
{
    internal static class EmpleadosLINQ
    {
        private static List<Empleado> empleados = new List<Empleado>();

        internal static void CargarYMostrarEmpleados()
        {
            CargarEmpleados();
            MostrarEmpleados();
        }

        private static void MostrarEmpleados()
        {
            if (empleados.Count == 0)
            {
                Console.WriteLine("No hay empleados cargados. Cargando empleados...");
                CargarEmpleados();
            }
            Console.WriteLine("- Listados -");
            Console.WriteLine("");
            Console.WriteLine("Empleados por sueldo ascendente:");

            List<Empleado> empleadosSueldoAscendente = empleados.OrderBy(e => e.Sueldo).ToList();
            empleadosSueldoAscendente.ForEach(empleado =>
            {
                Console.WriteLine($"Id: {empleado.Id}, Nombre: {empleado.Nombre}, Sueldo: {empleado.Sueldo}");
            });

            Console.WriteLine("");
            Console.WriteLine("Empleados por sueldo descendente:");

            List<Empleado> empleadosSueldoDescendente = empleados.OrderByDescending(e => e.Sueldo).ToList();
            empleadosSueldoDescendente.ForEach(empleado =>
            {
                Console.WriteLine($"Id: {empleado.Id}, Nombre: {empleado.Nombre}, Sueldo: {empleado.Sueldo}");
            });
        }

        private static void CargarEmpleados()
        {
            bool seguir = true;

            while (seguir)
            {
                Console.WriteLine("");
                Console.WriteLine("- Cargando nuevo empleado -");
                Console.WriteLine("Ingrese el id del empleado a dar de alta: ");
                string? idInput = Console.ReadLine();
                if (!int.TryParse(idInput, out int id) || empleados.Any(e => e.Id == id) || id < 0)
                {
                    Console.WriteLine("Id inválido o ya existente. Intente nuevamente.");
                    continue;
                }

                Console.WriteLine("Ingrese el nombre del empleado a dar de alta: ");
                string? nombre = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    Console.WriteLine("Nombre inválido. Intente nuevamente.");
                    continue;
                }

                Console.WriteLine("Ingrese el sueldo del empleado a dar de alta: ");
                string? sueldoInput = Console.ReadLine();
                if (!float.TryParse(sueldoInput, out float sueldo) || sueldo <= 0)
                {
                    Console.WriteLine("Sueldo inválido. Intente nuevamente.");
                    continue;
                }

                DarDeAltaEmpleado(id, nombre, sueldo);

                Console.WriteLine("");
                Console.WriteLine("¿Desea agregar otro empleado? (s/n): ");
                string? respuesta = Console.ReadLine();
                if (respuesta?.Trim().ToLower() != "s")
                {
                    seguir = false;
                }
                Console.WriteLine("");
            }
        }
        private static void DarDeAltaEmpleado(int id, string nombre, float sueldo)
        {
            empleados.Add(new Empleado(id, nombre, sueldo));
        }
    }
    internal class Empleado
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; }
        public float Sueldo { get; private set; }

        public Empleado(int id, string nombre, float sueldo)
        {
            Id = id;
            Nombre = nombre;
            Sueldo = sueldo;
        }
    }
}

namespace LabLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Programa de provincias ---");
            ArgentinaProvinciasLINQ.MostrarProvinciasConSoT();

            Console.WriteLine("");
            Console.WriteLine("--- Programa números mayores a 20 ---");
            NumerosLINQ.MostrarNumerosMayoresA20();

            Console.WriteLine("");
            Console.WriteLine("--- Programa ciudades filtradas ---");
            ArgentinaCiudadesLINQ.BuscarCiudades();

            Console.WriteLine("");
            Console.WriteLine("--- Programa de empleados ---");
            EmpleadosLINQ.CargarYMostrarEmpleados();

            Console.WriteLine("");
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadLine();
        }
    }
}

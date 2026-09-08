using LabEntityFramework;

void CrearAlumno()
{
    using var context = new UniversidadContext();
    var alumno = new Alumno
    {
        Apellido = "Pérez",
        Nombre = "Juan",
        Legajo = 12345,
        Direccion = "Calle Falsa 123"
    };
    context.Alumnos.Add(alumno);
    context.SaveChanges();
    Console.WriteLine("Alumno creado con ID: " + alumno.Id);
}

void LeerAlumno()
{
    using var context = new UniversidadContext();
    var alumno = context.Alumnos.FirstOrDefault(a => a.Legajo == 12345);
    if (alumno != null)
    {
        Console.WriteLine($"ID: {alumno.Id}");
        Console.WriteLine($"Apellido: {alumno.Apellido}");
        Console.WriteLine($"Nombre: {alumno.Nombre}");
        Console.WriteLine($"Legajo: {alumno.Legajo}");
        Console.WriteLine($"Dirección: {alumno.Direccion}");
    }
    else
    {
        Console.WriteLine("Alumno no encontrado.");
    }
}

void ActualizarAlumno()
{
    using var context = new UniversidadContext();
    var alumno = context.Alumnos.FirstOrDefault(a => a.Legajo == 12345);
    if (alumno != null)
    {
        alumno.Direccion = "Nueva Dirección 456";
        context.SaveChanges();
        Console.WriteLine("Alumno actualizado.");
    }
}

void EliminarAlumno()
{
    using var context = new UniversidadContext();
    var alumno = context.Alumnos.FirstOrDefault(a => a.Legajo == 12345);
    if (alumno != null)
    {
        context.Alumnos.Remove(alumno);
        context.SaveChanges();
        Console.WriteLine("Alumno eliminado.");
    }
}

Console.WriteLine("=== ABMC de Alumnos ===\n");

Console.WriteLine("1. Crear alumno...");
CrearAlumno();

Console.WriteLine("\n2. Leer alumno...");
LeerAlumno();

Console.WriteLine("\n3. Actualizar alumno...");
ActualizarAlumno();

Console.WriteLine("\n4. Leer alumno después de actualizar...");
LeerAlumno();

Console.WriteLine("\n5. Eliminar alumno...");
EliminarAlumno();

Console.WriteLine("\n6. Leer alumno después de eliminar...");
LeerAlumno();

Console.WriteLine("\nFin del programa.");

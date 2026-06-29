using Dominio;

namespace Lab1Crear
{
    public static class AlumnoEndpoints
    {
        private record AlumnoDTO(string apellido, string nombre, int legajo, string direccion);
        public static void MapAlumnoEndpoints(this WebApplication app)
        {
            app.MapGet("/alumnos", () => Results.Ok(Alumno.Lista));

            app.MapGet("/alumnos/{id}", (int id) =>
            Alumno.Lista.Find(a => a.Id == id) is Alumno alumno
            ? Results.Ok(alumno)
            : Results.NotFound());

            app.MapPost("/alumnos", (AlumnoDTO alumno) =>
            {
                var nuevoAlumno = AlumnoMapper(alumno);
                nuevoAlumno.setId(Alumno.ObtenerProximoId());
                Alumno.Lista.Add(nuevoAlumno);
                return Results.Created($"/alumnos/{nuevoAlumno.Id}", nuevoAlumno);
            });

            app.MapPut("/alumnos/{id}", (int id, Alumno alumno) =>
            {
                int index = Alumno.Lista.FindIndex(a => a.Id == id);
                if (index == -1) return Results.NotFound();

                var existingAlumno = Alumno.Lista[index];
                var nuevoAlumno = new Alumno(alumno.Apellido, alumno.Nombre, alumno.Legajo, alumno.Direccion);
                nuevoAlumno.setId(id);

                Alumno.Lista[index] = nuevoAlumno;
                return Results.Ok(nuevoAlumno);
            });

            app.MapDelete("/alumnos/{id}", (int id) =>
            {
                int index = Alumno.Lista.FindIndex(a => a.Id == id);
                if (index == -1) return Results.NotFound();

                Alumno.Lista.RemoveAt(index);
                return Results.NoContent();
            });
        }
        private static Alumno AlumnoMapper(AlumnoDTO alumno)
        {
            return new Alumno(alumno.apellido, alumno.nombre, alumno.legajo, alumno.direccion);
        }
    }
}
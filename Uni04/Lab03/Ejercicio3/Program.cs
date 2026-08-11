namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dsUniversidad miUniversidad = new dsUniversidad();

            dsUniversidad.dtAlumnosDataTable dtAlumnos = new dsUniversidad.dtAlumnosDataTable();
            dsUniversidad.dtCursosDataTable dtCursos = new dsUniversidad.dtCursosDataTable();

            dsUniversidad.dtAlumnosRow rowAlumno = dtAlumnos.NewdtAlumnosRow();
            rowAlumno.Apellido = "Gonzalez";
            rowAlumno.Nombre = "Juan";
            dtAlumnos.AdddtAlumnosRow(rowAlumno);

            dsUniversidad.dtCursosRow rowCurso = dtCursos.NewdtCursosRow();
            rowCurso.Curso = "Informatica";
            dtCursos.AdddtCursosRow(rowCurso);

            dsUniversidad.dtAlumnos_CursosDataTable dtAlumnos_Cursos = new dsUniversidad.dtAlumnos_CursosDataTable();
            dsUniversidad.dtAlumnos_CursosRow rowAlumnosCursos = dtAlumnos_Cursos.NewdtAlumnos_CursosRow();
            dtAlumnos_Cursos.AdddtAlumnos_CursosRow(rowAlumno, rowCurso);

            dsUniversidad.dtAlumnosRow rowAlumno2 = dtAlumnos.NewdtAlumnosRow();
            rowAlumno2.Apellido = "Perez";
            rowAlumno2.Nombre = "Marcelo";
            dtAlumnos.AdddtAlumnosRow(rowAlumno2);
            dtAlumnos_Cursos.AdddtAlumnos_CursosRow(rowAlumno2, rowCurso);
        }
    }
}

using System;
using System.Data;

namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable dtAlumnos = new DataTable();

            DataColumn colIDAlumno = new DataColumn("IDAlumno", typeof(int));
            colIDAlumno.ReadOnly = true;
            colIDAlumno.AutoIncrement = true;
            colIDAlumno.AutoIncrementSeed = 0;
            colIDAlumno.AutoIncrementStep = 1;
            DataColumn colNombre = new DataColumn("Nombre", typeof(string));
            DataColumn colApellido = new DataColumn("Apellido", typeof(string));

            dtAlumnos.Columns.Add(colIDAlumno);
            dtAlumnos.Columns.Add(colApellido);
            dtAlumnos.Columns.Add(colNombre);
            dtAlumnos.PrimaryKey = new DataColumn[] { colIDAlumno };

            DataRow rwAlumno = dtAlumnos.NewRow();
            rwAlumno[colApellido] = "Doe";
            rwAlumno[colNombre] = "John";
            dtAlumnos.Rows.Add(rwAlumno);

            DataRow rwAlumno2 = dtAlumnos.NewRow();
            rwAlumno2[colApellido] = "Smith";
            rwAlumno2[colNombre] = "Jane";
            dtAlumnos.Rows.Add(rwAlumno2);

            DataRow rwAlumno3 = dtAlumnos.NewRow();
            rwAlumno3[colApellido] = "Alvarez";
            rwAlumno3[colNombre] = "Esteban";
            dtAlumnos.Rows.Add(rwAlumno3);

            // -------------------------------------
            DataTable dtCursos = new DataTable();

            DataColumn colIDCurso = new DataColumn("IDCurso", typeof(int));
            colIDCurso.ReadOnly = true;
            colIDCurso.AutoIncrement = true;
            colIDCurso.AutoIncrementSeed = 1;
            colIDCurso.AutoIncrementStep = 1;
            DataColumn colCurso = new DataColumn("Curso", typeof(string));

            dtCursos.Columns.Add(colIDCurso);
            dtCursos.Columns.Add(colCurso);
            dtCursos.PrimaryKey = new DataColumn[] { colIDCurso };

            DataRow rwCurso = dtCursos.NewRow();
            rwCurso[colCurso] = "Informatica";
            dtCursos.Rows.Add(rwCurso);

            // -------------------------------------
            DataTable dtAlumnos_Cursos = new DataTable("Alumnos_Cursos");
            DataColumn col_ac_IDAlumno = new DataColumn("IDAlumno", typeof(int));
            DataColumn col_ac_IDCurso = new DataColumn("IDCurso", typeof(int));

            dtAlumnos_Cursos.Columns.Add(col_ac_IDAlumno);
            dtAlumnos_Cursos.Columns.Add(col_ac_IDCurso);

            DataSet dsUniversidad = new DataSet();
            dsUniversidad.Tables.Add(dtAlumnos);
            dsUniversidad.Tables.Add(dtCursos);
            dsUniversidad.Tables.Add(dtAlumnos_Cursos);

            DataRelation relAlumno_ac = new DataRelation("Alumno_Cursos", colIDAlumno, col_ac_IDAlumno);
            DataRelation relCurso_ac = new DataRelation("Curso_Alumnos", colIDCurso, col_ac_IDCurso);

            dsUniversidad.Relations.Add(relAlumno_ac);
            dsUniversidad.Relations.Add(relCurso_ac);

            DataRow rwAlumnosCursos = dtAlumnos_Cursos.NewRow();
            rwAlumnosCursos[col_ac_IDAlumno] = 0;
            rwAlumnosCursos[col_ac_IDCurso] = 1;
            dtAlumnos_Cursos.Rows.Add(rwAlumnosCursos);

            rwAlumnosCursos = dtAlumnos_Cursos.NewRow();
            rwAlumnosCursos[col_ac_IDAlumno] = 1;
            rwAlumnosCursos[col_ac_IDCurso] = 1;
            dtAlumnos_Cursos.Rows.Add(rwAlumnosCursos);

            Console.WriteLine("Por favor ingrese el nombre del curso: ");
            string materia = Console.ReadLine();
            Console.WriteLine("Listado de Alumnos del curso " + materia);

            DataRow[] rwCursos = dtCursos.Select("Curso = '" + materia + "'");
            foreach (DataRow rowCu in rwCursos)
            {
                DataRow[] row_AlumnosInf = rowCu.GetChildRows(relCurso_ac);
                foreach (DataRow rowAl in row_AlumnosInf)
                {
                    Console.WriteLine(rowAl.GetParentRow(relAlumno_ac)[colApellido].ToString() + ", " + rowAl.GetParentRow(relAlumno_ac)[colNombre].ToString());
                }
            }

            Console.ReadLine();
        }
    }
}

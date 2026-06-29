namespace Dominio
{
    public class Alumno
    {
        public int Id { get; private set; }
        public string Apellido { get; private set; }
        public string Nombre { get; private set; }
        public int Legajo { get; private set; }
        public string Direccion { get; private set; }

        public static readonly List<Alumno> Lista = new();
        public Alumno(string apellido, string nombre, int legajo, string direccion)
        {
            Apellido = apellido;
            Nombre = nombre;
            Legajo = legajo;
            Direccion = direccion;
        }
        public void setId(int id)
        {
            Id = id;
        }
        public static int ObtenerProximoId()
        {
            return Lista.Count > 0 ? Lista.Max(a => a.Id) + 1 : 1;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Apellido: {Apellido}, Nombre: {Nombre}, Legajo: {Legajo}, Direccion: {Direccion}";
        }
    }
}

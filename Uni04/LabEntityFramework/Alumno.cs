namespace LabEntityFramework;

public class Alumno
{
    public int Id { get; set; }
    public string Apellido { get; set; } = string.Empty;
    public string Nombre { get; set; } = string.Empty;
    public int Legajo { get; set; }
    public string Direccion { get; set; } = string.Empty;
}

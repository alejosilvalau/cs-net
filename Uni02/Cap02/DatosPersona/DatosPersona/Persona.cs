namespace DatosPersona {
  internal class Persona {
    public string Nombre { get; private set; }
    public string Apellido { get; private set; }
    public int Edad { get; private set; }
    public int DNI { get; private set; }

    public Persona(string nombre, string apellido, int dni) {
      Nombre = nombre;
      Apellido = apellido;
      DNI = dni;

      Console.WriteLine("Se creo una persona");
    }
    ~Persona() {
      Console.WriteLine("Se destruyo una persona");
    }

    public string GetFullName() {
      return $"{Nombre} {Apellido}";
    }

    public string GetAge() {
      Console.WriteLine("Ingrese el año de nacimiento: ");
      int? anioNacimiento = int.TryParse(Console.ReadLine(), out int result) ? result : null;
      int anioActual = DateTime.Now.Year;

      if (anioNacimiento != null || anioNacimiento <= anioActual) {
        Edad = anioActual - (int)anioNacimiento;
        return $"{Edad} años";
      }
      return "Año de nacimiento no válido";
    }
  }
}

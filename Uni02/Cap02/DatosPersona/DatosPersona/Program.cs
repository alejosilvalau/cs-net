namespace DatosPersona {
  internal class Program {
    static void Main(string[] args) {
      Persona p = new Persona("Juan", "Perez", 12345678);
      Console.WriteLine(p.GetAge());
    }
  }
}

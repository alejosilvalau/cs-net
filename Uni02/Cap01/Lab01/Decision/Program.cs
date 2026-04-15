namespace Decision {
  internal class Program {
    static void Main(string[] args) {
      //      EstructurasDecisionIf();
      EstructurasDecisionCase();
    }

    private static void EstructurasDecisionIf() {
      Console.WriteLine("Bienvenido!");
      Console.WriteLine("Ingrese un texto:");
      string? inputTexto = Console.ReadLine();

      Console.WriteLine("");
      Console.WriteLine("Seleccione la opción:");
      Console.WriteLine("1. Convertir a mayúsculas");
      Console.WriteLine("2. Convertir a minúsculas");
      Console.WriteLine("3. Contar caracteres");
      ConsoleKeyInfo opcion = Console.ReadKey();

      Console.WriteLine("");
      if (opcion.Key == ConsoleKey.D1) Console.WriteLine($"\nTexto en mayúsculas: {inputTexto?.ToUpper()}");
      else if (opcion.Key == ConsoleKey.D2) Console.WriteLine($"\nTexto en minúsculas: {inputTexto?.ToLower()}");
      else if (opcion.Key == ConsoleKey.D3) Console.WriteLine($"\nNúmero de caracteres: {inputTexto?.Length}");
      else Console.WriteLine("Cerrando programa...");

      Console.ReadLine();
    }
    private static void EstructurasDecisionCase() {
      Console.WriteLine("Bienvenido!");
      Console.WriteLine("Ingrese un texto:");
      string? inputTexto = Console.ReadLine();

      Console.WriteLine("");
      Console.WriteLine("Seleccione la opción:");
      Console.WriteLine("1. Convertir a mayúsculas");
      Console.WriteLine("2. Convertir a minúsculas");
      Console.WriteLine("3. Contar caracteres");
      ConsoleKeyInfo opcion = Console.ReadKey();

      Console.WriteLine("");
      switch (opcion.Key) {
        case ConsoleKey.D1:
          Console.WriteLine($"\nTexto en mayúsculas: {inputTexto?.ToUpper()}");
          break;
        case ConsoleKey.D2:
          Console.WriteLine($"\nTexto en minúsculas: {inputTexto?.ToLower()}");
          break;
        case ConsoleKey.D3:
          Console.WriteLine($"\nNúmero de caracteres: {inputTexto?.Length}");
          break;
        default:
          Console.WriteLine("Cerrando programa...");
          break;

          Console.ReadLine();
      }
    }
  }
}

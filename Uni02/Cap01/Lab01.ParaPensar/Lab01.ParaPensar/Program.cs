namespace Lab01.ParaPensar {
  internal class Program {
    private static void Main(string[] args) {
      Console.WriteLine("Bienvenido!");
      Menu();
      Console.WriteLine("\nOpcion: ");
      ConsoleKeyInfo opcion = Console.ReadKey();

      while (opcion.Key != ConsoleKey.Escape) {
        Console.WriteLine("");
        switch (opcion.Key) {
          case ConsoleKey.D1:
            SumaDeNumeros();
            break;
          case ConsoleKey.D2:
            Bisiesto();
            break;
          case ConsoleKey.D3:
            Fibonacci();
            break;
          default:
            Console.WriteLine("\nIngrese de vuelta: ");
            break;
        }

        Menu();
        Console.WriteLine("\nNueva opcion:");
        opcion = Console.ReadKey();
      }
    }
    private static void Menu() {
      Console.WriteLine("\nIngrese la opción deseada:");
      Console.WriteLine("\t1. Suma de números");
      Console.WriteLine("\t2. Año bisiesto");
      Console.WriteLine("\t3. Serie Fibonacci");
      Console.WriteLine("\tESC. Salir");
    }

    private static void SumaDeNumeros() {
      Console.WriteLine("\nSuma de Números:");
      Console.WriteLine("Ingrese el primer número:");
      double numero1 = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Ingrese el segundo número:");
      double numero2 = Convert.ToDouble(Console.ReadLine());
      double resultado = numero1 + numero2;
      Console.WriteLine($"El resultado de la suma de {numero1} y {numero2} es {resultado}");
    }

    private static void Bisiesto() {
      Console.WriteLine("\nAño bisiesto:");
      Console.WriteLine("Ingrese un año:");
      int año = Convert.ToInt32(Console.ReadLine());
      bool esBisiesto = (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);
      if (esBisiesto) {
        Console.WriteLine($"El año {año} es bisiesto.");
      } else {
        Console.WriteLine($"El año {año} no es bisiesto.");
      }
    }

    private static void Fibonacci() {
      Console.WriteLine("\nSerie de Fibonacci:");
      Console.WriteLine("Ingrese el número de términos:");
      int n = Convert.ToInt32(Console.ReadLine());
      int a = 0, b = 1, c;
      Console.Write("Serie de Fibonacci: ");
      for (int i = 0; i < n; i++) {
        Console.Write($"{a} ");
        c = a + b;
        a = b;
        b = c;
      }
    }
  }
}

using System.Globalization;

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
          case ConsoleKey.D4:
            NumerosPares();
            break;
          case ConsoleKey.D5:
            Console.WriteLine("\nIngrese el nombre del mes:");
            string? nombreMes = Console.ReadLine();
            if (nombreMes != null) NombreMes(nombreMes);
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
      Console.WriteLine("\t3. Serie fibonacci");
      Console.WriteLine("\t4. Números pares entre 1 a 100");
      Console.WriteLine("\t5. Nombre y número del mes");
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
      int anio = Convert.ToInt32(Console.ReadLine());
      bool esBisiesto = (anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0);
      if (esBisiesto) {
        Console.WriteLine($"El año {anio} es bisiesto.");
      } else {
        Console.WriteLine($"El año {anio} no es bisiesto.");
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

    private static void NumerosPares() {
      Console.WriteLine("\nNúmeros pares entre 1 y 100:");
      for (int i = 2; i <= 100; i += 2) {
        Console.Write($"{i} ");
      }
      Console.WriteLine("");
    }

    private static void NombreMes(string nombreMes) {
      int numeroMes = DateTime.ParseExact(nombreMes.ToLower(), "MMMM", new CultureInfo("es-ES")).Month;

      Console.WriteLine($"\n{nombreMes} + {numeroMes}");
    }
  }
}

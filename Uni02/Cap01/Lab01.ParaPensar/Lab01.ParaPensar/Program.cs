using System.Globalization;
using System.Text;

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
          case ConsoleKey.D6:
            NumeroRomano();
            break;
          case ConsoleKey.D7:
            NumerosPrimosGemelos();
            break;
          case ConsoleKey.D8:
            Clave();
            break;
          case ConsoleKey.D9:
            ArbolAscii();
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
      Console.WriteLine("\t6. Número romano");
      Console.WriteLine("\t7. Números primos gemelos");
      Console.WriteLine("\t8. Algoritmo de clave");
      Console.WriteLine("\t9. Arbol ASCII");
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

    private static void NumeroRomano() {
      Console.WriteLine("\nNúmero romano:");
      Console.WriteLine("Ingrese un número entero:");
      int num = Convert.ToInt32(Console.ReadLine());

      var valoresRomanos = new List<KeyValuePair<int, string>>
      {
        new KeyValuePair<int, string>(1000, "M"),
        new KeyValuePair<int, string>(900, "CM"),
        new KeyValuePair<int, string>(500, "D"),
        new KeyValuePair<int, string>(400, "CD"),
        new KeyValuePair<int, string>(100, "C"),
        new KeyValuePair<int, string>(90, "XC"),
        new KeyValuePair<int, string>(50, "L"),
        new KeyValuePair<int, string>(40, "XL"),
        new KeyValuePair<int, string>(10, "X"),
        new KeyValuePair<int, string>(9, "IX"),
        new KeyValuePair<int, string>(5, "V"),
        new KeyValuePair<int, string>(4, "IV"),
        new KeyValuePair<int, string>(1, "I")
    };

      StringBuilder romano = new StringBuilder();
      int originalNum = num;

      foreach (var par in valoresRomanos) {
        while (num >= par.Key) {
          num -= par.Key;
          romano.Append(par.Value);
        }
      }
      Console.WriteLine($"\nEl equivalente de {originalNum} en romano es: {romano}");
    }

    private static void NumerosPrimosGemelos() {
      Console.WriteLine("\nNúmeros primos gemelos:");
      Console.WriteLine("Ingrese un número entero:");
      int n = Convert.ToInt32(Console.ReadLine());

      List<int> primos = new List<int>();
      for (int i = 2; i <= n; i++) {
        bool esPrimo = true;

        // Optimización: solo verificar hasta la raíz cuadrada de i,
        // ya que si i es divisible por algún número mayor a su raíz cuadrada,
        // entonces también lo será por un número menor.
        for (int j = 2; j <= Math.Sqrt(i); j++) {
          if (i % j == 0) {
            esPrimo = false;
            break;
          }
        }
        if (esPrimo) {
          primos.Add(i);
        }
      }

      Console.WriteLine("Números primos gemelos:");
      bool encontradosGemelos = false;
      for (int i = 0; i < primos.Count - 1; i++) {
        if (primos[i + 1] - primos[i] == 2) {
          Console.WriteLine($"{primos[i]} y {primos[i + 1]}");
          encontradosGemelos = true;
        }
      }
      if (!encontradosGemelos) {
        Console.WriteLine("No se encontraron números primos gemelos.");
      }
    }

    private static void Clave() {
      Console.WriteLine("\nAlgoritmo de clave:");
      int intento = 0;

      Console.WriteLine("Introduzca la clave a verificar:");
      string? clave = Console.ReadLine();

      Console.WriteLine("\nSimulación de Log In");
      string? claveIngresada;
      while (intento < 4) {
        intento++;
        Console.WriteLine("Introduzca la clave:");

        claveIngresada = Console.ReadLine();

        if (claveIngresada == clave) {
          Console.WriteLine("Clave correcta.");
          break;
        } else {
          Console.WriteLine("Clave incorrecta.");
        }
      }
    }

    private static void ArbolAscii() {
      Console.WriteLine("\nÁrbol ASCII:");
      Console.WriteLine("Ingrese un número filas:");
      int nf = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("");
      int anchoMax = nf * 2 - 1;

      for (int i = 1; i <= nf; i++) {
        int numAsteriscos = i * 2 - 1;
        string fila = new string('*', numAsteriscos);
        int espaciosIzq = (anchoMax - fila.Length) / 2;
        Console.WriteLine(new string(' ', espaciosIzq) + fila);
      }
    }
  }
}

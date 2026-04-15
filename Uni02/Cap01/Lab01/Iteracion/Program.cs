namespace Iteracion {
  internal class Program {
    static void Main(string[] args) {
      const int cantIteraciones = 5;
      string[] sentencias = new string[cantIteraciones];

      Console.WriteLine("Ingrese 5 sentencias:");
      for (int i = 0; i < cantIteraciones; i++) {
        Console.WriteLine();
        Console.WriteLine($"Sentencia {i + 1}:");
        sentencias[i] = Console.ReadLine();
      }

      Console.WriteLine();
      Console.WriteLine("Las sentencias ingresadas son:");
      foreach (string sen in sentencias) {
        Console.WriteLine(sen);
      }

      Console.ReadLine();
    }
  }
}

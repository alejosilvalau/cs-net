namespace Juegos {
  internal class Juego {
    private Jugada _record;

    public Juego() {
      _record = new Jugada(0);
    }

    public void ComenzarJuego() {
      bool continuar = true;
      Console.WriteLine("Comenzando el juego...");

      while (continuar) {
        Console.WriteLine("Ingrese el número máximo:");

        if (int.TryParse(Console.ReadLine(), out int maximo)) {
          Jugada j = new Jugada(maximo);
          if (int.TryParse(Console.ReadLine(), out int num)) {
            j.Comparar(num);

            if (j.Adivino == true && j.Intentos > PreguntarMaximo()) {
              _record = j;
              Console.WriteLine("Nuevo record conseguido!");
            }
            Continuar();
          }
        } else {
          Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
        }
      }


      // Mostrar información
    }

    private void CompararRecord() { }

    private bool Continuar() {
      Console.WriteLine("¿Desea continuar? (s/n)");
      string? respuesta = Console.ReadLine();
      if (string.IsNullOrEmpty(respuesta)) {
        return false;
      }
      return respuesta?.ToLower() == "s";
    }

    private int PreguntarMaximo() {
      return _record.Intentos;
    }
    private int PreguntarNumero() {
      return _record.Numero;
    }
  }
}

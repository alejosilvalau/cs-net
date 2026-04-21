namespace Juegos {
  internal class Jugada {
    private bool _adivino;
    private int _intentos;
    private int _numero;
    public bool Adivino {
      get => _adivino;
      set {
        _adivino = value;
      }
    }
    public int Intentos {
      get => _intentos;
      set {
        _intentos = value;
      }
    }
    public int Numero {
      get => _numero;
      set {
        _numero = value;
      }
    }

    public Jugada(int maxNumero) {
      Random rnd = new Random();
      Numero = rnd.Next(maxNumero);
      Intentos = int.MaxValue;
    }

    public void Comparar(int numero) {
      Intentos++;
      if (numero == Numero) {
        Adivino = true;
      }
    }
  }
}

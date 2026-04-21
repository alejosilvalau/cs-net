namespace Geometria {
  public class Circulo {
    private float m_radio;

    public float Radio {
      get => m_radio;
      set {
        m_radio = value;
      }
    }

    public float CalcularPerimetro() {
      return float.Pi * 2 * m_radio;
    }

    public float CalcularSuperficie() {
      return float.Pi * m_radio * m_radio;
    }
  }
}


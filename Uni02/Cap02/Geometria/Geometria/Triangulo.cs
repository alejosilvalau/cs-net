namespace Geometria {
  public class Triangulo {
    private float m_base;
    private float m_altura;

    private float m_lado1;
    private float m_lado2;
    private float m_lado3;

    public float Base {
      get => m_base;
      set {
        m_base = value;
      }
    }

    public float Altura {
      get => m_altura;
      set {
        m_altura = value;
      }
    }

    public float Lado1 {
      get => m_lado1;
      set {
        m_lado1 = value;
      }
    }

    public float Lado2 {
      get => m_lado2;
      set {
        m_lado2 = value;
      }
    }

    public float Lado3 {
      get => m_lado3;
      set {
        m_lado3 = value;
      }
    }

    public float CalcularPerimetro() {
      return Lado1 + Lado2 + Lado3;
    }

    public float CalcularSuperficie() {
      return (Base * Altura) / 2;
    }

  }
}

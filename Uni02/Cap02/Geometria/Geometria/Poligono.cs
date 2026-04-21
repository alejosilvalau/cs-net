namespace Geometria {
  public class Poligono {
    private float m_cantLados;
    private float m_longitudLado1;
    private float m_apotema;

    public float CantLados {
      get => m_cantLados;
      set {
        m_cantLados = value;
      }
    }
    public float LongitudLado1 {
      get => m_longitudLado1;
      set {
        m_longitudLado1 = value;
      }
    }

    public float Apotema {
      get => m_apotema;
      set {
        m_apotema = value;
      }
    }
    public virtual float CalcularPerimetro() {
      return CantLados * LongitudLado1;
    }

    public float CalcularSuperficie() {
      return (CalcularPerimetro() * Apotema) / 2;
    }

  }

  public class Rectangulo : Poligono {
    private float m_longitudLado2;

    public virtual float LongitudLado2 {
      get => m_longitudLado2;
      set {
        m_longitudLado2 = value;
      }
    }
    public override float CalcularPerimetro() {
      return 2 * (LongitudLado1 + LongitudLado2);
    }
  }

  public class Cuadrado : Rectangulo {
    public override float LongitudLado2 {
      get => LongitudLado1;
      set {
        LongitudLado1 = value;
      }
    }

    public override float CalcularPerimetro() {
      return 4 * LongitudLado1;
    }
  }
}

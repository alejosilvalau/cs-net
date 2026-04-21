namespace Clases {
  public class B : A {

    public B(string nombre = "Instancia de B") : base(nombre) {
    }

    public void M4() {
      Console.WriteLine("Metodo del hijo Invocado");
    }

  }
}

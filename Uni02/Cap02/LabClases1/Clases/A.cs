namespace Clases {
  public class A {
    string nombreDeInstancia;
    public A() {
      nombreDeInstancia = "Instancia sin nombre";
    }
    public A(string nombre) {
      nombreDeInstancia = nombre;
    }

    public void MostrarNombre() {
      Console.WriteLine(nombreDeInstancia);
    }

    public void M1() {
      Console.WriteLine("Se invoco M1");
    }
    public void M2() {
      Console.WriteLine("Se invoco M2");
    }
    public void M3() {
      Console.WriteLine("Se invoco M3");
    }


  }
}

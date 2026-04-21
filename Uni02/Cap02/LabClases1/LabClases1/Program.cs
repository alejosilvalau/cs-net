using Clases;

namespace LabClases1 {
  internal class Program {
    static void Main(string[] args) {
      A a1 = new A();
      B b1 = new B();

      Console.WriteLine("Métodos de A:");
      a1.MostrarNombre();
      a1.M1();
      a1.M2();
      a1.M3();

      Console.WriteLine("\nMétodos de B:");
      b1.MostrarNombre();
      b1.M1();
      b1.M2();
      b1.M3();
      b1.M4();
    }
  }
}

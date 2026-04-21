namespace Juegos
{
    internal class JugadaConAyuda : Jugada
    {
        public JugadaConAyuda(int maxNumero) : base(maxNumero) { }

        public override void Comparar(int num)
        {
            base.Comparar(num);
            if (!Adivino)
            {
                if (num > Numero)
                {
                    if ((num - Numero) == 100) Console.WriteLine("El número es mayor y está muy lejos");
                    if ((num - Numero) == 5) Console.WriteLine("El número es mayor y está cerca");
                }
                else
                {
                    if ((Numero - num) == 100) Console.WriteLine("El número es menor y está muy lejos");
                    if ((Numero - num) == 5) Console.WriteLine("El número es menor y está cerca");
                }
            }
        }
    }
}
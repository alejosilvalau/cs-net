namespace Juegos
{
    internal class Jugada
    {
        private bool _adivino;
        private int _intentos;
        private int _numero;
        public bool Adivino
        {
            get => _adivino;
            set
            {
                _adivino = value;
            }
        }
        public int Intentos
        {
            get => _intentos;
            set
            {
                _intentos = value;
            }
        }
        public int Numero
        {
            get => _numero;
            set
            {
                _numero = value;
            }
        }

        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            Numero = rnd.Next(1, maxNumero + 1);
        }

        public virtual void Comparar(int num)
        {
            Intentos++;
            if (num == Numero)
            {
                Adivino = true;
            }
        }
    }
}

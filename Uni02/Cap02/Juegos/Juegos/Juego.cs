namespace Juegos
{
    internal class Juego
    {
        private Jugada _record;

        public Juego()
        {
            _record = new Jugada(0);
        }

        public void ComenzarJuego()
        {
            bool continuarJuego = true;
            Console.WriteLine("Comenzando el juego...");

            while (continuarJuego)
            {
                Console.WriteLine("\nIngrese el número máximo:");
                if (int.TryParse(Console.ReadLine(), out int maximo))
                {
                    Console.WriteLine("\nNueva jugada creada!");
                    Jugada j = new Jugada(maximo);

                    bool continuarJugada = true;

                    while (continuarJugada)
                    {
                        Console.WriteLine("\nIngrese el número que usted piensa que es:");
                        if (int.TryParse(Console.ReadLine(), out int num))
                        {
                            j.Comparar(num);

                            if (j.Adivino == true)
                            {
                                Console.WriteLine("\nAdivinaste el número!");
                                CompararRecord(j);
                                continuarJugada = false;
                            }
                            else
                            {
                                Console.WriteLine("\nNúmero equivocado!");
                            }
                        }
                        if (continuarJugada)
                        {
                            continuarJugada = Continuar("la jugada");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
                }
                if (continuarJuego)
                {
                    continuarJuego = Continuar("el juego");
                }
            }
        }

        private void CompararRecord(Jugada j)
        {
            if (j.Intentos > PreguntarMaximo())
            {
                _record = j;
                Console.WriteLine("\nNuevo record conseguido!");
            }
        }

        private bool Continuar(string mensaje)
        {
            Console.WriteLine($"¿Desea continuar {mensaje}? (s/n)");
            string? respuesta = Console.ReadLine();
            if (string.IsNullOrEmpty(respuesta))
            {
                return false;
            }
            return respuesta?.ToLower() == "s";
        }

        private int PreguntarMaximo()
        {
            return _record.Intentos;
        }
        private int PreguntarNumero()
        {
            return _record.Numero;
        }
    }
}

namespace Juegos
{
    internal class Juego
    {
        private JugadaConAyuda _record;

        public Juego()
        {
            _record = new JugadaConAyuda(0);
            _record.Intentos = int.MaxValue;
            _record.Adivino = true;
        }

        public void ComenzarJuego()
        {
            bool continuarJuego = true;

            while (continuarJuego)
            {
                Console.WriteLine("Comenzando el juego...");
                PreguntarMaximo();
                continuarJuego = Continuar("Continuar programa");
            }
        }

        private void PreguntarMaximo()
        {
            Console.WriteLine("Ingrese el número máximo:");
            if (int.TryParse(Console.ReadLine(), out int maximo))
            {
                Console.WriteLine("Nueva jugada creada!");
                JugadaConAyuda j = new JugadaConAyuda(maximo);

                bool continuarJugada = true;
                while (continuarJugada)
                {
                    PreguntarNumero(j);
                    if (!j.Adivino)
                    {
                        continuarJugada = Continuar("Desea continuar la jugada");
                    }
                    else
                    {
                        continuarJugada = false;
                    }
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número máximo válido.");
            }
        }

        private bool Continuar(string mensaje)
        {
            while (true)
            {
                Console.WriteLine($"\n¿{mensaje}? (s/n)");
                string? respuesta = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(respuesta))
                {
                    continue;
                }

                respuesta = respuesta.Trim().ToLower();

                if (respuesta == "s")
                {
                    return true;
                }
                else if (respuesta == "n")
                {
                    return false;
                }
            }
        }

        private void PreguntarNumero(JugadaConAyuda j)
        {
            Console.WriteLine("\nIngrese el número que usted piensa que es:");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                j.Comparar(num);
                if (j.Adivino == true)
                {
                    Console.WriteLine("Adivinaste el número!");
                    CompararRecord(j);
                }
                else
                {
                    Console.WriteLine("Número equivocado!");
                }

            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
            }
        }
        private void CompararRecord(JugadaConAyuda j)
        {
            if (j.Intentos < _record.Intentos)
            {
                int intentosAnterior = _record.Intentos;
                _record = j;
                Console.WriteLine("Nuevo record conseguido!");
                if (intentosAnterior != int.MaxValue) Console.WriteLine($"Anterior: {intentosAnterior} intentos");
                Console.WriteLine($"Nuevo: {_record.Intentos} intentos");
            }
        }
    }
}

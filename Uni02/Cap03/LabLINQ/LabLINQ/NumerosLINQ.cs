namespace LabLINQ
{
    public static class NumerosLINQ
    {
        private static List<int> numeros = new List<int> { 30, 25, 40, 15, 50, 3, 4, 60, 70, 80 };
        public static void MostrarNumerosMayoresA20()
        {
            List<int> numerosMayoresA20 = numeros.Where(n => n > 20).ToList();
            Console.WriteLine("");
            Console.WriteLine("Lista de números mayores a 20:");
            numerosMayoresA20.ForEach(n => Console.WriteLine(n));
        }
    }
}

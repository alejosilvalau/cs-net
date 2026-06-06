using SilvaAlejo.Dominio;
using System;
using System.Collections.Generic;

namespace SilvaAlejo.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1er Examen parcial de Alejo Silva");

            List<Vehiculo> vehiculos = new List<Vehiculo>
            {
                new Auto("ABC111", 4, 1999, "Azul"),
                new Auto("DEF222", 4, 2005, "Rojo"),
                new Auto("GHI333", 2, 2010, "Yamaha"),
                new Auto("JKL444", 2, 2015, "Honda")
            };

            string patenteBuscada = "ABC111";
            Console.WriteLine($"\nBusqueda con LinQ de {patenteBuscada}");
            Console.WriteLine(ListaVehiculo.BuscaPatenteLinq(vehiculos, patenteBuscada)?.ToString() ?? "No se encontró el vehículo");

            Console.WriteLine($"\nBusqueda iterativa de {patenteBuscada}");
            Console.WriteLine(ListaVehiculo.BuscaPatenteIterativa(vehiculos, patenteBuscada)?.ToString() ?? "No se encontró el vehículo");

            Console.ReadKey();
        }
    }
}

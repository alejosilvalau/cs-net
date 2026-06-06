using SilvaAlejo.Dominio;
using System;
using System.Collections.Generic;

namespace SilvaAlejo.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa evaluación parcial");
            List<Dispositivo> dispositivos = new List<Dispositivo> {
            new Celular("C12345NET", "Samsung", 2025, "Galaxy S25"),
            new Celular("C12346NET", "Apple", 2025, "iPhone 25"),
            new Celular("C12347NET", "Google", 2025, "Pixel 25")
            };

            string nroSerieBuscado = "C12345NET";
            Console.WriteLine($"\nBusqueda de dispositivo por número de serie: {nroSerieBuscado}");
            Console.WriteLine("\nBusqueda con LINQ:");
            var dispositivoLinq = ListaDispositivo.BuscarNroSerieLinq(dispositivos, nroSerieBuscado);
            Console.WriteLine(dispositivoLinq != null ? dispositivoLinq.ToString() : "Dispositivo no encontrado");

            Console.WriteLine("\nBusqueda con método iterativo:");
            var dispositivoIterativo = ListaDispositivo.BuscarNroSerieIterativa(dispositivos, nroSerieBuscado);
            Console.WriteLine(dispositivoIterativo != null ? dispositivoIterativo.ToString() : "Dispositivo no encontrado");

            Console.ReadLine();
        }
    }
}

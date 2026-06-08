using System.Collections.Generic;
using System.Linq;

namespace SilvaAlejo.Dominio
{
    public static class ListaVehiculo
    {
        public static Vehiculo? BuscaPatenteLinq(IEnumerable<Vehiculo> vehiculos, string patente)
        {
            return vehiculos.Where(v => v.Patente == patente).FirstOrDefault();
            //return (from v in vehiculos
            //        where v.Patente == patente
            //        select v).FirstOrDefault();

        }

        //public static List<Vehiculo> BuscaPatentesLinq(IEnumerable<Vehiculo> vehiculos, string patente)
        //{
        //    return vehiculos.Where(v => v.Patente == patente && v.Patente.StartsWith("ABC")).ToList();
        //}

        public static Vehiculo? BuscaPatenteIterativa(IEnumerable<Vehiculo> vehiculos, string patente)
        {
            foreach (var vehiculo in vehiculos)
            {
                if (vehiculo.Patente == patente)
                {
                    return vehiculo;
                }
            }
            return null;
        }
    }
}

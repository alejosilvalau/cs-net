using System.Collections.Generic;
using System.Linq;

namespace SilvaAlejo.Dominio
{
    public class ListaDispositivo
    {
        public static Dispositivo? BuscarNroSerieLinq(List<Dispositivo> dispositivos, string nroSerie)
        {
            return dispositivos.Where(d => d.NroSerie == nroSerie).FirstOrDefault();
        }

        public static Dispositivo? BuscarNroSerieIterativa(List<Dispositivo> dispositivos, string nroSerie)
        {
            foreach (var dispositivo in dispositivos)
            {
                if (dispositivo.NroSerie == nroSerie)
                {
                    return dispositivo;
                }
            }
            return null;
        }
    }
}

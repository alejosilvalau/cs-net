namespace SilvaAlejo.Dominio
{
    public abstract class Dispositivo
    {
        public string NroSerie { get; set; }
        public string Marca { get; set; }
        public int AnioFabricacion { get; set; }
        protected Dispositivo(string nroSerie, string marca, int anioFabricacion)
        {
            this.NroSerie = nroSerie; this.Marca = marca; this.AnioFabricacion = anioFabricacion;
        }
        public override string ToString()
        {
            return $"Serie: {NroSerie} Marca: {Marca} Fabricación: {AnioFabricacion}";
        }
    }
}

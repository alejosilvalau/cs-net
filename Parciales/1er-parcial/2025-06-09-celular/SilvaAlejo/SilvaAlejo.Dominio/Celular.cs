namespace SilvaAlejo.Dominio
{
    public class Celular : Dispositivo
    {
        public string Modelo { get; private set; }

        public Celular(string nroSerie, string marca, int anioFabricacion, string modelo)
            : base(nroSerie, marca, anioFabricacion)
        {
            this.Modelo = modelo;
        }

        public override string ToString()
        {
            return base.ToString() + $" Modelo: {Modelo}";
        }
    }
}

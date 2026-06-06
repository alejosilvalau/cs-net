namespace SilvaAlejo.Dominio
{
    public class Auto : Vehiculo
    {
        public string Color { get; private set; }
        public Auto(string patente, int ruedas, int modelo, string color) : base(patente, ruedas, modelo)
        {
            this.Color = color;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Color: {Color}";
        }
    }
}

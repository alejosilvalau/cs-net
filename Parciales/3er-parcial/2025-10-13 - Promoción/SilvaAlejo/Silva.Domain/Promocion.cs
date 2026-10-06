namespace Silva.Domain
{
    public class Promocion
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal Descuento { get; set; }
        public string Estado { get; set; } = "Activa";
    }
}

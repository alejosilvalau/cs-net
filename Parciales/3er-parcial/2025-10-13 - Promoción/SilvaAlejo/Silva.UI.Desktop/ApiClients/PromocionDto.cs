namespace Silva.UI.Desktop.ApiClients
{
    public class PromocionDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public DateTime FechaInicio { get; set; } = DateTime.Today;
        public DateTime FechaFin { get; set; } = DateTime.Today.AddDays(5);
        public decimal Descuento { get; set; }
        public string Estado { get; set; } = "Activa";
    }
}

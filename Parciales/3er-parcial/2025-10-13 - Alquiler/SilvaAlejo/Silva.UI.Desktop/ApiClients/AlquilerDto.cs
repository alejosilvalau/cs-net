namespace Silva.UI.Desktop.ApiClients
{
    public class AlquilerDto
    {
        public int Id { get; set; }
        public string Inquilino { get; set; } = string.Empty;
        public decimal MontoAlquiler { get; set; }
        public DateTime FechaInicio { get; set; } = DateTime.Today;
        public DateTime FechaFin { get; set; } = DateTime.Today.AddYears(1);
        public string Estado { get; set; } = "Activo";
    }
}

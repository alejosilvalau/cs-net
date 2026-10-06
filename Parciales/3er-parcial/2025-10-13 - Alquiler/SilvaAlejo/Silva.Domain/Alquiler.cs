namespace Silva.Domain
{
    public class Alquiler
    {
        public int Id { get; private set; }
        public string Inquilino { get; private set; } = string.Empty;
        public decimal MontoAlquiler { get; private set; }
        public DateTime FechaInicio { get; private set; }
        public DateTime FechaFin { get; private set; }
        public string Estado { get; private set; } = "Activo";

        private Alquiler()
        {
            // Requerido por EF Core.
        }

        public Alquiler(string inquilino, decimal montoAlquiler, DateTime fechaInicio, DateTime fechaFin)
        {
            Inquilino = inquilino;
            MontoAlquiler = montoAlquiler;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Estado = "Activo";
        }

        public void Activar()
        {
            Estado = "Activo";
        }

        public void Finalizar()
        {
            Estado = "Finalizado";
        }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Silva.UI.Blazor.Models
{
    public class PromocionDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        public DateTime FechaInicio { get; set; } = DateTime.Today;

        [Required]
        public DateTime FechaFin { get; set; } = DateTime.Today.AddDays(5);

        [Range(1, 100, ErrorMessage = "El campo Descuento tiene que ser un valor comprendido entre 1 y 100.")]
        public decimal Descuento { get; set; } = 25;

        public string Estado { get; set; } = "Activa";
    }
}

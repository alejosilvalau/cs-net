using System.ComponentModel.DataAnnotations;

namespace LabBlazor.Models
{
    public class Alumno
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El apellido es obligatorio")]
        public string Apellido { get; set; } = string.Empty;

        [Required(ErrorMessage = "El legajo es obligatorio")]
        public string Legajo { get; set; } = string.Empty;

        [Required(ErrorMessage = "La direccion es obligatoria")]
        public string Direccion { get; set; } = string.Empty;
    }
}

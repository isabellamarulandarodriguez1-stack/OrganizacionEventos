using System.ComponentModel.DataAnnotations;

namespace OrganizacionEventos.Models
{
    public class Evento
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del evento es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede superar los 100 caracteres.")]
        [Display(Name = "Nombre del evento")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "La fecha es obligatoria.")]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "El lugar es obligatorio.")]
        [StringLength(150, ErrorMessage = "El lugar no puede superar los 150 caracteres.")]
        [Display(Name = "Lugar")]
        public string Lugar { get; set; } = string.Empty;

        [Required(ErrorMessage = "La categoría es obligatoria.")]
        [StringLength(60, ErrorMessage = "La categoría no puede superar los 60 caracteres.")]
        [Display(Name = "Categoría")]
        public string Categoria { get; set; } = string.Empty;
    }
}
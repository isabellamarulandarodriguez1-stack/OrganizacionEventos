namespace OrganizaciónEventos.Models
{
    public class RegistroVisitanteViewModel
    {
        public string? NombreCompleto { get; set; }
        public string? Correo { get; set; }
        public string? TipoServicio { get; set; }
        public decimal Precio { get; set; }
        public string? MetodoPago { get; set; }
    }
}
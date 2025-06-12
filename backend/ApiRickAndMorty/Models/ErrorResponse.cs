namespace ApiRickAndMorty.Models
{
    public class ErrorResponse
    {
        public string Mensaje { get; set; } = "Aparecio un error inesperado.";
        public string? Detalles { get; set; }
    }
}
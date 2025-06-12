using System.Text.Json.Serialization;

namespace ApiRickAndMorty.Models
{
    public class Informacion
    {
        [JsonPropertyName("count")]
        public int Contador { get; set; }

        [JsonPropertyName("pages")]
        public int Paginas { get; set; }

        [JsonPropertyName("next")]
        public string? Siguiente { get; set; }

        [JsonPropertyName("prev")]
        public string? Anterior { get; set; }
    }
}

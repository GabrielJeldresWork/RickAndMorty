using System.Text.Json.Serialization;

namespace ApiRickAndMorty.Models
{
    public class ApiResponse
    {
        [JsonPropertyName("info")]
        public Informacion? Informacion { get; set; }

        [JsonPropertyName("results")]
        public List<Episodio>? Resultado { get; set; }
    }
}

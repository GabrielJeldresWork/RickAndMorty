using System.Text.Json.Serialization;

namespace ApiRickAndMorty.Models
{
    public class Episodio
    {
        [JsonPropertyName("id")]
        public int Identificador { get; set; }

        [JsonPropertyName("name")]
        public string? Nombre { get; set; }

        [JsonPropertyName("air_date")]
        public string? Dato { get; set; }

        [JsonPropertyName("episode")]
        public string? TextoEpisodio { get; set; }

        [JsonPropertyName("characters")]
        public List<string>? Texto { get; set; }

        [JsonPropertyName("url")]
        public string? url { get; set; }

        [JsonPropertyName("created")]
        public string? Protagonista { get; set; }
    }

}

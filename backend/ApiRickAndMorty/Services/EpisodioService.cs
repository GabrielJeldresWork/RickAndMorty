using ApiRickAndMorty.Interfaces;
using ApiRickAndMorty.Models;
using Microsoft.Extensions.Options;
using System.Net.Http;
using System.Text.Json;

namespace ApiRickAndMorty.Services
{
    public class EpisodioService : IEpisodioServices
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public EpisodioService(HttpClient httpClient, IOptions<ApiSettings> apiSettings)
        {
            _httpClient = httpClient;
            _baseUrl = apiSettings.Value.RickAndMortyBaseUrl;
            _httpClient.BaseAddress = new Uri(_baseUrl);

        }

        public async Task<ApiResponse?> ObtenerEpisodio(int page)
        {
            var response = await _httpClient.GetAsync($"episode?page={page}");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<ApiResponse>(json, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            }

            return null;
        }

      
    }
}
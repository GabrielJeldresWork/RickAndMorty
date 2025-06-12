using ApiRickAndMorty.Models;

namespace ApiRickAndMorty.Interfaces
{
    public interface IEpisodioServices
    {
        Task<ApiResponse?> ObtenerEpisodio(int page);
    }
}
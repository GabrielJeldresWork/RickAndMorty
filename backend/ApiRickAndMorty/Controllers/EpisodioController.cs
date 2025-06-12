using ApiRickAndMorty.Interfaces;
using ApiRickAndMorty.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiRickAndMorty.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EpisodioController : Controller
    {
        private readonly IEpisodioServices _EpisodioServices;

        public EpisodioController(IEpisodioServices EpisodioServices)
        {
            _EpisodioServices = EpisodioServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetEpisodio([FromQuery] int page = 1)
        {
            if (page < 1)
            {
                return BadRequest(new
                {
                    mensaje = "El numero de pagina debe ser mayor o igual a 1.",
                    detalles = (string?)null
                });
            }

            var result = await _EpisodioServices.ObtenerEpisodio(page);

            if (result == null || result.Resultado == null || !result.Resultado.Any())
            {
                return NotFound(new
                {
                    mensaje = "No se encontraron episodios para la pagina solicitada.",
                    detalles = (string?)null
                });
            }

            return Ok(result);
        }
    }
}
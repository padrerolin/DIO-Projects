using Microsoft.AspNetCore.Mvc;
using C.Series.Interfaces;
namespace C.Series.Web.Controllers
{
    [Route("[controller]")]
    public class SerieControllerX : Controller
    {

        private readonly IRepositorio<Series> _repositorioSerie;

        public SerieControllerX(IRepositorio<Series> repositorioSerie)
        {
            _repositorioSerie = repositorioSerie;
        }




        [HttpGet("")]
        public IActionResult Lista()
        {

            return  Ok(_repositorioSerie.Lista().Select(s => new SerieModel(s)));

            IList<SerieModel> series = new List<SerieModel>();

            return Ok(series);
        }
        [HttpPut("{id}")]
        public IActionResult Atualiza(int id, [FromBody] SerieModel model)
        {
            _repositorioSerie.Atualiza(id, model.ToSerie());
            return NoContent();
        } 

        [HttpDelete("{id}")]
        public IActionResult Exclui (int id)
        {
            _repositorioSerie.Exclui(id);
            return NoContent();
        }
        [HttpPost("")]
        public IActionResult Insere([FromBody] SerieModel model)
        {


            model.Id = _repositorioSerie.ProximoId();
            Series serie = model.ToSerie();

        
            _repositorioSerie.Insere(serie);
            return Created("", serie);
        }

        [HttpGet("{id}")]
        public IActionResult Consulta(int id )
        {
            return Ok(_repositorioSerie.Lista().FirstOrDefault(s => s.Id == id));
        }


    }
}

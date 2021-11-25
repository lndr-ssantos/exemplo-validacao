using ExemploValidacaoModel.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExemploValidacaoModel.Controllers
{
    [ApiController]
    [Route("teste")]
    public class TesteController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] TesteModel teste)
        {
            return Ok(teste);
        }
    }
}

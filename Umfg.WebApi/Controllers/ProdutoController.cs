using Microsoft.AspNetCore.Mvc;
using Umfg.Dominio.Interfaces;

namespace Umfg.WebApi.Controllers
{
    [ApiController]
    [Route("api/v2/produto")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoServico _servico;

        [HttpGet]
        public IActionResult ObterTodos() => Ok(_servico.ObterTodos());
    }
}
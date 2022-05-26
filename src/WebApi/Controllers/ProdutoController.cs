using Microsoft.AspNetCore.Mvc;
using TesteTecnomyl.Cadastros.Aplicacoes.DTOs.Produtos;
using TesteTecnomyl.Cadastros.Aplicacoes.Interfaces.Clientes;
using TesteTecnomyl.Cadastros.Aplicacoes.Interfaces.Produtos;

namespace WebApi.Controllers
{
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoAppService _produtoAppService;

        /// <inheritdoc/>
        public ProdutoController(IProdutoAppService produtoAppService)
        {
            _produtoAppService = produtoAppService;
        }

        [HttpPost]
        [Route("produto")]
        public IActionResult CadastrarProduto([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Dados inválidos.");
                }

                _produtoAppService.Adicionar(produtoDto);

                return Accepted();
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }

        [HttpPut]
        [Route("produto")]
        public IActionResult AtualizarProduto([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Dados inválidos.");
                }

                _produtoAppService.Atualizar(produtoDto);

                return Accepted();
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }

        [HttpGet]
        [Route("produtos")]
        public async Task<IActionResult> ObterProdutoAsync()
        {
            try
            {
                var produtos = await _produtoAppService.ObterTodos();

                return Ok(produtos);
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }

        [HttpGet]
        [Route("produto")]
        public async Task<IActionResult> ObterProdutoAsync([FromQuery] int codigo)
        {
            try
            {
                var produto = await _produtoAppService.ObterPorId(codigo);

                return Ok(produto);
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }
    }
}

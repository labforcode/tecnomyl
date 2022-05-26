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

        /// <summary>
        /// Cadastro de produto
        /// </summary>
        /// <param name="produtoDto"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Atualização de produto
        /// </summary>
        /// <param name="produtoDto"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Retorna um produto por código
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("produto/codigo/{codigo}")]
        public async Task<IActionResult> ObterProdutoAsync(int codigo)
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

        /// <summary>
        /// Retorna o valor médio de venda de um produto nos últimos doze meses
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("produto/valor-medio/{codigo}")]
        public async Task<IActionResult> ObterValorMedioVendaProdutoUltimosDozeMesesAsync(int codigo)
        {
            try
            {
                var media = await _produtoAppService.ObterValorMedioVendaProdutoUltimosDozeMesesAsync(codigo);

                return Ok(media);
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }

        /// <summary>
        /// Retorna todos os produtos
        /// </summary>
        /// <returns></returns>
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
    }
}

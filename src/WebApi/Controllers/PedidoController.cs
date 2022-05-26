using Microsoft.AspNetCore.Mvc;
using TesteTecnomyl.Cadastros.Aplicacoes.DTOs.Pedidos;
using TesteTecnomyl.Cadastros.Aplicacoes.Interfaces.Pedidos;

namespace WebApi.Controllers
{
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoAppService _pedidoAppService;

        /// <inheritdoc/>
        public PedidoController(IPedidoAppService pedidoAppService)
        {
            _pedidoAppService = pedidoAppService;
        }

        /// <summary>
        /// Cadastro de pedido
        /// </summary>
        /// <param name="pedidoDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("pedido")]
        public IActionResult CadastrarPedido([FromBody] PedidoDto pedidoDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Dados inválidos.");
                }

                _pedidoAppService.Adicionar(pedidoDto);

                return Accepted();
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }

        /// <summary>
        /// Atualização de pedido
        /// </summary>
        /// <param name="produtoDto"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("pedido")]
        public IActionResult AtualizarPedido([FromBody] PedidoDto produtoDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Dados inválidos.");
                }

                _pedidoAppService.Atualizar(produtoDto);

                return Accepted();
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }

        /// <summary>
        /// Retorna um pedido por código
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("pedido/codigo/{codigo}")]
        public async Task<IActionResult> ObterPedidoAsync(int codigo)
        {
            try
            {
                var pedido = await _pedidoAppService.ObterPorId(codigo);

                return Ok(pedido);
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }

        /// <summary>
        /// Retorna um peido por código do cliente
        /// </summary>
        /// <param name="codigoCliente"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("pedido/codigo-cliente/{codigoCliente}")]
        public async Task<IActionResult> ObterPedidoPorClienteAsync(int codigoCliente)
        {
            try
            {
                var pedido = await _pedidoAppService.ObterPorCodigoCliente(codigoCliente);

                return Ok(pedido);
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }

        /// <summary>
        /// Retorna todos os pedidos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("pedidos")]
        public async Task<IActionResult> ObterPedidosAsync()
        {
            try
            {
                var pedidos = await _pedidoAppService.ObterTodos();

                return Ok(pedidos);
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }
    }
}

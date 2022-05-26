using Microsoft.AspNetCore.Mvc;
using TesteTecnomyl.Cadastros.Aplicacoes.DTOs.Clientes;
using TesteTecnomyl.Cadastros.Aplicacoes.Interfaces.Clientes;

namespace WebApi.Controllers
{
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteAppService _clienteAppService;

        public ClienteController(IClienteAppService clienteAppService)
        {
            _clienteAppService = clienteAppService;
        }

        [HttpPost]
        [Route("cliente")]
        public IActionResult CadastrarCliente([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Dados inválidos.");
                }

                _clienteAppService.Adicionar(clienteDto);

                return Accepted();
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }

        [HttpPut]
        [Route("cliente")]
        public IActionResult AtualizarCliente([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Dados inválidos.");
                }

                _clienteAppService.Atualizar(clienteDto);

                return Accepted();
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }

        [HttpGet]
        [Route("clientes")]
        public async Task<IActionResult> ObterClientesAsync()
        {
            try
            {
                var clientes = await _clienteAppService.ObterTodos();

                return Ok(clientes);
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }

        [HttpGet]
        [Route("cliente")]
        public async Task<IActionResult> ObterClienteAsync([FromQuery] int codigo)
        {
            try
            {
                var cliente = await _clienteAppService.ObterPorId(codigo);

                return Ok(cliente);
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }
    }
}

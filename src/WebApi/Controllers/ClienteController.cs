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

        /// <summary>
        /// Cadastro de cliente
        /// </summary>
        /// <param name="clienteDto"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Atualização de cliente
        /// </summary>
        /// <param name="clienteDto"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Retorna um cliente por código
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("cliente/codigo/{codigo}")]
        public async Task<IActionResult> ObterClienteAsync(int codigo)
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

        /// <summary>
        /// Retorna um cliente por CPF
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("cliente/cpf/{cpf}")]
        public async Task<IActionResult> ObterClienteAsync(string cpf)
        {
            try
            {
                if (string.IsNullOrEmpty(cpf)) return BadRequest("Cpf inválido.");

                var cliente = await _clienteAppService.ObterPorCpf(cpf);

                return Ok(cliente);
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }

        /// <summary>
        /// Retorna todos os clientes
        /// </summary>
        /// <returns></returns>
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
    }
}

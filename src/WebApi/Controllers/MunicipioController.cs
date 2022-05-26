using Microsoft.AspNetCore.Mvc;
using TesteTecnomyl.Cadastros.Aplicacoes.DTOs.Municipios;
using TesteTecnomyl.Cadastros.Aplicacoes.Interfaces.Municipios;

namespace WebApi.Controllers
{
    [ApiController]
    public class MunicipioController : ControllerBase
    {
        private readonly IMunicipioAppService _municipioAppService;

        /// <inheritdoc/>
        public MunicipioController(IMunicipioAppService municipioAppService)
        {
            _municipioAppService = municipioAppService;
        }

        [HttpPost]
        [Route("municipio")]
        public IActionResult CadastrarMunicipio([FromBody] MunicipioDto municipioDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Dados inválidos.");
                }

                _municipioAppService.Adicionar(municipioDto);

                return Accepted();
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }

        [HttpPut]
        [Route("municipio")]
        public IActionResult AtualizarMunicipio([FromBody] MunicipioDto municipioDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Dados inválidos.");
                }

                _municipioAppService.Atualizar(municipioDto);

                return Accepted();
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }

        [HttpGet]
        [Route("municipios")]
        public async Task<IActionResult> ObterMunicipiosAsync()
        {
            try
            {
                var municipios = await _municipioAppService.ObterTodos();

                return Ok(municipios);
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }

        [HttpGet]
        [Route("municipio")]
        public async Task<IActionResult> ObterMunicipioAsync([FromQuery] int codigo)
        {
            try
            {
                var municipio = await _municipioAppService.ObterPorId(codigo);

                return Ok(municipio);
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }
    }
}

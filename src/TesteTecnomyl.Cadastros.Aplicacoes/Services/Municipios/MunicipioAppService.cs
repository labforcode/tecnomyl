using AutoMapper;
using TesteTecnomyl.Cadastros.Aplicacoes.DTOs.Municipios;
using TesteTecnomyl.Cadastros.Aplicacoes.Interfaces.Municipios;
using TesteTecnomyl.Cadastros.Aplicacoes.ViewModels.Municipios;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Municipios;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Comandos.Municipios;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Consultas.Municipios;

namespace TesteTecnomyl.Cadastros.Aplicacoes.Services.Municipios
{
    public class MunicipioAppService : IMunicipioAppService
    {
        private readonly IMapper _mapper;
        private readonly IMunicipioComando _municipioComando;
        private readonly IMunicipioConsulta _municipioConsulta;

        public MunicipioAppService(IMapper mapper,
                                 IMunicipioComando municipioComando,
                                 IMunicipioConsulta municipioConsulta)
        {
            _mapper = mapper;
            _municipioComando = municipioComando;
            _municipioConsulta = municipioConsulta;
        }

        public void Adicionar(MunicipioDto municipio)
        {
            var comando = _mapper.Map<Municipio>(municipio);
            _municipioComando.Adicionar(comando);
        }

        public void Atualizar(MunicipioDto municipio)
        {
            var comando = _mapper.Map<Municipio>(municipio);
            _municipioComando.Atualizar(comando);
        }

        public void Excluir(MunicipioDto municipio)
        {
            var comando = _mapper.Map<Municipio>(municipio);
            _municipioComando.Excluir(comando);
        }

        public async Task<MunicipioViewModel> ObterPorId(int codigo)
        {
            return _mapper.Map<MunicipioViewModel>(await _municipioConsulta.ObterPorId(codigo));
        }

        public async Task<IEnumerable<MunicipioViewModel>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<MunicipioViewModel>>(await _municipioConsulta.ObterTodos());
        }
    }
}

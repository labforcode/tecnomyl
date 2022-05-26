using AutoMapper;
using TesteTecnomyl.Cadastros.Aplicacoes.DTOs.Clientes;
using TesteTecnomyl.Cadastros.Aplicacoes.Interfaces.Clientes;
using TesteTecnomyl.Cadastros.Aplicacoes.ViewModels.Clientes;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Clientes;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Comandos.Clientes;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Consultas.Clientes;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Consultas.Municipios;

namespace TesteTecnomyl.Cadastros.Aplicacoes.Services.Clientes
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly IMapper _mapper;
        private readonly IClienteComando _clienteComando;
        private readonly IClienteConsulta _clienteConsulta;
        private readonly IMunicipioConsulta _municipioConsulta;

        public ClienteAppService(IMapper mapper,
                                 IClienteComando clienteComando,
                                 IClienteConsulta clienteConsulta,
                                 IMunicipioConsulta municipioConsulta)
        {
            _mapper = mapper;
            _clienteComando = clienteComando;
            _clienteConsulta = clienteConsulta;
            _municipioConsulta = municipioConsulta;
        }

        public void Adicionar(ClienteDto cliente)
        {
            var comando = _mapper.Map<Cliente>(cliente);
            _clienteComando.Adicionar(comando);
        }

        public void Atualizar(ClienteDto cliente)
        {
            var comando = _mapper.Map<Cliente>(cliente);
            _clienteComando.Atualizar(comando);
        }

        public void Excluir(ClienteDto cliente)
        {
            var comando = _mapper.Map<Cliente>(cliente);
            _clienteComando.Excluir(comando);
        }

        public async Task<ClienteViewModel> ObterPorId(int codigo)
        {
            var cliente = _mapper.Map<ClienteViewModel>(await _clienteConsulta.ObterPorId(codigo));
            cliente.Municipio = await _municipioConsulta.ObterNomeMunicipio(cliente.CodigoMunicipio);

            return cliente;
        }

        public async Task<ClienteViewModel> ObterPorCpf(string cpf)
        {
            var cliente = _mapper.Map<ClienteViewModel>(await _clienteConsulta.ObterPorCpf(cpf));
            cliente.Municipio = await _municipioConsulta.ObterNomeMunicipio(cliente.CodigoMunicipio);

            return cliente;
        }

        public async Task<IEnumerable<ClienteViewModel>> ObterTodos()
        {
            var clientes = _mapper.Map<IEnumerable<ClienteViewModel>>(await _clienteConsulta.ObterTodos());
            foreach (var cliente in clientes)
            {
                cliente.Municipio = await _municipioConsulta.ObterNomeMunicipio(cliente.CodigoMunicipio);
            }           
            
            return clientes;
        }
    }
}

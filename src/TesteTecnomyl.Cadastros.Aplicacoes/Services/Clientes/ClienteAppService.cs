using AutoMapper;
using TesteTecnomyl.Cadastros.Aplicacoes.DTOs.Clientes;
using TesteTecnomyl.Cadastros.Aplicacoes.Interfaces.Clientes;
using TesteTecnomyl.Cadastros.Aplicacoes.ViewModels.Clientes;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Clientes;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Comandos.Clientes;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Consultas.Clientes;

namespace TesteTecnomyl.Cadastros.Aplicacoes.Services.Clientes
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly IMapper _mapper;
        private readonly IClienteComando _clienteComando;
        private readonly IClienteConsulta _clienteConsulta;

        public ClienteAppService(IMapper mapper,
                                 IClienteComando clienteComando,
                                 IClienteConsulta clienteConsulta)
        {
            _mapper = mapper;
            _clienteComando = clienteComando;
            _clienteConsulta = clienteConsulta;
        }

        public void Adicionar(ClienteDto cliente)
        {
            var comando = _mapper.Map<Cliente>(cliente);
            _clienteComando.Adicionar(comando);
        }

        public void Atualizar(ClienteDto cliente)
        {
            var comando = _mapper.Map<Cliente>(cliente);
        }

        public void Excluir(ClienteDto cliente)
        {
            throw new NotImplementedException();
        }

        public async Task<ClienteViewModel> ObterPorId(int codigo)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ClienteViewModel>> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}

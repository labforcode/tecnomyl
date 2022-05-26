using System.Collections.Generic;
using System.Threading.Tasks;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Clientes;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Consultas.Clientes;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Repositorios.Clientes;

namespace TesteTecnomyl.Cadastros.Dominios.Consultas.Clientes
{
    public class ClienteConsulta : IClienteConsulta
    {
        private readonly IClienteRepositoryEf _clienteRepositoryEf;

        public ClienteConsulta(IClienteRepositoryEf clienteRepositoryEf)
        {
            _clienteRepositoryEf = clienteRepositoryEf;
        }

        public async Task<Cliente> ObterPorId(int codigo)
        {
            return await _clienteRepositoryEf.ObterPorId(codigo);
        }

        public async Task<Cliente> ObterPorCpf(string cpf)
        {
            return await _clienteRepositoryEf.ObterPorCpf(cpf);
        }

        public async Task<IEnumerable<Cliente>> ObterTodos()
        {
            return await _clienteRepositoryEf.ObterTodos();
        }
    }
}

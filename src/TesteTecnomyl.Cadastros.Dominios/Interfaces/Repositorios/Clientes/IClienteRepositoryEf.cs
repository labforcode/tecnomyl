using System.Collections.Generic;
using System.Threading.Tasks;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Clientes;

namespace TesteTecnomyl.Cadastros.Dominios.Interfaces.Repositorios.Clientes
{
    public interface IClienteRepositoryEf : IBaseRepositoryEf<Cliente>
    {
        Task<Cliente> ObterPorId(int codigo);

        Task<Cliente> ObterPorCpf(string cpf);

        Task<IEnumerable<Cliente>> ObterTodos();
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Clientes;

namespace TesteTecnomyl.Cadastros.Dominios.Interfaces.Repositorios.Clientes
{
    public interface IClienteRepositoryEf : IBaseRepositoryEf<Cliente>
    {
        Task<Cliente> ObterPorId();

        Task<IEnumerable<Cliente>> ObterTodos();
    }
}

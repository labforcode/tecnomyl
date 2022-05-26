using System.Collections.Generic;
using System.Threading.Tasks;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Clientes;

namespace TesteTecnomyl.Cadastros.Dominios.Interfaces.Consultas.Clientes
{
    public interface IClienteConsulta
    {
        Task<Cliente> ObterPorId();

        Task<IEnumerable<Cliente>> ObterTodos();
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Pedidos;

namespace TesteTecnomyl.Cadastros.Dominios.Interfaces.Repositorios.Pedidos
{
    public interface IPedidoRepositoryEf : IBaseRepositoryEf<Pedido>
    {
        Task<Pedido> ObterPorId();

        Task<IEnumerable<Pedido>> ObterTodos();
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Pedidos;

namespace TesteTecnomyl.Cadastros.Dominios.Interfaces.Repositorios.Pedidos
{
    public interface IPedidoRepositoryEf : IBaseRepositoryEf<Pedido>
    {
        void AddItensPedido(List<ItemPedido> itensPedido);

        Task<Pedido> ObterPorId(int codigo);

        Task<IEnumerable<Pedido>> ObterTodos();
    }
}

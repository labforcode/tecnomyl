using System.Collections.Generic;
using System.Threading.Tasks;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Pedidos;

namespace TesteTecnomyl.Cadastros.Dominios.Interfaces.Consultas.Pedidos
{
    public interface IPedidoConsulta
    {
        Task<Pedido> ObterPorId(int codigo);

        Task<IEnumerable<Pedido>> ObterTodos();
    }
}

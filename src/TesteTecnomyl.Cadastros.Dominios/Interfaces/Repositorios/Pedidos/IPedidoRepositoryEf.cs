using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Pedidos;

namespace TesteTecnomyl.Cadastros.Dominios.Interfaces.Repositorios.Pedidos
{
    public interface IPedidoRepositoryEf : IBaseRepositoryEf<Pedido>
    {
        void AddItensPedido(List<ItemPedido> itensPedido);

        Task<Pedido> ObterPorId(int codigo);

        Task<List<Pedido>> ObterPorCodigoCliente(int codigoCliente);

        Task<List<ItemPedido>> ObterItensPedido(int codigoPedido);

        Task<List<ItemPedido>> ObterItensPedidoPorCodigos(List<int> codigos);

        Task<List<Pedido>> ObterPedidos(DateTime dataInicio, DateTime dataFim);

        Task<List<Pedido>> ObterTodos();
    }
}

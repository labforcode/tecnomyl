using System.Collections.Generic;
using System.Linq;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Pedidos;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Comandos.Pedidos;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Repositorios.Pedidos;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.UoW;

namespace TesteTecnomyl.Cadastros.Dominios.Comandos.Pedidos
{
    public class PedidoComando : IPedidoComando
    {
        private readonly IUnitOfWork _uow;
        private readonly IPedidoRepositoryEf _pedidoRepositoryEf;

        public PedidoComando(IUnitOfWork uow,
                             IPedidoRepositoryEf pedidoRepositoryEf)
        {
            _uow = uow;
            _pedidoRepositoryEf = pedidoRepositoryEf;
        }

        public void Adicionar(Pedido pedido, List<ItemPedido> itens)
        {
            pedido.AdicionarDataPedido();
            _pedidoRepositoryEf.Add(pedido);
            _uow.Commit();

            itens = itens.Select(itemPedido => { itemPedido.VincularPedido(pedido.Codigo); return itemPedido; }).ToList();

            pedido.AdicionarItensPedido(itens);

            _pedidoRepositoryEf.AddItensPedido(pedido.ObterItensPedido());
            _uow.Commit();
        }

        public void Atualizar(Pedido pedido, List<ItemPedido> itens)
        {
            _pedidoRepositoryEf.Update(pedido);
            _uow.Commit();
        }

        public void Excluir(Pedido pedido, List<ItemPedido> itens)
        {
            _pedidoRepositoryEf.Delete(pedido);
            _uow.Commit();
        }
    }
}

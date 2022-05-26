using System.Collections.Generic;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Pedidos;

namespace TesteTecnomyl.Cadastros.Dominios.Interfaces.Comandos.Pedidos
{
    public interface IPedidoComando
    {
        void Adicionar(Pedido pedido, List<ItemPedido> itens);

        void Atualizar(Pedido pedido, List<ItemPedido> itens);

        void Excluir(Pedido pedido, List<ItemPedido> itens);
    }
}

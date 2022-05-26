using TesteTecnomyl.Cadastros.Dominios.Entidades.Pedidos;

namespace TesteTecnomyl.Cadastros.Dominios.Interfaces.Comandos.Pedidos
{
    public interface IPedidoComando
    {
        void Adicionar(Pedido pedido);

        void Atualizar(Pedido pedido);

        void Excluir(Pedido pedido);
    }
}

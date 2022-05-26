using TesteTecnomyl.Cadastros.Dominios.Entidades.Produtos;

namespace TesteTecnomyl.Cadastros.Dominios.Entidades.Pedidos
{
    public class ItemPedido
    {
        public ItemPedido(int codigo,
                          decimal valor,
                          int quantidade,
                          string observacao,
                          int codigoProduto,
                          int codigoPedido)
        {
            Codigo = codigo;
            Valor = valor;
            Quantidade = quantidade;
            Observacao = observacao;
            CodigoProduto = codigoProduto;
            CodigoPedido = codigoPedido;
        }

        protected ItemPedido()
        {
        }

        public int Codigo { get; private set; }

        public decimal Valor { get; private set; }

        public int Quantidade { get; private set; }

        public string Observacao { get; private set; }

        public int CodigoProduto { get; private set; }

        public int CodigoPedido { get; private set; }

        public virtual Produto Produto { get; set; }

        public virtual Pedido Pedido { get; set; }
    }
}

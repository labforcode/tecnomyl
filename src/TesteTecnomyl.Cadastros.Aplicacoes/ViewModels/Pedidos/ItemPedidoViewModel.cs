namespace TesteTecnomyl.Cadastros.Aplicacoes.ViewModels.Pedidos
{
    public class ItemPedidoViewModel
    {
        public int Codigo { get; set; }

        public decimal Valor { get; set; }

        public int Quantidade { get; set; }

        public string Observacao { get; set; }

        public int CodigoProduto { get; set; }

        public string NomeProduto { get; set; }

        public int CodigoPedido { get; set; }
    }
}

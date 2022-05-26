namespace TesteTecnomyl.Cadastros.Aplicacoes.ViewModels.Pedidos
{
    public class PedidoViewModel
    {
        public int Codigo { get; set; }

        public int CodigoCliente { get; set; }

        public string NomeCliente { get; set; }

        public DateTime DataPedido { get; set; }

        public List<ItemPedidoViewModel> ItensPedido { get; set; }
    }
}

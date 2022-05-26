namespace TesteTecnomyl.Cadastros.Aplicacoes.DTOs.Pedidos
{
    public class ItemPedidoDto
    {
        public decimal Valor { get; set; }

        public int Quantidade { get; set; }

        public string Observacao { get; set; }

        public int CodigoProduto { get; set; }
    }
}

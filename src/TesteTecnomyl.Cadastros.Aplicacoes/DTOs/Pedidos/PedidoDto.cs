namespace TesteTecnomyl.Cadastros.Aplicacoes.DTOs.Pedidos
{
    public class PedidoDto
    {
        public int CodigoCliente { get; set; }

        public List<ItemPedidoDto> ItensPedido { get; set; }
    }
}

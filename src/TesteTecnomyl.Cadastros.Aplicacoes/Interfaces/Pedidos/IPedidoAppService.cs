using TesteTecnomyl.Cadastros.Aplicacoes.DTOs.Pedidos;
using TesteTecnomyl.Cadastros.Aplicacoes.ViewModels.Pedidos;

namespace TesteTecnomyl.Cadastros.Aplicacoes.Interfaces.Pedidos
{
    public interface IPedidoAppService
    {
        void Adicionar(PedidoDto pedido);

        void Atualizar(PedidoDto pedido);

        void Excluir(PedidoDto pedido);

        Task<PedidoViewModel> ObterPorId(int codigo);

        Task<List<PedidoViewModel>> ObterPorCodigoCliente(int codigoCliente);

        Task<List<PedidoViewModel>> ObterPedidos(DateTime dataInicio, DateTime dataFim);

        Task<List<PedidoViewModel>> ObterTodos();

        Task<List<ItemPedidoViewModel>> ObterItensPedidoPorCodigos(List<int> codigos);
    }
}

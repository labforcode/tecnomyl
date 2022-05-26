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

        Task<IEnumerable<PedidoViewModel>> ObterTodos();
    }
}

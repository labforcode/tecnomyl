using TesteTecnomyl.Cadastros.Aplicacoes.DTOs.Produtos;
using TesteTecnomyl.Cadastros.Aplicacoes.ViewModels.Produtos;

namespace TesteTecnomyl.Cadastros.Aplicacoes.Interfaces.Produtos
{
    public interface IProdutoAppService
    {
        void Adicionar(ProdutoDto produto);

        void Atualizar(ProdutoDto produto);

        void Excluir(ProdutoDto produto);

        Task<ProdutoViewModel> ObterPorId(int codigo);

        Task<ProdutoValorMedioViewModel> ObterValorMedioVendaProdutoUltimosDozeMesesAsync(int codigo);

        Task<IEnumerable<ProdutoViewModel>> ObterTodos();
    }
}

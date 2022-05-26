using System.Collections.Generic;
using System.Threading.Tasks;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Produtos;

namespace TesteTecnomyl.Cadastros.Dominios.Interfaces.Repositorios.Produtos
{
    public interface IProdutoRepositoryEf : IBaseRepositoryEf<Produto>
    {
        Task<Produto> ObterPorId();

        Task<IEnumerable<Produto>> ObterTodos();
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Produtos;

namespace TesteTecnomyl.Cadastros.Dominios.Interfaces.Consultas.Produtos
{
    public interface IProdutoConsulta
    {
        Task<Produto> ObterPorId();

        Task<IEnumerable<Produto>> ObterTodos();
    }
}

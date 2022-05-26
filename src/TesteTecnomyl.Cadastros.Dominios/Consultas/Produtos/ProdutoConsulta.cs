using System.Collections.Generic;
using System.Threading.Tasks;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Produtos;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Consultas.Produtos;

namespace TesteTecnomyl.Cadastros.Dominios.Consultas.Produtos
{
    public class ProdutoConsulta : IProdutoConsulta
    {
        public Task<Produto> ObterPorId()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Produto>> ObterTodos()
        {
            throw new System.NotImplementedException();
        }
    }
}

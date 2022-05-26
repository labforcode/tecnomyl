using System.Collections.Generic;
using System.Threading.Tasks;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Produtos;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Consultas.Produtos;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Repositorios.Produtos;

namespace TesteTecnomyl.Cadastros.Dominios.Consultas.Produtos
{
    public class ProdutoConsulta : IProdutoConsulta
    {
        private readonly IProdutoRepositoryEf _produtoRepositoryEf;

        public ProdutoConsulta(IProdutoRepositoryEf produtoRepositoryEf)
        {
            _produtoRepositoryEf = produtoRepositoryEf;
        }

        public async Task<Produto> ObterPorId(int codigo)
        {
            return await _produtoRepositoryEf.ObterPorId(codigo);
        }

        public async Task<IEnumerable<Produto>> ObterTodos()
        {
            return await _produtoRepositoryEf.ObterTodos();
        }
    }
}

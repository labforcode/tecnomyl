using Microsoft.EntityFrameworkCore;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Produtos;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Repositorios.Produtos;
using TesteTecnomyl.Cadastros.Infra.Dados.Contextos;

namespace TesteTecnomyl.Cadastros.Infra.Dados.Repositorios.Produtos
{
    public class ProdutoRepositoryEf : BaseRepositoryEf<Produto>, IProdutoRepositoryEf
    {
        public ProdutoRepositoryEf(DbTecnomyl context) : base(context)
        {
        }

        public async Task<Produto> ObterPorId(int codigo)
        {
            try
            {
                return await Context.Produtos.FirstOrDefaultAsync(w => w.Codigo == codigo);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<IEnumerable<Produto>> ObterTodos()
        {
            try
            {
                return await Context.Produtos.ToListAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}

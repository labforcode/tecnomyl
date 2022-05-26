using Microsoft.EntityFrameworkCore;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Produtos;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Repositorios.Produtos;
using TesteTecnomyl.Cadastros.Infra.Dados.Contextos;

namespace TesteTecnomyl.Cadastros.Infra.Dados.Repositorios.Produtos
{
    public class ProdutoRepositoryEf : BaseRepositoryEf<Produto>, IProdutoRepositoryEf
    {
        private readonly DbTecnomyl _context;
        private readonly DbSet<Produto> _dbSet;

        public ProdutoRepositoryEf(DbTecnomyl context) : base(context)
        {
        }

        public Task<Produto> ObterPorId()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Produto>> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}

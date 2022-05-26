using Microsoft.EntityFrameworkCore;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Pedidos;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Repositorios.Pedidos;
using TesteTecnomyl.Cadastros.Infra.Dados.Contextos;

namespace TesteTecnomyl.Cadastros.Infra.Dados.Repositorios.Pedidos
{
    public class PedidoRepositoryEf : BaseRepositoryEf<Pedido>, IPedidoRepositoryEf
    {
        private readonly DbTecnomyl _context;
        private readonly DbSet<Pedido> _dbSet;

        public PedidoRepositoryEf(DbTecnomyl context) : base(context)
        {
        }

        public Task<Pedido> ObterPorId()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Pedido>> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Clientes;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Repositorios.Clientes;
using TesteTecnomyl.Cadastros.Infra.Dados.Contextos;

namespace TesteTecnomyl.Cadastros.Infra.Dados.Repositorios.Clientes
{
    public class ClienteRepositoryEf : BaseRepositoryEf<Cliente>, IClienteRepositoryEf
    {
        private readonly DbTecnomyl _context;
        private readonly DbSet<Cliente> _dbSet;

        public ClienteRepositoryEf(DbTecnomyl context) : base(context)
        {
        }

        public Task<Cliente> ObterPorId()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Cliente>> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}

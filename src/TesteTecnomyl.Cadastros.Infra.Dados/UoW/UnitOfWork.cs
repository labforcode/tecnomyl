using TesteTecnomyl.Cadastros.Dominios.Interfaces.UoW;
using TesteTecnomyl.Cadastros.Infra.Dados.Contextos;

namespace TesteTecnomyl.Cadastros.Infra.Dados.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbTecnomyl _context;

        public UnitOfWork(DbTecnomyl context)
        {
            _context = context;
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

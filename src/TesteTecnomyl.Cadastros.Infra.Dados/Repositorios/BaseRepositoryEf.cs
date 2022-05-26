using Microsoft.EntityFrameworkCore;
using TesteTecnomyl.Cadastros.Dominios.Interfaces.Repositorios;
using TesteTecnomyl.Cadastros.Infra.Dados.Contextos;

namespace TesteTecnomyl.Cadastros.Infra.Dados.Repositorios
{
    public class BaseRepositoryEf<T> : IBaseRepositoryEf<T> where T : class
    {
        protected DbTecnomyl Context;
        private readonly DbSet<T> _dbSet;

        public BaseRepositoryEf(DbTecnomyl context)
        {
            Context = context;
            _dbSet = context.Set<T>();
        }

        public void Add(T t)
        {
            _dbSet.Add(t);
        }

        public void Add(List<T> t)
        {
            _dbSet.AddRange(t);
        }

        public void Update(T t)
        {
            _dbSet.Update(t);
        }

        public void Delete(T t)
        {
            _dbSet.Remove(t);
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

using System;

namespace TesteTecnomyl.Cadastros.Dominios.Interfaces.Repositorios
{
    public interface IBaseRepositoryEf<T> : IDisposable where T : class
    {
        void Add(T t);

        void Update(T t);

        void Delete(T t);
    }
}

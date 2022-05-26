using System;
using System.Collections.Generic;

namespace TesteTecnomyl.Cadastros.Dominios.Interfaces.Repositorios
{
    public interface IBaseRepositoryEf<T> : IDisposable where T : class
    {
        void Add(T t);

        void Add(List<T> t);

        void Update(T t);

        void Delete(T t);
    }
}

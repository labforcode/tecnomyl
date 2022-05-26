using System;

namespace TesteTecnomyl.Cadastros.Dominios.Interfaces.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}

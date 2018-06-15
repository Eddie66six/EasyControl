using System;

namespace EasyControl.Dominio
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}
using Kelasi.Model;
using System;

namespace Kelasi.DAL.Contracts
{
    public interface IDatabaseFactory : IDisposable
    {
        KelasiEntities Get();
    }
}

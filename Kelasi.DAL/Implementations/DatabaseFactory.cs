using Kelasi.DAL.Contracts;
using Kelasi.Model;

namespace Kelasi.DAL.Implementations
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private KelasiEntities dataContext;
        public KelasiEntities Get()
        {
            return dataContext ?? (dataContext = new KelasiEntities());
        }
        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}

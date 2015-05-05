using CachetMortgage.DAL.Repository.Contract;

namespace CachetMortgage.DAL.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICMContext GetCAContext()
        {
            return new CMContext();
        }
        public void Commit(ICMContext context)
        {
            ((IDBContext)context).Commit();
        }
    }
}

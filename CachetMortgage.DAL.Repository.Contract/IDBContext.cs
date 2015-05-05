using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace CachetMortgage.DAL.Repository.Contract
{
    public interface IDBContext
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry Entry(object entity);

        Database GetDataBase();

        void Commit();
    }
}

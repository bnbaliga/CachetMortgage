using System;
using System.Linq;

namespace CachetMortgage.DAL.Repository.Contract
{
    public interface IGenericRepository<T> where T : class
    {
        T Add(ICMContext dataContext, T entity);

        T Update(ICMContext dataContext, T entity);

        bool Delete(ICMContext dataContext, T entity);

        bool DeleteAll(ICMContext dataContext, Func<T, Boolean> where);

        T GetById(ICMContext dataContext, dynamic id);

        IQueryable<T> GetAllQuery(ICMContext dataContext);
    }
}


namespace CachetMortgage.DAL.Repository.Contract
{
    public interface IUnitOfWork
    {
        ICMContext GetCAContext();

        void Commit(ICMContext context);
    }
}

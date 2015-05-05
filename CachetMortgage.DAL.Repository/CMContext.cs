using CachetMortgage.DAL.Repository.Contract;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace CachetMortgage.DAL.Repository
{
    public class CMContext : DbContext, ICMContext, IDBContext
    {
        static CMContext()
        {
            Database.SetInitializer<CMContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
            //modelBuilder.Configurations.Add(new RuleSectionMapper());
        }
        
        public new DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        public new DbEntityEntry Entry(object entity)
        {
            return base.Entry(entity);
        }
        public Database GetDataBase()
        {
            return base.Database;
        }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        #region

        // Track whether Dispose has been called. 
        private bool disposed = false;


        // Use C# destructor syntax for finalization code. 
        // This destructor will run only if the Dispose method does not get called. 
        // It gives your base class the opportunity to finalize. Do not provide destructors in types derived from this class.
        ~CMContext()
        {
            // Do not re-create Dispose clean-up code here. Calling Dispose(false) is optimal in terms of readability and maintainability.
            Dispose(false);
        }

        // A derived class should not be able to override this method. 
        public new void Dispose()
        {
            Dispose(true);
            // This object will be cleaned up by the Dispose method.  Therefore, you should call GC.SupressFinalize to take this object off the 
            // finalization queue and prevent finalization code for this object from executing a second time.
            GC.SuppressFinalize(this);
        }

        // Dispose(bool disposing) executes in two distinct scenarios. 
        // If disposing equals true, the method has been called directly or indirectly by a user's code. Managed and unmanaged resources can be disposed. 
        // If disposing equals false, the method has been called by the runtime from inside the finalizer and you should not reference other objects. 
        // Only unmanaged resources can be disposed. 
        protected new void Dispose(bool disposing)
        {
            // Check to see if Dispose has already been called. 
            if (!this.disposed)
            {
                // If disposing equals true, dispose all managed and unmanaged resources. 
                if (disposing)
                {
                    // Dispose managed resources.
                    base.Dispose();
                }

                // Note disposing has been done.
                this.disposed = true;
            }
        }
        #endregion
    }
}

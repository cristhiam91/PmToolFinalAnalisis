using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PmTool.DAL.Repository
{
    public class UnitOfWork : IDisposable
    {
        private readonly IRepositoryProvider provider;
        private readonly DbContext dbContext;
        Dictionary<Type, IRepository> repositories;
        private bool disposed = false;

        public UnitOfWork(DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.provider = new RepositoryProvider(this.dbContext);
            this.dbContext.Database.CommandTimeout = 120000;
            this.repositories = new Dictionary<Type, IRepository>();
        }

        public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class
        {
            var type = typeof(TEntity);

            if (!repositories.ContainsKey(type))
            {
                IGenericRepository<TEntity> entity = provider.GetGenericRepository<TEntity>();
                repositories.Add(type, entity);
            }

            return repositories[type] as IGenericRepository<TEntity>;
        }
        void Save()
        {
            dbContext.SaveChanges();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    dbContext.Dispose();
                }
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

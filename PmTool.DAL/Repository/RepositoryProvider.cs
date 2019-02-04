using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PmTool.DAL.Repository
{
   public class RepositoryProvider : IRepositoryProvider
    {
        private readonly DbContext dbContext;
        public RepositoryProvider(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IGenericRepository<TEntity> GetGenericRepository<TEntity>() where TEntity : class
        {
            return new GenericRepository<TEntity>(dbContext);
        }
    }
}

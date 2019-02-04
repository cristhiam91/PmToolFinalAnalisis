using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PmTool.DAL.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly DbContext dbContext;
        private DbSet<TEntity> dbSet = null;

        public GenericRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.dbSet = this.dbContext.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            this.dbSet.Add(entity);
            dbContext.SaveChanges();
        }

        public void Attach(TEntity entity)
        {
            this.dbSet.Attach(entity);
            dbContext.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            if (dbContext.Entry(entity).State == EntityState.Detached)
            {
                this.dbSet.Attach(entity);
            }
            this.dbSet.Remove(entity);
            dbContext.SaveChanges();
        }

        public IQueryable<TEntity> FindAll(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException("predicate", "predicate null");
            }

            try
            {
                IQueryable<TEntity> result = dbSet.Where(predicate);
                return result;
            }
            catch { throw; }
        }

        public TEntity FindSingle(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException("predicate", "predicate null");
            }

            try
            {
                return FindAll(predicate).SingleOrDefault();
            }
            catch { throw; }
        }



        public IQueryable<TEntity> GetAll()
        {
            return this.dbSet;
        }

        public TEntity GetById(object id)
        {
            return this.dbSet.Find(id);
        }


        public void Update(TEntity entity)
        {
            this.dbSet.Attach(entity);
            dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PmTool.DAL.Repository
{
    public interface IGenericRepository<TEntity> : IRepository
    {
        void Add(TEntity entity);
        void Attach(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        IQueryable<TEntity> GetAll();
        TEntity GetById(object id);

        IQueryable<TEntity> FindAll(Expression<Func<TEntity, bool>> predicate);
        TEntity FindSingle(Expression<Func<TEntity, bool>> predicate);
    }
}

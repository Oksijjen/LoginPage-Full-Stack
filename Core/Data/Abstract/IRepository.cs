using Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Abstract
{
    public interface IRepository<TEntity>
        where TEntity : AudiTableEntity, IBaseDomain, new()
    {
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter, params string[] includelist);
        TEntity Get(Expression<Func<TEntity, bool>> filter, params string[] includelist);
        TEntity GetById(int Id, params string[] includelist);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Delete(int Id);
    }
}

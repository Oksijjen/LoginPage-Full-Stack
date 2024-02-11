using Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LoginPage.Business.Abstract
{
    public interface IBusinessBase<TEntity>
        where TEntity : AudiTableEntity, IBaseDomain, new()
    {
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter, params string[] incluedelist);
        TEntity Get(Expression<Func<TEntity, bool>> filter, params string[] incluedelist);
        TEntity GetById(int Id, params string[] incluedelist);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Delete(int Id);
    }
}

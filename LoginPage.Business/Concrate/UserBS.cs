using LoginPage.Business.Abstract;
using LoginPage.DataAccess.Abstract;
using LoginPage.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LoginPage.Business.Concrate
{
    public class UserBS : IUserBS
    {
        private readonly IUserRepository _repo;
        public UserBS(IUserRepository repo)
        {
            _repo = repo;
        }

        public void Delete(User entity)
        {
            _repo.Delete(entity.Id);
        }

        public void Delete(int Id)
        {
            _repo.Delete(Id);
        }

        public User Get(Expression<Func<User, bool>> filter, params string[] incluedelist)
        {
            return _repo.Get(filter, incluedelist);
        }

        public List<User> GetAll(Expression<Func<User, bool>> filter, params string[] incluedelist)
        {
            return _repo.GetAll(filter, incluedelist);
        }

        public User GetById(int Id, params string[] incluedelist)
        {
            return _repo.GetById(Id, incluedelist);
        }

        public void Insert(User entity)
        {
            _repo.Insert(entity);
        }

        public void Update(User entity)
        {
            _repo.Update(entity);
        }
    }
}

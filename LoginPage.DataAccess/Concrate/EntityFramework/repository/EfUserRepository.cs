using Core.Data.Concrate.EntityFramework;
using LoginPage.DataAccess.Abstract;
using LoginPage.DataAccess.Concrate.EntityFramework.context;
using LoginPage.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPage.DataAccess.Concrate.EntityFramework.repository
{
    public class EfUserRepository : EfRepositoryBase<User, LoginPageDBContext>, IUserRepository
    {
    }
}

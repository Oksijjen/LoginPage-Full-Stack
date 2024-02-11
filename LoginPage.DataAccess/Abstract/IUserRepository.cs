using Core.Data.Abstract;
using LoginPage.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPage.DataAccess.Abstract
{
    public interface IUserRepository:IRepository<User>
    {
    }
}

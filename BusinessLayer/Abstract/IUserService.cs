using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserService
    {
        void AddUser();
        void AddInfo(User user);
        User GetById(int id);
        void UserUpdate(Profile profile);

    }
}

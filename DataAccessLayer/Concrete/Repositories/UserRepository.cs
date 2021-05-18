using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    

    public class UserRepository : IUserDal
    {

        private readonly Context dataContext;

        public UserRepository(Context dataContext)
        {
            this.dataContext = dataContext;
        }
       
        DbSet<User> _object;

        public void Delete(User e)
        {
            e.Status = false;
            dataContext.SaveChanges();
        }

        public List<User> GetList() => _object.ToList();


        public List<User> GetList(Expression<Func<User, bool>> filter) =>
            _object.Where(filter).ToList();

        public void Insert(User e)
        {
            _object.Add(e);
            dataContext.SaveChanges();
        }

        public void Update(User e)
        {
            dataContext.SaveChanges();
        }

        public User Get(Expression<Func<User, bool>> filter) =>
            _object.Where(filter).FirstOrDefault();

    }
}

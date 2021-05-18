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
    class FollowersRepository : IFollowersDal
    {
        private readonly Context dataContext;

        public FollowersRepository(Context dataContext)
        {
            this.dataContext = dataContext;
        }

        DbSet<Followers> _object;


        public void Delete(Followers e)
        {
            _object.Remove(e);
            dataContext.SaveChanges();
        }

        public Followers Get(Expression<Func<Followers, bool>> filter)=>
            _object.Where(filter).FirstOrDefault();

        public List<Followers> GetList() => _object.ToList();

        public List<Followers> GetList(Expression<Func<Followers, bool>> filter) => 
            _object.Where(filter).ToList();

        public void Insert(Followers e)
        {
            _object.Add(e);
            dataContext.SaveChanges();
        }

        public void Update(Followers e)
        {
            dataContext.SaveChanges();
        }
    }
}

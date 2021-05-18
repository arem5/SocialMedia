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
    public class ProfileRepository : IProfileDal
    {

        private readonly Context dataContext;

        public ProfileRepository(Context dataContext)
        {
            this.dataContext = dataContext;
        }

        DbSet<Profile> _object;

        public void Delete(Profile e)
        {
            _object.Remove(e);
            dataContext.SaveChanges();
        }

        public List<Profile> GetList() => _object.ToList();


        public List<Profile> GetList(Expression<Func<Profile, bool>> filter) => 
            _object.Where(filter).ToList();

        public void Insert(Profile e)
        {
            _object.Add(e);
            dataContext.SaveChanges();
        }

        public void Update(Profile e)
        {
            dataContext.SaveChanges();
        }

        public Profile Get(Expression<Func<Profile, bool>> filter) =>
            _object.Where(filter).FirstOrDefault();

    }
}

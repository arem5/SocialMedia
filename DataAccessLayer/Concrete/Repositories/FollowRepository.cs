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
    public class FollowRepository : IFollowDal
    {
        private readonly Context dataContext;

        public FollowRepository(Context dataContext)
        {
            this.dataContext = dataContext;
        }

        DbSet<Follow> _object;

        public void Delete(Follow e)
        {
            _object.Remove(e);
            dataContext.SaveChanges();
        }

        public Follow Get(Expression<Func<Follow, bool>> filter) =>
            _object.Where(filter).FirstOrDefault();

        public List<Follow> GetList() => _object.ToList();


        public List<Follow> GetList(Expression<Func<Follow, bool>> filter) =>
            _object.Where(filter).ToList();

        public void Insert(Follow e)
        {
            _object.Add(e);
            dataContext.SaveChanges();
        }

        public void Update(Follow e)
        {
            dataContext.SaveChanges();
        }
    }
}

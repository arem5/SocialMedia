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
    public class TweetRepository : ITweetDal
    {
        private readonly Context dataContext;

        public TweetRepository(Context dataContext)
        {
            this.dataContext = dataContext;
        }

        DbSet<Tweet> _object;
        public void Delete(Tweet e)
        {
            _object.Remove(e);
            dataContext.SaveChanges();
        }

        public Tweet Get(Expression<Func<Tweet, bool>> filter) => _object.Where(filter).FirstOrDefault();

        public List<Tweet> GetList() => _object.ToList();

        public List<Tweet> GetList(Expression<Func<Tweet, bool>> filter) => _object.Where(filter).ToList();

        public void Insert(Tweet e)
        {
            _object.Add(e);
            dataContext.SaveChanges();
        }

        public void Update(Tweet e)
        {
            dataContext.SaveChanges();
        }
    }
}

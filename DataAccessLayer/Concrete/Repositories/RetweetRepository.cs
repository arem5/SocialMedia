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
    public class RetweetRepository : IRetweetDal
    {
        private readonly Context dataContext;

        public RetweetRepository(Context dataContext)
        {
            this.dataContext = dataContext;
        }

        DbSet<Retweet> _object;

        public void Delete(Retweet e)
        {
            _object.Remove(e);
            dataContext.SaveChanges();
        }

        public Retweet Get(Expression<Func<Retweet, bool>> filter) => _object.Where(filter).FirstOrDefault();


        public List<Retweet> GetList() => _object.ToList();


        public List<Retweet> GetList(Expression<Func<Retweet, bool>> filter) => _object.Where(filter).ToList();

        public void Insert(Retweet e)
        {
            _object.Add(e);
            dataContext.SaveChanges();
        }

        public void Update(Retweet e)
        {
            dataContext.SaveChanges();
        }
    }
}

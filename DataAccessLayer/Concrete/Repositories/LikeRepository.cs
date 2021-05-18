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
    public class LikeRepository : ILikeDal
    {
        private readonly Context dataContext;

        public LikeRepository(Context dataContext)
        {
            this.dataContext = dataContext;
        }

        DbSet<Like> _object;

        public void Delete(Like e)
        {
            _object.Remove(e);
            dataContext.SaveChanges();
        }

        public Like Get(Expression<Func<Like, bool>> filter) => _object.Where(filter).FirstOrDefault();


        public List<Like> GetList() => _object.ToList();


        public List<Like> GetList(Expression<Func<Like, bool>> filter) => _object.Where(filter).ToList();

        public void Insert(Like e)
        {
            _object.Add(e);
            dataContext.SaveChanges();
        }

        public void Update(Like e)
        {
            dataContext.SaveChanges();
        }
    }
}

using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly Context context;

        public GenericRepository(Context context)
        {
            this.context = context;
        }

        public void Delete(T e)
        {
            context.Set<T>().Remove(e);
            context.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter) => context.Set<T>().FirstOrDefault(filter);

        public List<T> GetList() => context.Set<T>().ToList();


        public List<T> GetList(Expression<Func<T, bool>> filter) => context.Set<T>().Where(filter).ToList();

        public void Insert(T e)
        {
            context.Set<T>().Add(e);
            context.SaveChanges();
        }

        public void Update(T e)
        {
            context.SaveChanges();
        }
        public bool Any(Expression<Func<T, bool>> exp) => context.Set<T>().Any(exp);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {

        List<T> GetList();

        void Insert(T e);

        T Get(Expression<Func<T, bool>> filter);        //Tek değer döndürür

        void Update(T e);

        void Delete(T e);

        List<T> GetList(Expression<Func<T, bool>> filter); //Şartlı Listeleme yapar.
    }
}

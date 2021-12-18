using System;
using Core.Entities;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

//core katmanı diğer katmanları referans almaz
namespace Core.DataAccess
{
    //generic constraint
    //class: referans tip demek
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    //new(): new'lenebilir olmalı
    public interface IEntityRepository<T> where  T : class,IEntity,new()
    {
        // listeleme
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}

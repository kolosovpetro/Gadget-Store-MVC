using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using GadgetStoreMVC.Data.Context;
using GadgetStoreMVC.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GadgetStoreMVC.Repository.BaseRepository
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {

        private readonly PostgresContext _storeContext;
        private readonly DbSet<T> _dbSet;

        protected RepositoryBase(PostgresContext storeContext)
        {
            _storeContext = storeContext;
            _dbSet = _storeContext.Set<T>();
        }


        public virtual void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void Update(T entity)
        {
            _dbSet.Attach(entity);
            _storeContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public virtual void Delete(Expression<Func<T, bool>> @where)
        {
            var objects = _dbSet.Where(where).AsEnumerable();
            _dbSet.RemoveRange(objects);
        }

        public void Delete(IEnumerable<T> objects)
        {
            _dbSet.RemoveRange(objects);
        }

        public virtual T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public virtual T Get(Expression<Func<T, bool>> @where)
        {
            return _dbSet.Where(where).FirstOrDefault();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> @where)
        {
            return _dbSet.Where(where).ToList();
        }

        public void Save()
        {
            _storeContext.SaveChanges();
        }
    }
}

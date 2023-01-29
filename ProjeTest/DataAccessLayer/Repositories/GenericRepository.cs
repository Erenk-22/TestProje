using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        DbSet<T> _object;
        public GenericRepository()
        {
            _object = c.Set<T>();
        }
        public void Delete(T t)
        {
            var deleteEntity = c.Entry(t);
            deleteEntity.State = EntityState.Deleted;
            //_object.Remove(p);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find();
        }

        public List<T> GetListAll(Expression<Func<T, bool>> filter)
        {
            return filter == null ? c.Set<T>().ToList() :
                c.Set<T>().Where(filter).ToList();
        }
        public List<T> List()
        {
            return _object.ToList();
        }
        public void Insert(T t)
        {
            var addEntity = c.Entry(t);
            addEntity.State = EntityState.Added;
            //_object.Add(p);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            var updatedEntity = c.Entry(t);
            updatedEntity.State = EntityState.Modified;
            c.SaveChanges();
        }
        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }
    }
}

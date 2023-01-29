using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public interface IRepository<T> where T : class
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> List();
        List<T> GetListAll(Expression<Func<T, bool>> filter);
        T GetById(int id);
        T Get(Expression<Func<T, bool>> filter);
    }
}

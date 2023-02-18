using MyBlog.DataAccess.Abstract;
using MyBlog.DataAccess.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        Context _database;

        public GenericRepository(Context database)
        {
            _database = database;
        }

        public void Delete(T t)
        {
            _database.Remove(t);
            _database.SaveChanges();
        }
        public List<T> GetAllList()
        {
            return _database.Set<T>().ToList();
        }
        public T GetById(int id)
        {
            return _database.Set<T>().Find(id);
        }
        public void Insert(T t)
        {
            _database.Add(t);
            _database.SaveChanges();
        }
        public List<T> GetAllList(Expression<Func<T, bool>> filter)
        {
            return _database.Set<T>().Where(filter).ToList();
        }
        public void Update(T t)
        {
            _database.Update(t);
            _database.SaveChanges();
        }
    }
}
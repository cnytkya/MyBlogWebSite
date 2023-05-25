using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T item)
        {
            using var entity = new AppDbContext();
            entity.Remove(item);
            entity.SaveChanges();
        }

        public T GetById(int id)
        {
            using var entity = new AppDbContext();
            return entity.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            using var entity = new AppDbContext();
            return entity.Set<T>().ToList();
        }

        public void Insert(T item)
        {
            using var entity = new AppDbContext();
            entity.Add(item);
            entity.SaveChanges();
        }

        public void Update(T item)
        {
            using var entity = new AppDbContext();
            entity.Update(item);
            entity.SaveChanges();
        }
    }
}

using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntitiLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        //AppDbContext b = new AppDbContext();
        public void AddBlog(Blog blog)
        {
            using var b = new AppDbContext();
            b.Add(blog);
            b.SaveChanges();
        }

        public void DeletBlog(Blog blog)
        {
            using var b = new AppDbContext();
            b.Remove(blog);
            b.SaveChanges();
        }

        public void Delete(Blog item)
        {
            throw new NotImplementedException();
        }

        public Blog GetById(int id)
        {
            using var b = new AppDbContext();
            return b.Blogs.Find(id);
        }

        public List<Blog> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Blog item)
        {
            throw new NotImplementedException();
        }

        public List<Blog> ListAllBlog()
        {
            using var b = new AppDbContext();
            return b.Blogs.ToList();
        }

        public void Update(Blog item)
        {
            throw new NotImplementedException();
        }

        public void UpdateBlog(Blog blog)
        {
            using var b = new AppDbContext();
            b.Update(blog);
            b.SaveChanges();
        }
    }
}

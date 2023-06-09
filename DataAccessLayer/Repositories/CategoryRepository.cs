﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntitiLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        AppDbContext c = new AppDbContext();
        public void AddCategory(Category category)
        {
            c.Add(category);
            c.SaveChanges();
        }

        public void DeletCategory(Category category)
        {
            c.Remove(category);
            c.SaveChanges();
        }

        public void Delete(Category item)
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            return c.Categories.Find(id);
        }

        public List<Category> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Category item)
        {
            throw new NotImplementedException();
        }

        public List<Category> ListAllCategory()
        {
            return c.Categories.ToList();
        }

        public void Update(Category item)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category category)
        {
            c.Update(category);
            c.SaveChanges();
        }
    }
}

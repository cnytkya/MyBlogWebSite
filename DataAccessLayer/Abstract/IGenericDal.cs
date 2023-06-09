﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class //T bir class a ait bütün değerleri kullanacak.
    {
        void Insert(T item);
        void Delete(T item);
        void Update(T item);
        List<T> GetListAll();
        T GetById(int id);
    }
}

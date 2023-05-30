using EntitiLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IBlogService
	{
		void BlogAdd(Blog blog);
		void CategoryDelete(Blog blog);
		void CategoryUpdate(Blog blog);
		List<Blog> GetList();
		Blog GetById(int id);
	}
}

using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
	{
		IBlogDal _blogDal;

		public BlogManager(IBlogDal blogDal)
		{
			_blogDal = blogDal;
		}

		public void BlogAdd(Blog blog)
		{
			_blogDal.Insert(blog);
		}

		public void CategoryDelete(Blog blog)
		{
			_blogDal.Delete(blog);
		}

		public void CategoryUpdate(Blog blog)
		{
			_blogDal.Update(blog);	
		}

		public Blog GetById(int id)
		{
			return _blogDal.GetById(id);
		}

		public List<Blog> GetList()
		{
			return _blogDal.GetListAll();
		}
	}
}

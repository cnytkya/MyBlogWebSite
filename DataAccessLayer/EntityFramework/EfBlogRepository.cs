using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntitiLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
    }
}

using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntitiLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfCommentRepository : GenericRepository<Comment>, ICommentDal
    {
    }
}

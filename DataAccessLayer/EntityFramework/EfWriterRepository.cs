using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntitiLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfWriterRepository : GenericRepository<Writer>, IWriterDal
    {
    }
}

using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntitiLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfAboutRepository : GenericRepository<About>, IAboutDal
    {
    }
}

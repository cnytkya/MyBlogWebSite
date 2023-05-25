using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntitiLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfContactRepository : GenericRepository<Contact>, IContactDal
    {
    }
}

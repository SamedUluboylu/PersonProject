using PersonProject.Core.DataAccess;
using PersonProject.Entities;

namespace PersonProject.DataAccess
{
    public interface IPersonDal:IEntityRepository<Person>
    {
    }
}

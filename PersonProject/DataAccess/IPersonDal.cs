using PersonProject.Core.DataAccess;
using PersonProject.DTOs;
using PersonProject.Entities;
using System.Collections.Generic;

namespace PersonProject.DataAccess
{
    public interface IPersonDal:IEntityRepository<Person>
    {
        List<PersonDetailDto> GetProductDetails();
    }
}

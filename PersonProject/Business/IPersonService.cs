using PersonProject.Core.Utilities;
using PersonProject.DTOs;
using PersonProject.Entities;
using System.Collections.Generic;

namespace PersonProject.Business
{
    public interface IPersonService
    {
        IDataResult<List<Person>> GetAll();
        IDataResult<List<Person>> GetById(int personId);
        IDataResult<List<PersonDetailDto>> GetPersonDetails();
        IResult Add(Person person);
        IResult Update(Person person);
        IResult Delete(Person person);
    }
}

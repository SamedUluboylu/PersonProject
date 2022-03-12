using PersonProject.Core.Utilities;
using PersonProject.Entities;
using System.Collections.Generic;

namespace PersonProject.Business
{
    public interface IContactService
    {
        IDataResult<List<Contact>> GetAllContact();
        IDataResult<Contact> GetByLocation(string location);
        IResult Add(Contact contact);
        IResult Update(Contact contact);
        IResult Delete(Contact contact);
    }
}

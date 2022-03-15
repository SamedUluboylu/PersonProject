using PersonProject.Core.Utilities;
using PersonProject.DTOs;
using PersonProject.Entities;
using System.Collections.Generic;

namespace PersonProject.Business
{
    public interface IContactService
    {
        IDataResult<List<Contact>> GetAllContact();
        IDataResult<List<ContactDetailDto>> GetContactDetails(string location);
        IResult Add(List<CreateContactModel> contact);
        IResult Update(Contact contact);
        IResult Delete(int id);
    }
}

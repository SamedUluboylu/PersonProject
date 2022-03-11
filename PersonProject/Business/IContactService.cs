using PersonProject.Core.Utilities;
using PersonProject.Entities;
using System.Collections.Generic;

namespace PersonProject.Business
{
    public interface IContactService
    {
        IDataResult<List<Contact>> GetAll();
        IDataResult<Contact> GetByLocation(string location);
    }
}

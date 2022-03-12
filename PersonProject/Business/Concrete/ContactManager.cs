using PersonProject.Core.Utilities;
using PersonProject.DataAccess;
using PersonProject.Entities;
using System;
using System.Collections.Generic;

namespace PersonProject.Business.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;
        IPersonService _personService;

        public ContactManager(IPersonService personService, IContactDal contactDal)
        {
            _contactDal = _contactDal;
            _personService = personService;
        }

        public IResult Add(Contact contact)
        {
            IResult result = null;
            if (result!=null)
            {
                return result;
            }
            _contactDal.Add(contact);
            return new SuccessResult();
        }

        public IResult Delete(Contact contact)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<Contact>> GetAllContact()
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<Contact> GetByLocation(string location)
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(Contact contact)
        {
            var result=_contactDal.GetAll(p=>p.ContactId==contact.ContactId).Count;
            if (result >= 10)
            {
                return new ErrorResult();
            }
            _contactDal.Update(contact);
            throw new NotImplementedException();
        }
    }
}

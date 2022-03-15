using PersonProject.Core.Utilities;
using PersonProject.DataAccess;
using PersonProject.DTOs;
using PersonProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonProject.Business.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;
        IPersonService _personService;

        public ContactManager(IPersonService personService, IContactDal contactDal)
        {
            _contactDal = contactDal;
            _personService = personService;
        }

        public IResult Add(List<CreateContactModel> contact)
        {
            IResult result = null;
            if (!contact.Any())
            {
                return result;
            }
            List<Contact>contactlist=new List<Contact>();
            foreach (var item in contact)
            {
                contactlist.Add(new Contact()
                {
                    EmailAddress=item.EmailAddress,
                    Information=item.Information,
                    Location=item.Location,
                    PersonId=item.PersonId, 
                    PhoneNumber=item.PhoneNumber

                });
            }
            _contactDal.AddRange(contactlist);
            return new SuccessResult();
        }
        public IResult Delete(int id)
        {
            IResult result = null;
            if (id==default(int))
            {
                return result;
            }
            Contact contact = _contactDal.Get(i => i.Id == id);
            if (contact==null)
            {
                return result;
            }
            _contactDal.Delete(contact);
            return new SuccessResult();
        }

        public IDataResult<List<Contact>> GetAllContact()
        {
            return new SuccessDataResult<List<Contact>>(_contactDal.GetAll());
        }
        public IDataResult<List<ContactDetailDto>> GetContactDetails(string location)
        {
            return new SuccessDataResult<List<ContactDetailDto>>(_contactDal.GetContactDetails());
        }

        public IResult Update(Contact contact)
        {
            IResult result = null;
            var response=_contactDal.Get(p=>p.Id==contact.Id);
            if (response==null)
            {
                return result;
            }
            _contactDal.Update(contact);
            return new SuccessResult();
        }
    }
}

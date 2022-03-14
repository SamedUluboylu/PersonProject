using PersonProject.Core.Utilities;
using PersonProject.DataAccess;
using PersonProject.DTOs;
using PersonProject.Entities;
using System;
using System.Collections.Generic;

namespace PersonProject.Business.Concrete
{
    public class PersonManager : IPersonService
    {
        IPersonDal _personDal;
        IContactService _contactService;

        public PersonManager(IPersonDal personDal,IContactService contactService)
        {
            _personDal = personDal;
            _contactService = contactService;
        }

        public IResult Add(Person person)
        {
            IResult result = null;
            if (result!=null)
            {
                return result;
            }
            _personDal.Add(person);
            return new SuccessResult();
        }
        public IResult Delete(Person person)
        {
            var result = _personDal.GetAll(p=>p.Id== person.Id);
            if (result!=null)
            {
                return new ErrorResult();
            }
            _personDal.Delete(person);
            return new SuccessResult();
        }
        public IDataResult<List<Person>> GetAll()
        {
            if (DateTime.Now.Hour==1)
            {
                return new ErrorDataResult<List<Person>>();
            }
            return new SuccessDataResult<List<Person>>(_personDal.GetAll());
        }
          public IDataResult<List<Person>> GetById(int Id)
        {
            return new SuccessDataResult<List<Person>>(_personDal.GetAll(p=>p.Id ==Id));
        }

        public IDataResult<List<PersonDetailDto>> GetPersonDetails()
        {
           return new SuccessDataResult<List<PersonDetailDto>>(_personDal.GetPersonDetails());
        }

        public IResult Update(Person person)
        {
            var result = _personDal.GetAll(p => p.Id == person.Id).Count;
            if (result>=10)
            {
                return new ErrorResult();
            }
            _personDal.Update(person);
            return new SuccessResult();
        }
    }
}

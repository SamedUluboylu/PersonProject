using PersonProject.DTOs;
using PersonProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace PersonProject.DataAccess
{
    public class InMemoryPersonDal : IPersonDal
    {
        List<Person> _persons;

        public InMemoryPersonDal()
        {
            _persons = new List<Person>
            { 
                new Person {PersonId=1,ContactId=1,Name="Samed",LastName="Uluboylu",CompanyName="CompanyName"},
                
               
            };
        }
        public void Add(Person person)
        {
           _persons.Add(person);
        }

        public void Delete(Person person)
        {
            Person productToDelete = _persons.SingleOrDefault(p => p.ContactId == person.ContactId);

            _persons.Remove(productToDelete);
        }

        public Person Get(Expression<Func<Person, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAll(Expression<Func<Person, bool>> filter = null)
        {
            return _persons;
        }

        public List<PersonDetailDto> GetPersonDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Person person)
        {
            Person personToUpdate = _persons.SingleOrDefault(p => p.PersonId == person.PersonId);
            personToUpdate.PersonId = person.PersonId;
            personToUpdate.ContactId = person.ContactId;
            personToUpdate.Name = person.Name;
            personToUpdate.LastName = person.LastName;
            personToUpdate.CompanyName= person.CompanyName;
        }
    }
}

using PersonProject.Core.Entities;

namespace PersonProject.Entities
{
    public class Person:IEntity
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public decimal PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Location { get; set; }
        public string Information { get; set; }
    }
}

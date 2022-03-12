using PersonProject.Core.Entities;

namespace PersonProject.Entities
{
    public class Person:IEntity
    {
        public int PersonId { get; set; }
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }

    }
}

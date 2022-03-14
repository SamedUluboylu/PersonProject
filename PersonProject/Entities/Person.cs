using PersonProject.Core.Entities;

namespace PersonProject.Entities
{
    public class Person:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }

    }
}

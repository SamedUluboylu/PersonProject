using PersonProject.Core.Entities;

namespace PersonProject.Entities
{
    public class Contact:IEntity
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public long PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Location { get; set; }
        public string Information { get; set; }
    }
}

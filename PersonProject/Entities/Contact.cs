using PersonProject.Core.Entities;

namespace PersonProject.Entities
{
    public class Contact:IEntity
    {
        public int ContactId { get; set; }
        public decimal PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Location { get; set; }
        public string Information { get; set; }
    }
}

namespace PersonProject.DTOs
{
    public class ContactDetailDto
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public long PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Location { get; set; }
        public string Information { get; set; }
    }
}

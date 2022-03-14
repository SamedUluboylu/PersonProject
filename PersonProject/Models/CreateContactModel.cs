namespace PersonProject.Entities
{
    public class CreateContactModel
    {
        public int PersonId { get; set; }
        public long PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Location { get; set; }
        public string Information { get; set; }
    }
}

namespace PersonProject.DTOs
{
    public class PersonDetailDto:IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public decimal PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Location { get; set; }
        public string Information { get; set; }

    }
}

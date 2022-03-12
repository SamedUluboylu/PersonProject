namespace PersonProject.DTOs
{
    public class PersonDetailDto:IDto
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }

    }
}

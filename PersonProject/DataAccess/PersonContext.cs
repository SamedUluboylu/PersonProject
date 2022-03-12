using Microsoft.EntityFrameworkCore;
using PersonProject.Entities;

namespace PersonProject.DataAccess
{
    public class PersonContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=person;Trusted_Connection=true");
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}

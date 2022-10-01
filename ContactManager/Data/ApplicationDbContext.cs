using ContactManager.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactManager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Friend" },
                new Category { CategoryId = 2, CategoryName = "Acquintance" },
                new Category { CategoryId = 3, CategoryName = "Family" }
            );

            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    CategoryId = 1,
                    FirstName = "Jil",
                    LastName = "Mehta",
                    Phone = "647-832-1825",
                    Email = "jilmehta52@gmail.com",
                    Organization = "Yahoo"
                },
                new Contact
                {
                    ContactId = 2,
                    CategoryId = 1,
                    FirstName = "Nil",
                    LastName = "Mehta",
                    Phone = "647-832-1825",
                    Email = "nilmehta52@gmail.com",
                    Organization = "Google"
                },
                new Contact
                {
                    ContactId = 3,
                    CategoryId = 1,
                    FirstName = "Nachiketa",
                    LastName = "Mehta",
                    Phone = "647-832-1825",
                    Email = "nachiketamehta52@gmail.com",
                    Organization = "Facebook"
                },
                new Contact
                {
                    ContactId = 4,
                    CategoryId = 1,
                    FirstName = "Arjun",
                    LastName = "Pathak",
                    Phone = "647-832-1825",
                    Email = "ajp52@gmail.com",
                    Organization = "Yandex"
                },
                new Contact
                {
                    ContactId = 5,
                    CategoryId = 2,
                    FirstName = "Dewangi",
                    LastName = "Pathak",
                    Phone = "647-832-1825",
                    Email = "dewangiben@gmail.com",
                    Organization = "Baidu"
                },
                new Contact
                {
                    ContactId = 6,
                    CategoryId = 2,
                    FirstName = "Bhavya",
                    LastName = "Dave",
                    Phone = "647-832-1825",
                    Email = "llbbhavya@gmail.com",
                    Organization = "RSS"
                },
                new Contact
                {
                    ContactId = 7,
                    CategoryId = 2,
                    FirstName = "Bhakti",
                    LastName = "Dave",
                    Phone = "647-832-1825",
                    Email = "zansikirani@gmail.com",
                    Organization = "Zhansi"
                },
                new Contact
                {
                    ContactId = 8,
                    CategoryId = 2,
                    FirstName = "Aakangsha",
                    LastName = "Borisagar",
                    Phone = "647-832-1825",
                    Email = "itmeab@gmail.com",
                    Organization = "GujjuGarba"
                },
                new Contact
                {
                    ContactId = 9,
                    CategoryId = 3,
                    FirstName = "Bhaumik",
                    LastName = "Prajapati",
                    Phone = "647-832-1825",
                    Email = "bbdm@gmail.com",
                    Organization = "IndianOcean"
                },
                new Contact
                {
                    ContactId = 10,
                    CategoryId = 3,
                    FirstName = "Prajapati",
                    LastName = "Daksh",
                    Phone = "647-832-1825",
                    Email = "prpjdksh@gmail.com",
                    Organization = "Shrushti"
                }
            );
        }
    }
}

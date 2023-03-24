using Microsoft.EntityFrameworkCore;
using SchoolManagmentSystemDomainLayer.Model;

namespace SchoolManagementSystemRepositoryLayer
{
    public class SMSContext : DbContext
    {
        //public SMSContext(DbContextOptionsBuilder options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DOTNET-01\\USER101;Database=SchoolManagementSystem;Trusted_Connection=True;");
        }
        DbSet<Course> Courses { get; set; }
        DbSet<Student> Students { get; set; }
        DbSet<Teacher> Teachers { get; set; }
    }
}

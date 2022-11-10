using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TimeT.Auth.Model;
using TimeT.Data.Entities;

namespace TimeT.Data
{
    public class RestContext : IdentityDbContext<TimeTUser>
    {
        public DbSet<Service> Services { get; set; }
        public DbSet<Time> Times { get; set; }
        public DbSet<Registration> Registrations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433; Database=saitynas; User=sa; Password =Pasword1-;");
        }
    }
}

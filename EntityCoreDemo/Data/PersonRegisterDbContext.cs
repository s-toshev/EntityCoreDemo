
using PersonRegister.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityCoreDemo.Data
{
    public class PersonRegisterDbContext : DbContext
    {
        public DbSet<Person> Person {  get; set; }

        public PersonRegisterDbContext(DbContextOptions options) : base (options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>();
        }

    }
}

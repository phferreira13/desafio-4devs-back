using desafio_4devs_domain.Models;
using Microsoft.EntityFrameworkCore;

namespace desafio_4devs_entity.Context
{
    public class App4DevsContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public App4DevsContext(DbContextOptions<App4DevsContext> options) : base(options)
        {
        }

        //create OnModelCreating method
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Get all configurations
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(App4DevsContext).Assembly);
        }

    }
}

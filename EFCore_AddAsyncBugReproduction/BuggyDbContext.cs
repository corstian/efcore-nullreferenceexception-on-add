using Microsoft.EntityFrameworkCore;

namespace EFCore_AddAsyncBugReproduction
{
    public class BuggyDbContext : DbContext
    {
        private string _connectionString = "Data Source=(localdb)\\.;Initial Catalog=EFBugSmash1;Integrated Security=True;";

        public DbSet<Bug> Bugs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString, q => q.UseNetTopologySuite());

            base.OnConfiguring(optionsBuilder);
        }
    }
}

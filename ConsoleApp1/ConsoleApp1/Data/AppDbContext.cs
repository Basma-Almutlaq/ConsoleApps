using Microsoft.EntityFrameworkCore;
public class AppDbContext : DbContext
{
        public DbSet<Patients> Patient { get; set; }

   public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

}
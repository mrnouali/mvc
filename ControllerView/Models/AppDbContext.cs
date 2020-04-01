using Microsoft.EntityFrameworkCore;

namespace ControllerView.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>(t =>
            {
                t.HasOne(tsk => tsk.Category)
                    .WithMany(c => c.Tasks)
                    .HasForeignKey(tsk => tsk.CategoryId);
            });
        }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
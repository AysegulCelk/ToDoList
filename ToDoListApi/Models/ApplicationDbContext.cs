using Microsoft.EntityFrameworkCore;

namespace ToDoListApi.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<ToDoItem> ToDoItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoItem>().HasData(
                new ToDoItem() { Id = 1, Name = "Do the shopping" },
                new ToDoItem() { Id = 2, Name = "clean your house" }
                );
        }
    }
}

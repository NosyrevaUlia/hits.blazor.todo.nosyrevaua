using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TodoServerApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public virtual DbSet <TaskItem> TaskItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<TaskItem>().HasData([
                new () {Id = 1, Title="Task 1", Description = "Task 1 Description", CreatedDate=DateTime.Now},
                new () {Id = 2, Title="Task 2", Description = "Task 2 Description", CreatedDate=DateTime.Now},
                new () {Id = 3, Title="Task 3", Description = "Task 3 Description", CreatedDate=DateTime.Now},
                new () {Id = 4, Title="Task 4", Description = "Task 4 Description", CreatedDate=DateTime.Now},
                ]);
        }
    }
}

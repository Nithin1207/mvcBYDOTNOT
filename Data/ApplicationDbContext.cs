using sellyourcar.Models;

using Microsoft.EntityFrameworkCore;



namespace sellyourcar.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<DatabaseViewModel> DatabaseViewModel { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DatabaseViewModel>().HasData(
            new DatabaseViewModel
            {
                Id = 101,
                Title = "God with Blue Heart",
                Content = "devil is coming",
                Created = new DateTime(2025, 6, 30, 12, 0, 0)
            },
            new DatabaseViewModel
            {
                Id = 102,
                Title = "Black skyies with lighting",
                Content = "Water raising",
                Created = new DateTime(2025, 6, 30, 12, 0, 0)
            }

            );
        }
    }

}
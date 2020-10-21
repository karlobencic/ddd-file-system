using Microsoft.EntityFrameworkCore;

namespace P3.Challenge.FileSystemApp.Repository
{
    public class P3DbContext : DbContext
    {
        public DbSet<Model.Folder> Folders { get; set; }
        public DbSet<Model.File> Files { get; set; }

        public P3DbContext(DbContextOptions<P3DbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Model.Folder>()
                .ToTable("Folder");

            modelBuilder.Entity<Model.File>()
                .ToTable("File");
        }
    }
}

using Microsoft.EntityFrameworkCore;
using UniversityApi.Models;

namespace UniversityApi.DataAcess
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options) { }

        public DbSet<User>? Users { get; set; }

        public DbSet<Course>? Courses { get; set; }

        public DbSet<Chapter>? Chapters { get; set; }

        public DbSet<Category>? Categories { get; set; }

        public DbSet<Student>? Students { get; set; }
    }
}

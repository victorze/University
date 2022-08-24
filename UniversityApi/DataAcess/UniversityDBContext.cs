using Microsoft.EntityFrameworkCore;
using UniversityApi.Models;

namespace UniversityApi.DataAcess
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options) { }

        public DbSet<User>? Users { get; set; }
    }
}

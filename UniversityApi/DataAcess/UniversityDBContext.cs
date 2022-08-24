using Microsoft.EntityFrameworkCore;

namespace UniversityApi.DataAcess
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options) { }
    }
}

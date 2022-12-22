using Microsoft.EntityFrameworkCore;

namespace UniversityApiBackend.DataAccess
{
    public class DbContextUniversity : DbContext
    {
        // DB Context
        public DbContextUniversity(DbContextOptions<DbContextUniversity> options) : base(options)
        {

        }

        // Mapear Tablas
        public DbSet<Course> Courses { get; set; }
        public DbSet<Chapter> chapters { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<User>? Users { get; set; }
    }
}


using Filtro.Models;
using Microsoft.EntityFrameworkCore;

namespace Filtro.Data
{
    public class SistemaSgContext(DbContextOptions<SistemaSgContext> options) : DbContext(options)
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course>Courses{ get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
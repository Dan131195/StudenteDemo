using Microsoft.EntityFrameworkCore;
using Studente.Models;

namespace Studente.Data
{
    public class StudenteDbContext : DbContext
    {
            public StudenteDbContext(DbContextOptions<StudenteDbContext> options) : base(options) { }
            public DbSet<Student> Studenti { get; set; }
    }
}

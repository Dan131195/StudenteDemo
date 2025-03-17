using Microsoft.EntityFrameworkCore;
using Studente.Data;
using Studente.Models;

namespace Studente.Services
{
    public class StudenteService
    {
        private readonly StudenteDbContext _context;
        public StudenteService(StudenteDbContext context)
        {
            _context = context;
        }

        public async Task<List<Student>> GetStudentiAsync()
        {
            return await _context.Studenti.ToListAsync();
        }

        public async Task<Student> GetStudenteByIdAsync(int id)
        {
            return await _context.Studenti.FindAsync(id);
        }

    }
}

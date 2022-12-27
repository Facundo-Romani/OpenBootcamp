using Microsoft.EntityFrameworkCore;
using UniversityApiBackend.DataAccess;
using UniversityApiBackend.Models.DataModels;

namespace UniversityApiBackend.Service
{
    public class StudentService : IStudentService
    {
        private readonly DbContextUniversity _context;
        public StudentService(DbContextUniversity context)
        {
            _context = context;
        }
        public async Task<Student> GetStudentByAge(int age)
        {
            return await _context.Students.Where(s => age >= 18).Select(s => s).FirstOrDefaultAsync();
        }
    }
}

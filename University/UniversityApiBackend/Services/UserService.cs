using Microsoft.EntityFrameworkCore;
using UniversityApiBackend.DataAccess;
using UniversityApiBackend.Models.DataModels;
using UniversityApiBackend.Service;

namespace UniversityApiBackend.Services
{
    public class UserService : IUserService
    {
        private readonly DbContextUniversity _context;
        public UserService(DbContextUniversity context)
        {
            _context = context;
        }

        public async Task<User> GetUserEmail(string email)
        {
            var uEmail = await _context.Users.Where(u => u.Email == email).Select(u => u).FirstOrDefaultAsync();

            return uEmail;  
        }
    }
}

using UniversityApiBackend.Models.DataModels;

namespace UniversityApiBackend.Service
{
    public interface IUserService
    {
       Task<User> GetUserEmail(string email);
    }
}

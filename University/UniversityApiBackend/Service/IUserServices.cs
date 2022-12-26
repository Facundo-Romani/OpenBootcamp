using UniversityApiBackend.Models.DataModels;

namespace UniversityApiBackend.Service
{
    public interface IUserServices
    {
       Task<User> GetUserEmail(string email);
    }
}

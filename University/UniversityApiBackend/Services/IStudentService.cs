using UniversityApiBackend.Models.DataModels;

namespace UniversityApiBackend.Service
{
    public interface IStudentService
    {
        Task<Student> GetStudentByAge (int age);
    }
}

using StudentManagementAPI.Models;

namespace StudentManagementAPI.Services
{
    // Services/IStudentService.cs
    public interface IStudentService
    {
        Task<List<Student>> GetAllStudents();
        Task AddStudent(Student student);
        Task UpdateStudent(Student student);
        Task DeleteStudent(int id);
    }
}

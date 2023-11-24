using MyWebApp.Models;

namespace MyWebApp.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();

        Student GetById(int id);
    }
}
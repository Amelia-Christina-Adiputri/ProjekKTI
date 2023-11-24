using MyWebApp.Models;

namespace MyWebApp.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private static List<Student> students =  new List<Student>{
            new Student { StudentId = 1, Name = "John Doe", Email = "John@gmail.com", BirthDate = new DateOnly(1990, 1, 1) },
            new Student { StudentId = 2, Name = "Jane Doe", Email = "Jane@gmail.com", BirthDate = new DateOnly(1990, 1, 1) },
            new Student { StudentId = 3, Name = "Jack Doe", Email = "Jack@gmail.com", BirthDate = new DateOnly(1990, 1, 1) },
            new Student { StudentId = 4, Name = "Jill Doe", Email = "Jill@gmail.com", BirthDate = new DateOnly(1990, 1, 1) },
            new Student { StudentId = 5, Name = "James Doe", Email = "James@gmail.com", BirthDate = new DateOnly(1990, 1, 1) }
        };
        public IEnumerable<Student> GetAll()
        {
            return students;
        }

        public Student GetById(int id)
        {
            return students.First(s => s.StudentId == id);
        }
    }
}
using Data_table.Models;

namespace Data_table.IService
{
    public class IStudentService
    {
        List<Student> GetStudents();

        Student GetById(int studentid);

        void Save(Student ostudent);

        void Update(Student ostudent);

        string Delete(int studentid);
    }
}

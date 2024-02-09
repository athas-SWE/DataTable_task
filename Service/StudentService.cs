using Data_table.Context;
using Data_table.IService;
using Data_table.Models;

namespace Data_table.Service
{
    public class StudentService : IStudentService
    {
        private readonly DatabaseContext _context;
        public StudentService(DatabaseContext context) 
        { 
            _context = context;
        
        }
        public string Delete(int studentId)
        {
            var student = _context.Students.FirstOrDefault(x => x.StudentId == studentId);
            if (student != null)
            {
                _context.Students.Remove(student);
            }
            return "Deleted";
        }

        public Student GetById(int studentId) 
        {
            return _context.Students.FirstOrDefault(x => x.StudentId == studentId);
        }

        public List<Student> GetStudents()
        {
            return _context.Students.ToList();
                
        }

        public void Save(Student oStudent)
        {
            _context.Students.Add(oStudent);
            _context.SaveChanges();
        }

        public void Update(Student oStudent)
        {
            _context.Students.Add(oStudent);
            _context.SaveChanges();
        }
    }
}

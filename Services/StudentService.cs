using StudentAPI.Interfaces;
using StudentAPI.Models;
namespace StudentAPI.Services
{
    public class StudentService : IStudentService
    {
        IStudentRepository repo;
        public StudentService(IStudentRepository repository)
        {
            repo = repository;
        }
        public ICommon Create(Student stu)
        {
            throw new System.NotImplementedException();
        }

        public ICommon Delete(Student stu)
        {
            throw new System.NotImplementedException();
        }

        public StudentList Read()
        {
            return repo.GetList();
        }

        public ICommon Update(Student stu)
        {
            throw new System.NotImplementedException();
        }
    }
}
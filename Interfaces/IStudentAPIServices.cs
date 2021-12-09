using StudentAPI.Models;
using StudentAPI.Repositories;
using StudentAPI.Interfaces;

namespace StudentAPI.Interfaces
{
    
    public interface IStudentService
    {
        public ICommon Create(Student stu);
        public ICommon Update(Student stu);
        public StudentList Read();
        public ICommon Delete(Student stu);
    }
     public interface ICourseService
    {
        public ICommon Create(Subject stu);
        public ICommon Update(Subject stu);
        public StudentList Read();
        public ICommon Delete(Subject stu);
    }
}
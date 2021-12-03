using StudentAPI.Models;
using StudentAPI.Repositories;

namespace StudentAPI.Business
{
    public class StudentBL
    {
        StudentRepository repo;
        public StudentBL()
        {
            repo = new StudentRepository();
        }
        public ICommon Create(Student stu)
        {
            return repo.Create(stu);
        }
        
    }
    
}
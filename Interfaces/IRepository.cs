using System.Collections.Generic;
using StudentAPI.Models;

namespace StudentAPI.Interfaces
{
    public interface IRepository<T>
    {
        ICommon Create(T t);
        ICommon Update(T t);
        ICommon Delete(T t);
    }

    public interface IStudentRepository:IRepository<Student>
    {
        StudentList GetList();
    }
}
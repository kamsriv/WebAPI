using System.Collections.Generic;
using StudentAPI.Models;

namespace StudentAPI
{
    interface IRepository<T>
    {
        ICommon Create(T t);
        ICommon Update(T t);
        ICommon Delete(T t);
    }

    interface IStudentRepository:IRepository<Student>
    {
        StudentList GetList();
    }
}
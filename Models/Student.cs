using System.Collections.Generic;

namespace StudentAPI.Models
{
    public class Student:IStudent
    {
        public long stuID{get;set;}
        public string Name{get;set;}
        public int Section{get;set;}
        public int Class{get;set;}
        public IAddress Address{get;set;}
        public List<ISubject> Subjects{get;set;}
    }

    public class StudentList: Common
    {
        public StudentList():base(){}
        public StudentList(string msg, bool success): base(msg,success){}
        public List<IStudent> Students{get;set;}
    }

}
using System.Collections.Generic;
namespace StudentAPI.Models
{
    public class Subject : ISubject
    {
        public int ID { get;set; }
        public string Name { get;set;}
        public int Marks { get;set;}
        public string Term { get;set;}
    }

    public class SubjectList : Common
    {
        public SubjectList():base(){}
        public SubjectList(string msg, bool success):base(msg, success){}
        public List<Subject> Subjects{get;set;}
    }
}
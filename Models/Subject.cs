
namespace StudentAPI
{
    class Subjects : ISubject
    {
        public int ID { get;set; }
        public string Name { get;set;}
        public int Marks { get;set;}
        public string Term { get;set;}
    }
}
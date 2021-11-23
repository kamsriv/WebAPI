using System;
using Xunit;
using StudentAPI;
using System.Data;
namespace WebAPI
{
    public class DataModel_UnitTests
    {
        [Fact]
        public void TestStudent()
        {
            Console.WriteLine(conStr);
            Assert.Equal(conStr,"Hello");
            // var con = DB.GetConnection();
            // Assert.IsType<IDbConnection>(con);
            /*StudentRepository repository = new StudentRepository();
            Student stu = new Student(){Name="Rama",stuID=1,Class=1,Section=1,Address=null,Subjects=null };
            Assert.Same(repository.Create(stu).IsSuccess,true);*/
        }
    }
}

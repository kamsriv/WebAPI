using System;
using Xunit;
using StudentAPI;
using Microsoft.AspNetCore.Mvc.Testing;
namespace WebAPI
{
    public class DataModel_UnitTests : IClassFixture<WebApplicationFactory<Startup>>
    {

        private readonly WebApplicationFactory<Startup> _factory;

        public DataModel_UnitTests(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public void TestConnection()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = client.GetAsync("http://localhost:5000/Student");
            Assert.Equal("200",response.Status.ToString());

        }

        [Fact]
        public void TestStudent()
        {
            Console.WriteLine(DB.ConStr);
            Assert.Equal("server=localhost\\sqlexpress;database=student;uid=sa;pwd=Neev@123", DB.ConStr);
            // var con = DB.GetConnection();
            // Assert.IsType<IDbConnection>(con);
            /*StudentRepository repository = new StudentRepository();
            Student stu = new Student(){Name="Rama",stuID=1,Class=1,Section=1,Address=null,Subjects=null };
            Assert.Same(repository.Create(stu).IsSuccess,true);*/
        }
    }
}

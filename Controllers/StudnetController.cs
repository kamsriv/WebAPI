using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentAPI.Interfaces;
using StudentAPI.Models;
using StudentAPI.Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class StudentController : ControllerBase
    {
        IStudentService _service;
        public StudentController(IStudentService stuService)
        {
            _service = stuService;
        }
        [HttpPost]
        public OkResult Create([FromBody] Student student)
        {
            _service.Create(student);
            return Ok();
        }
        [HttpGet]
        public ActionResult Get()
        {            
            StudentList students = _service.Read();
            ErrLogger.LogMessage("Getting the student information", ErrLogger.LogType.FATAL);
            return Ok(students);
        }
    }
}

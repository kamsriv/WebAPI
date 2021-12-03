using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentAPI.Repositories;
using StudentAPI.Models;
using StudentAPI.Business;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        public StudentController()
        {

        }
        [HttpPost]
        public OkResult Create([FromBody] Student student)
        {
            return Ok();
        }
        [HttpGet]
        public ActionResult Get()
        {            
            
            ErrLogger.LogMessage("Getting the student information", ErrLogger.LogType.FATAL);
            return Ok("Fetched the student Results");
        }
    }
}

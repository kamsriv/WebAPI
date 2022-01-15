using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;
namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubjectController : ControllerBase
    {
        public SubjectController()
        {

        }
        [HttpPost]
        public OkResult Create([FromBody] Subject subject)
        {
               
            return Ok();
        }
        [HttpGet]
        public ActionResult Get()
        {            
            
            ErrLogger.LogMessage("Getting the Course information", ErrLogger.LogType.FATAL);
            return Ok("Fetching subject Results");
        }
    }
}

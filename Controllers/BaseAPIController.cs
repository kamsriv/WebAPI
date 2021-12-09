using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

[Route("api/[controller]")]
[ApiController]
public abstract class BaseApiController<TLoginRequest> : ControllerBase
where TLoginRequest : LoginRequest
{
    [Route("login")]
    public virtual HttpResponseMessage Login(TLoginRequest request)
    {
        return new HttpResponseMessage();
    }
    
}
using Microsoft.AspNetCore.Mvc;

namespace dapr.microservice.webapi.Controllers
{
    [ApiController]
    //[Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet("hello")]
        public IActionResult Get()
        {
            Console.WriteLine("Hello world");
            return Ok("Hello world 5");
        } 
    }
}

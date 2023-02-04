using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            string name = "home page";
            return Ok(name);
        }
    }
}

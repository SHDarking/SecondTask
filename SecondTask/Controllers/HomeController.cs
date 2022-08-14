using Microsoft.AspNetCore.Mvc;
using SecondTask.Interfaces;

namespace SecondTask.Controllers
{
    [ApiController]
    [Route("api")]
    public class HomeController : Controller
    {
        private readonly IRepository _repository;
        public HomeController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("books")]        
        public IActionResult GetAllBooks(string order)
        {
            string response = "response";
            return Ok(response);
        }
    }
}

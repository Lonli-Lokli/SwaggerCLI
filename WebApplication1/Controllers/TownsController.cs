using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TownsController : ControllerBase
    {
        [HttpGet()]
        public Town Get()
        {
            return new Town()
            {
                Id = 1,
                Name = "London"
            };
        }
    }
}
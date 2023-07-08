using Microsoft.AspNetCore.Mvc;
using Villa_API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Villa_API.Controllers
{
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Villa> GetVillas()
        {
            return new List<Villa>
            {
                new Villa {Id=1, Name = "Pool View"},
                new Villa {Id=2, Name = "Beach View"}
            };
        }
    }
}


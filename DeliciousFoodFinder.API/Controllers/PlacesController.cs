using Asp.Versioning;
using DeliciousFoodFinder.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DeliciousFoodFinder.API.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class PlacesController : ControllerBase
    {
        private readonly ILogger<PlacesController> _logger;

        public PlacesController(ILogger<PlacesController> logger)
        {
            _logger = logger;
        }
        /// <summary>
        ///  Return all registered places 
        /// </summary>
        /// <returns>Returns a list of Places objects representing all available places to eat </returns>
        [HttpGet]
        [Produces(typeof(List<Place>))]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public IActionResult Get() 
        {
            return Ok();
        }

        [HttpPost]
        [Produces(typeof(Place))]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Post()
        {
            return Ok();
        }
    }
}

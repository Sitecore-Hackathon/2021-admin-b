using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RenderingHost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {

        private readonly ILogger<MoviesController> _logger;

        public MoviesController(ILogger<MoviesController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public String Post(String selectedmovies)
        {
            var movieIds = selectedmovies.Split('|');
            var movieItems = movieIds.Select(x => Sitecore.Context.Database.GetItem(x));

            // get the movie recommended based on these movies
            

            return "";
        }
    }
}

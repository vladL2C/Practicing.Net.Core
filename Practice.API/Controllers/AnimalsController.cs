using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Practice.API.Models;
using Practice.API.Services;
using Practice.API.Services.AnimalService;

namespace Practice.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnimalsController : ControllerBase
    {

        private readonly IAnimalService _animalService;

        public AnimalsController(IAnimalService animalService)
        {
            _animalService = animalService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var list = _animalService.FindAll();
            return new JsonResult(list);
        }

    }
}

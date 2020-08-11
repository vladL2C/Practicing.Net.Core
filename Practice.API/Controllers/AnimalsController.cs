using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Practice.API.Models;
using Practice.API.Services;

namespace Practice.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnimalsController : ControllerBase
    {

        private readonly IMongoCollection<Animal> _respository;

        public AnimalsController(IMongoDbService<Animal> respository)
        {
            _respository = respository.GetCollection("animals");
        }

        [HttpGet]
        public ActionResult Get()
        {
            var list = _respository.Find(animal => true).ToList();
            return new JsonResult(list);
        }

        [HttpPost]
        public ActionResult createAnimal(Animal animal)
        {

            _respository.InsertOne(animal);

            return new JsonResult(animal);
        }
    }
}

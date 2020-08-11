using Practice.API.Models;
using System.Collections.Generic;

namespace Practice.API.Services.AnimalService
{
    public interface IAnimalService
    {
        List<Animal> FindAll();
    }
}
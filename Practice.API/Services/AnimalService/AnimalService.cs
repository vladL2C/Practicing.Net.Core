using MongoDB.Driver;
using Practice.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.API.Services.AnimalService
{
    public class AnimalService : IAnimalService
    {
        private IMongoCollection<Animal> _collection;
        public AnimalService(IMongoDbService<Animal> collection)
        {
            _collection = collection.GetCollection();
        }

        public List<Animal> FindAll()
        {
            var list = _collection.Find(animal => true).ToList();
            return list;
        }
    }
}

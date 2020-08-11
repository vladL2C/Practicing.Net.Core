using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using Practice.API.Models;
using System.Collections;
using System.Collections.Generic;

namespace Practice.API.Services
{
    public class MongoDbService<TDocument> : IMongoDbService<TDocument>
    {
        private IMongoDatabase _database;

        public MongoDbService(IConfiguration configuration)
        {
            _database = new MongoClient(configuration["MongoDBSettings:ConnectionString"]).GetDatabase(configuration["MongoDBSettings:DatabaseName"]);
        }

        public IMongoCollection<TDocument> GetCollection(string collection)
        {
            return _database.GetCollection<TDocument>(collection);
        }

    }
}

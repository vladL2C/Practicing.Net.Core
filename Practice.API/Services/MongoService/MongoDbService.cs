using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using Practice.API.Attributes;
using System;
using System.Linq;

namespace Practice.API.Services
{
    public class MongoDbService<TDocument> : IMongoDbService<TDocument>
    {
        private IMongoCollection<TDocument> _collection;

        public MongoDbService(IConfiguration configuration)
        {
            var database = new MongoClient(configuration["MongoDBSettings:ConnectionString"]).GetDatabase(configuration["MongoDBSettings:DatabaseName"]);
            _collection = database.GetCollection<TDocument>(GetCollectionName(typeof(TDocument)));
        }

        private string GetCollectionName(Type documentType)
        {
            var bsonCollectionAttribute = (BsonCollectionAttribute)documentType.GetCustomAttributes(
                    typeof(BsonCollectionAttribute),
                    true).FirstOrDefault();

            return bsonCollectionAttribute.CollectionName;
        }

        public IMongoCollection<TDocument> GetCollection()
        {
            return _collection;
        }

    }
}

using MongoDB.Driver;

namespace Practice.API.Services
{
    public interface IMongoDbService<TDocument>
    {
        public IMongoCollection<TDocument> GetCollection();
    };
}
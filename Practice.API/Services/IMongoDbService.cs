using MongoDB.Driver;

namespace Practice.API.Services
{
    public interface IMongoDbService<TDocument>
    {
        IMongoCollection<TDocument> GetCollection(string collection);
    }
}
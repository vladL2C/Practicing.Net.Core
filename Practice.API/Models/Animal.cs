using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Practice.API.Models
{
    
    public class Animal
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public int Phone { get; set; }

        public string Email { get; set; }

    }
}

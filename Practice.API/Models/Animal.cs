using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Practice.API.Attributes;
using System.Security.Cryptography;

namespace Practice.API.Models
{
    [BsonCollection("animals")]
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

        public string UserName { get; set; }

    }
}

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Practice.API.Attributes;


namespace Practice.API.Models
{
    [BsonCollection("users")]
    public class Users
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement]
        public string Id { get; set; }

        public string UserName { get; set; }

        public int Phone { get; set; }

        public string Email { get; set; }

    }
}

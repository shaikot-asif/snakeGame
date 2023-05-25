using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace MongoDBDemo
{
    public class userModel
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.model
{
    public class UsersScore
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public int Score { get; set; }
        public string UserName { get; set; }
    }
}

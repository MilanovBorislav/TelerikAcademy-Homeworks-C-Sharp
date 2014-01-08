using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Mongo.Data
{
    public interface IMongoEntity
    {
        [BsonId]
        ObjectId _id { get; set; }
    }
}

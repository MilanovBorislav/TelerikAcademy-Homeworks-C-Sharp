using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Mongo.Data
{
    public class Word:IMongoEntity
    {
        public ObjectId _id { get; set; }
        public string WordNative { get; set; }
        public string Translation { get; set; }
        public BsonDateTime TimeInserted { get; set; }
    }
}

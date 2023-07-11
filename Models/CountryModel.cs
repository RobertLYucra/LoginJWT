using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LoginJWT.Models
{
    public class CountryModel
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Name { get; set; }
    }
}

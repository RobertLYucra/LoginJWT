using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LoginJWT.Models
{
    public class UserModel
    {
        [BsonId] 
        public ObjectId Id { get; set; }
        public string Username { get; set; }
        public string password { get; set; }
        public string EmailAddress { get; set; }
        public string Rol { get; set; }
        public string Lastname { get; set; }
        public string FirstName { get; set; }
    }
}

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Accounts.Models
{
    public class Account
    {
        [BsonIgnoreIfDefault]
        public ObjectId _id;
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }

        public Account()
        {
            Login = "";
            Password = "";
            Name = "";
            SurName = "";
            Email = "";
        }
    }
}

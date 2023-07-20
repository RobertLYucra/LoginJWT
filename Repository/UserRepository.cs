using LoginJWT.Models;
using LoginJWT.Repository.Interfaces;
using LoginJWT.Resource;
using MongoDB.Driver;

namespace LoginJWT.Repository
{
    public class UserRepository : IUserRepository
    {
        internal MongoResource _mongoResource = new MongoResource();
        private IMongoCollection<UserModel> Collection;

        public UserRepository(MongoResource mongoResource)
        {
            _mongoResource = mongoResource;
            Collection = _mongoResource.database.GetCollection<UserModel>("Users");
        }

        public async Task<UserModel> CreateUser(UserModel user)
        {
            try
            {
                await Collection.InsertOneAsync(user);
                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

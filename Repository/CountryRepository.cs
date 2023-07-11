using LoginJWT.Constans;
using LoginJWT.Models;
using LoginJWT.Repository.Interfaces;
using LoginJWT.Resource;
using MongoDB.Bson;
using MongoDB.Driver;

namespace LoginJWT.Repository
{
    public class CountryRepository : ICountryRepository
    {
        internal MongoResource _mongoResource = new MongoResource();
        private IMongoCollection<CountryModel> Collection;

        public CountryRepository()
        {
            Collection = _mongoResource.database.GetCollection<CountryModel>("Countries");
        }
        public async Task<List<CountryModel>> GetAllCounties()
        {
            return await Collection.FindAsync(new BsonDocument()).Result.ToListAsync();
        }
    }
}

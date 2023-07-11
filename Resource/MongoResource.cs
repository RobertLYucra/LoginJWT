using MongoDB.Driver;

namespace LoginJWT.Resource
{
    public class MongoResource
    {
        public MongoClient client;
        public IMongoDatabase database;

        public MongoResource()
        {
            client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("EmpresaC");

        }
    }
}

using MongoDB.Driver;
using System.Security.Authentication;

namespace LoginJWT.Resource
{
    public class MongoResource
    {
        public MongoClient client;
        public IMongoDatabase database;

        public MongoResource()
        {
            string connectionString = @"mongodb://login:S2tLTbzna0st9VGA4AcaKoQvmbe0bFv8UQNeMLTQr15RKroBcbETLQ8ZsZCZXV5Tb06AD1WtRxcUACDbdxlqoA==@login.mongo.cosmos.azure.com:10255/?ssl=true&retrywrites=false&replicaSet=globaldb&maxIdleTimeMS=120000&appName=@login@";
            MongoClientSettings settings = MongoClientSettings.FromUrl(
              new MongoUrl(connectionString));
            settings.SslSettings = new SslSettings() { EnabledSslProtocols = SslProtocols.Tls12 };
            client = new MongoClient(settings);
            database = client.GetDatabase("Credentials");
        }
    }
}

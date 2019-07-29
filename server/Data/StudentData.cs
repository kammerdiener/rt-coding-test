using Microsoft.Extensions.Options;
using MongoDB.Driver;
using server.Model;

namespace server.Data
{
    public class StudentContext
    {
        private readonly IMongoDatabase _database = null;

        public StudentContext(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<Student> Students
        {
            get
            {
                return _database.GetCollection<Student>("Students");
            }
        }
    }
}
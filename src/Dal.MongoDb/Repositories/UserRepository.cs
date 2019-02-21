using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Devpro.AspNetCoreTestingSample.Domain.DocumentModels;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Devpro.AspNetCoreTestingSample.Dal.MongoDb.Repositories
{
    public class UserRepository
    {
        public async Task<List<UserModel>> DummyCheckAsync()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("foo");
            var collection = database.GetCollection<BsonDocument>("bar");

            await collection.InsertOneAsync(new BsonDocument("Name", "Jack"));

            var entities = await collection.Find(new BsonDocument("Name", "Jack"))
                .ToListAsync();

            return entities.Select(x => new UserModel
                {
                    Id = x["_id"].AsObjectId.ToString(),
                    FirstName = x["Name"].AsString,
                })
                .ToList();
        }
    }
}

using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrueViewMonolithAPI.Persistence.Mongo {
    public class MongoEngine {

        private readonly MongoConnectionInfo connInfo;
        private readonly MongoClient client;
        private readonly IMongoDatabase database;

        public MongoEngine(MongoConnectionInfo connInfo) {
            this.connInfo = connInfo;
            client = new MongoClient(connInfo.ConnectionString());
            database = client.GetDatabase(connInfo.Database);
        }

        public IMongoDatabase GetDatabase() {
            return database;
        }

    }
}

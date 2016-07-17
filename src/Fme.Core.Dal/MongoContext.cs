using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fme.Core.Dal
{
    public class MongoContext : BaseContext
    {        
        private IMongoClient _client;
        public IMongoDatabase Database;

        public MongoContext(string connectionName, string databaseName) : base(connectionName) {
            _client = new MongoClient(ConnectionString);
            Database = _client.GetDatabase(databaseName);
        }
    }
}

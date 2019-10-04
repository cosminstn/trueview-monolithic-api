using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrueViewMonolithAPI.Persistence.Mongo {
    public class MongoConnectionInfo {

        public string Host { get; }
        public int Port { get; }
        public string Database { get; }
        public string Username { get; }
        public string Password { get; }

        public int MyProperty { get; set; }

        public MongoConnectionInfo(string host, int port, string database) {
            this.Host = host;
            this.Port = port;
            this.Database = database;
        }

        public MongoConnectionInfo(string host, int port, string database, string username, string password) {
            this.Host = host;
            this.Port = port;
            this.Database = database;
            this.Username = username;
            this.Password = password;
        }

        /// <summary>
        /// Only supports non username connections for now.
        /// </summary>
        /// <returns></returns>
        public string ConnectionString() {
            return String.Format("mongodb://%s:%d");
        }
    }
}

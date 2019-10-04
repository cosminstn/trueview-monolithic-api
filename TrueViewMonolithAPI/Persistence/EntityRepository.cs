using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace TrueViewMonolithAPI.Persistence {
    public class EntityRepository<T> : IEntityRepository<T> where T : Entity {

        protected IMongoCollection<T> collection;

        public EntityRepository(IMongoDatabase database, string collectionName) {
            collection = database.GetCollection<T>(collectionName);
        }

        public T create(T entry) {
            collection.InsertOne(entity);
            return entity;
        }

        public void delete(ObjectId entryId) {
            collection.DeleteOne(new BsonDocument {
                { "_id", entryId }
            });
        }

        public T get(ObjectId entryId) {
            return collection.Find(new BsonDocument {
                { "_id", entryId }
            }).First();
        }

        public T update(T entry) {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", entry.Id);
            collection.FindOneAndReplace(filter, entry);
            return entry;
        }
    }
}

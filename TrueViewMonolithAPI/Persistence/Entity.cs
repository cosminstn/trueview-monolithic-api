using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrueViewMonolithAPI.Persistence {
    public abstract class Entity {

        public ObjectId Id { get; }

        public Entity() {
            this.Id = new ObjectId();
        }

        public Entity(ObjectId id) {
            this.Id = id;
        }
    }
}

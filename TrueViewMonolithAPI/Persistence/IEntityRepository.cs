using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrueViewMonolithAPI.Persistence {
    public interface IEntityRepository<T> where T : Entity {

        T create(T entry);

        T update(T entry);

        T get(ObjectId entryId);

        void delete(ObjectId entryId);
    }
}

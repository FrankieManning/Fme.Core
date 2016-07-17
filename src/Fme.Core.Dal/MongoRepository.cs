using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fme.Core.Dal
{
    public class MongoRepository<T> : IRepository<T> where T : class
    {
        private IMongoDatabase _db;
        private IMongoCollection<T> _collection;

        public MongoRepository(MongoContext context) {
            _db = context.Database;
            _collection = _db.GetCollection<T>(typeof(T).Name);
        }

        public T Delete(T entity)
        {
            _collection.DeleteOne(entity.ToBsonDocument());
            return entity;
        }

        public T Find(System.Linq.Expressions.Expression<Func<T, bool>> filter)
        {
            return _collection.Find(filter).FirstOrDefault();
        }

        public IEnumerable<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> filter, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return _collection.AsQueryable().ToList();
        }

        public T Insert(T entity)
        {
            _collection.InsertOne(entity);
            return entity;
        }

        public IQueryable<T> Query()
        {
            return _collection.AsQueryable();
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}

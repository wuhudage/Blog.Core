﻿
using Blog.Core.Common;
using MongoDB.Driver;

namespace Blog.Core.Repository.MongoRepository
{

    public class LocationsContext
    {
        private readonly IMongoDatabase _database = null;

        public LocationsContext()
        {
            var client = new MongoClient(Appsettings.app(new string[] { "Mongo", "ConnectString" }));
            if (client != null)
                _database = client.GetDatabase(Appsettings.app(new string[] { "Mongo", "Database" }));
        }

        public IMongoDatabase Db
        {
            get { return _database; }
        }

        //public IMongoCollection<TEntity> Query
        //{
        //    get
        //    {
        //        return _database.GetCollection<TEntity>(nameof(TEntity));
        //    }
        //}
    }
}
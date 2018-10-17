﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories
{
    public class Repository : IRepository<Entity>
    {
        private readonly List<Entity> _collection;

        public Repository(List<Entity> collection)
        {
            _collection = collection;

        }
        public Entity Get(Entity entity)
        {

            var result = _collection.SingleOrDefault(
                x=>x.Id == entity.Id);

            return result;
        }

        public void Add(Entity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _collection.Add(entity);

        }
    }
}
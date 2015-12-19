using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDD.Domain;
using DDD.Domain.IRepository;
using DDD.Infrastructure.Interface;

namespace DDD.Repository
{
    public abstract class BaseRepository<TAggregateRoot> : IRepository<TAggregateRoot>
        where TAggregateRoot : class, IAggregateRoot
    {
        public readonly IDbContext _dbContext;

        public BaseRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(TAggregateRoot aggregateRoot)
        {
            _dbContext.Set<TAggregateRoot>().Add(aggregateRoot);
        }

        public void Update(TAggregateRoot aggregateRoot)
        {
            _dbContext.Entry<TAggregateRoot>(aggregateRoot).State = EntityState.Modified;
        }

        public void Delete(TAggregateRoot aggregateRoot)
        {
            _dbContext.Set<TAggregateRoot>().Remove(aggregateRoot);
        }

        public TAggregateRoot Get(int id)
        {
            return _dbContext.Set<TAggregateRoot>().FirstOrDefault(t => t.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDD.Domain.Entity;
using DDD.Domain.IRepository;
using DDD.Infrastructure.Interface;

namespace DDD.Repository
{
    public  class RoleRepository:BaseRepository<Role>,IRoleRepository
    {
        public RoleRepository(IDbContext dbContext)
            : base(dbContext)
        {
        }

        public Role GetByName(string name)
        {
            return base._dbContext.Set<Role>().Where(x => x.Name == name).FirstOrDefault();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDD.Domain.Entity;

namespace DDD.Domain.IRepository
{
    public interface IRoleRepository: IRepository<Role>
    {
          Role GetByName(string name);
    }
}

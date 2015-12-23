using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDD.Domain.Entity;

namespace DDD.Application.Interface
{
    public interface IRoleService
    {
      Role  GetByName(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDD.Application.Interface;
using DDD.Domain.Entity;
using DDD.Domain.IRepository;
using DDD.Infrastructure.Interface;

namespace DDD.Application
{
    public class RoleService : IRoleService
    {
        private IUnitOfWork _unitOfWork;
        private IRoleRepository _roleRepositorytRepository;
       
        
        public RoleService(IUnitOfWork unitOfWork,
            IRoleRepository roleRepositorytRepository
           )
        {
            _unitOfWork = unitOfWork;
            _roleRepositorytRepository = roleRepositorytRepository;
        
        }

        public Role GetByName (int id)
        {
            return _roleRepositorytRepository.Get(id);
        }

       
    }
}

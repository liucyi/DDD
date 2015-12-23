using System;
using System.Collections.Generic;
using DDD.Domain.Entity;

namespace DDD.Domain.Entity
{
    public class Department : IAggregateRoot
    {
        public int Id { get; set; } // Id (Primary key)
        public string Code { get; set; } // Code
        public string Name { get; set; } // Name
        public int? ParentId { get; set; } // ParentId
        public int? Sort { get; set; } // Sort
        public bool? State { get; set; } // State

        // Reverse navigation
        public virtual ICollection<User> Users { get; set; } // tbUser.FK_TBUSER_REFERENCE_TBDEPART

        
    }
}

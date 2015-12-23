using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDD.Domain.Entity
{
    public class User : IAggregateRoot
    {
        public int Id { get; set; } // Id (Primary key)
        public string Code { get; set; } // Code
        public string Name { get; set; } // Name
        public string Password { get; set; } // Password
        public string Sex { get; set; } // Sex
        public string Tel { get; set; } // Tel
        public string Address { get; set; } // Address
        public string State { get; set; } // State
        public string Type { get; set; } // Type
        public DateTime? CreateTime { get; set; } // CreateTime
        public DateTime? UpdateTime { get; set; } // UpdateTime
       
        public int DepartmentId { get; set; } // DepartmentId


        // Foreign keys
         [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; } // FK_TBUSER_REFERENCE_TBDEPART
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<Menu> Menus { get; set; }

    }
}

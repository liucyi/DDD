using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DDD.Domain.Entity
{
    public class Role : IAggregateRoot
    {
        public int Id { get; set; } // Id (Primary key)
        public string Code { get; set; } // Code
        public string Name { get; set; } // Name
        public string Type { get; set; } // Type
        public string State { get; set; } // State
        public string Description { get; set; } // Description
        public DateTime? CreateTime { get; set; } // CreateTime
        public DateTime? UpdateTime { get; set; } // UpdateTime
      
        public virtual ICollection<Menu> Menus { get; set; }
        public virtual ICollection<User> Users { set; get; }
    }
}

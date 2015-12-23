using System;
using System.Collections.Generic;

namespace DDD.Domain.Entity
{
    public class Menu : IAggregateRoot
    {
        public int Id { get; set; } // Id (Primary key)
        public string Code { get; set; } // Code
        public string Name { get; set; } // Name
        public int? ParentId { get; set; } // ParentId
        public string Url { get; set; } // Url
        public string Iconic { get; set; } // Iconic
        public int? Sort { get; set; } // Sort
        public string State { get; set; } // State
        public bool? IsLeaf { get; set; } // IsLeaf

        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<User> Users { set; get; }
    }
}

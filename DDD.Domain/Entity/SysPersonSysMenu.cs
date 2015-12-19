using System;
using System.Collections.Generic;

namespace DDD.Domain.Entity
{
    public   class SysPersonSysMenu
    {
        public int Id { get; set; }
        public Nullable<int> SysPersonId { get; set; }
        public string SysMenuId { get; set; }
        public virtual SysMenu SysMenu { get; set; }
        public virtual SysPerson SysPerson { get; set; }
    }
}

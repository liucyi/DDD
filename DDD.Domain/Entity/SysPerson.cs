using System;
using System.Collections.Generic;

namespace DDD.Domain.Entity
{
    public class SysPerson : IAggregateRoot
    {
        //public SysPerson()
        //{
        //    this.SysPersonSysMenus = new List<SysPersonSysMenu>();
        //}

        public int Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Sex { get; set; }
        public int SysRoleId { get; set; }
        public int SysDepartmentId { get; set; }

        //public Nullable<int> SysRoleId { get; set; }
        //public Nullable<int> SysDepartmentId { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Type { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpDateTime { get; set; }
        //  public virtual SysDepartment SysDepartment { get; set; }
        //  public virtual ICollection<SysPersonSysMenu> SysPersonSysMenus { get; set; }
        // public virtual SysRole SysRole { get; set; }
    }
}

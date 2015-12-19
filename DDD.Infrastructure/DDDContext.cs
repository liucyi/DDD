using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDD.Domain.Entity;
using DDD.Infrastructure.Interface;

namespace DDD.Infrastructure
{
    public class DDDContext : DbContext, IDbContext
    {
        public DDDContext()
            : base("name=db_ddd")
        {
            //  Database.SetInitializer<DDDContext>(new DropCreateDatabaseAlways<DDDContext>());//初始化时删除数据库
        }
        public DbSet<SysRole> SysRole { get; set; }
        public DbSet<SysPerson> SysPerson { get; set; }
        public DbSet<SysDepartment> SysDepartment { get; set; }
        public DbSet<SysMenu> SysMenu { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SysRole>();
            modelBuilder.Entity<SysMenu>();
            modelBuilder.Entity<SysPerson>();
            modelBuilder.Entity<SysDepartment>();
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//去除复数形式的表名
        }


    }
}

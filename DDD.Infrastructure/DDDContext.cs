using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDD.Domain;
using DDD.Domain.Entity;
using DDD.Infrastructure.Interface;

namespace DDD.Infrastructure
{
    public class DDDContext : DbContext, IDbContext
    {
        public DDDContext()
            : base("name=db_ddd")
        {
       Database.SetInitializer<DDDContext>(
            new DDDContextInitializer()
          // null
           );//初始化时删除数据库
        }
        public DbSet<Role> Role { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Menu> Menu { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
         
            modelBuilder.Entity<Role>().ToTable("tbRole");
            modelBuilder.Entity<Menu>().ToTable("tbMenu");
            modelBuilder.Entity<User>().ToTable("tbUser");
            modelBuilder.Entity<Department>().ToTable("tbDepartment");
            
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//去除复数形式的表名
        }

        public class DDDContextInitializer : DropCreateDatabaseAlways<DDDContext>
        {
            protected override void Seed(DDDContext context)
            {
                var q = new List<Department>
                 {
                     new Department() { Name = "技术部", Code = "D001", ParentId = 0},
                       new Department() { Name = "财务部", Code = "D002", ParentId = 0},
                         new Department() { Name = "后勤部", Code = "D003", ParentId = 0},
                           new Department() { Name = "人事部", Code = "D004", ParentId = 0},
                 };
                q.ForEach(e => context.Department.Add(e));
                context.SaveChanges();
                var u = new List<User>
                {
                    new User() { Name = "Jom", CreateTime =DateTime.Now, Sex = "男", Address = "重庆", Code = "001", DepartmentId = 1},

                    new User() { Name = "Eom", CreateTime =DateTime.Now, Sex = "男", Address = "重庆", Code = "002", DepartmentId = 1},
                    new User() { Name = "Qom", CreateTime =DateTime.Now, Sex = "男", Address = "上海", Code = "003", DepartmentId = 2},
                    new User() { Name = "Wom", CreateTime =DateTime.Now, Sex = "男", Address = "北京", Code = "004", DepartmentId = 2},
                    new User() { Name = "Rom", CreateTime =DateTime.Now, Sex = "男", Address = "重庆", Code = "005", DepartmentId = 3},
                    new User() { Name = "Tom", CreateTime =DateTime.Now, Sex = "男", Address = "上海", Code = "006", DepartmentId = 1},
                    new User() { Name = "Yom", CreateTime =DateTime.Now, Sex = "男", Address = "上海", Code = "007", DepartmentId = 1},
                    new User() { Name = "Uom", CreateTime =DateTime.Now, Sex = "男", Address = "北京", Code = "008", DepartmentId = 2},
                    new User() { Name = "Iom", CreateTime =DateTime.Now, Sex = "男", Address = "重庆", Code = "009", DepartmentId = 3},
                    new User() { Name = "Oom", CreateTime =DateTime.Now, Sex = "男", Address = "北京", Code = "010", DepartmentId = 1},
                    new User() { Name = "Pom", CreateTime =DateTime.Now, Sex = "男", Address = "重庆", Code = "011", DepartmentId = 3},
                    new User() { Name = "Aom", CreateTime =DateTime.Now, Sex = "男", Address = "北京", Code = "012", DepartmentId = 1},
                    new User() { Name = "Som", CreateTime =DateTime.Now, Sex = "男", Address = "重庆", Code = "013", DepartmentId = 1},
                    new User() { Name = "Dom", CreateTime =DateTime.Now, Sex = "男", Address = "上海", Code = "014", DepartmentId = 1},
                };
                 u.ForEach(s=>context.User.Add(s));
                context.SaveChanges();
              
            }
        }
    }
}
